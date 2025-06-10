using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Menggunakan Model dari API sebagai satu-satunya sumber kebenaran
using DonaBookApi.Model;
using DonaBookClient.Models;

// Menggunakan Service dari proyek Client
using DonaBookClient.Services;

namespace DonaBookClient.Dashboards
{
    public static class DonaturDashboard
    {
        public static async Task ShowAsync(User user)
        {
            var bookService = new BookApiService();

            while (true)
            {
                Console.WriteLine($"\n--- MENU DONATUR ({user.Name}) ---");
                Console.WriteLine("1. Lihat Buku yang Terverifikasi");
                Console.WriteLine("2. Donasi Buku");
                Console.WriteLine("3. Submit Buku");
                Console.WriteLine("4. Lihat Review Buku");
                Console.WriteLine("0. Logout");

                Console.Write("Pilih menu: ");
                var input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        var verifiedBooks = await bookService.GetVerifiedBooksAsync();
                        Console.WriteLine("\n--- Buku Terverifikasi ---");
                        foreach (var b in verifiedBooks)
                        {
                            Console.WriteLine($"- [{b.Id}] {b.Title} oleh {b.Author} ({b.Genre})");
                        }
                        break;

                    case "2":
                        // Bagian ini sudah benar
                        Console.Write("Judul: ");
                        string? title = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(title)) { Console.WriteLine(" Judul tidak boleh kosong."); break; }

                        Console.Write("Penulis: ");
                        string? author = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(author)) { Console.WriteLine(" Penulis tidak boleh kosong."); break; }

                        Console.Write("Penerbit: ");
                        string? publisher = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(publisher)) { Console.WriteLine(" Penerbit tidak boleh kosong."); break; }

                        Console.Write("Genre (Fiction, History, SelfHelp, etc.): ");
                        string? genre = Console.ReadLine();
                        if (!Enum.TryParse<Genre>(genre, true, out var parsedGenre)) { Console.WriteLine(" Genre tidak valid."); break; }

                        Console.Write("Kategori (AnakAnak, Remaja, Dewasa): ");
                        string? category = Console.ReadLine();
                        if (!Enum.TryParse<Category>(category, true, out var parsedCategory)) { Console.WriteLine(" Kategori tidak valid."); break; }

                        Console.Write("Kondisi (Baru, BekasBaik, BekasRusak): ");
                        string? condition = Console.ReadLine();
                        if (!Enum.TryParse<BookCondition>(condition, true, out var parsedCondition)) { Console.WriteLine(" Kondisi buku tidak valid."); break; }

                        Console.Write("Jumlah: ");
                        string? qty = Console.ReadLine();
                        if (!int.TryParse(qty, out int quantity) || quantity <= 0) { Console.WriteLine(" Jumlah harus berupa angka positif."); break; }

                        var book = new Book
                        {
                            Title = title,
                            Author = author,
                            Publisher = publisher,
                            Genre = parsedGenre,
                            Category = parsedCategory,
                            Condition = parsedCondition,
                            Quantity = quantity
                        };

                        // Panggil DonateBookAsync dan dapatkan buku yang baru dibuat
                        var createdBook = await bookService.DonateBookAsync(book);
                        if (createdBook != null)
                        {
                            Console.WriteLine($" Donasi '{createdBook.Title}' berhasil ditambahkan dengan ID: {createdBook.Id}. Silakan submit buku ini dari menu 3.");
                        }
                        else
                        {
                            Console.WriteLine(" Gagal menambahkan donasi.");
                        }
                        break;

                    case "3":
                        var books = (await bookService.GetAllBooksAsync()).Where(b => !b.IsVerified).ToList();
                        if (!books.Any())
                        {
                            Console.WriteLine("Tidak ada buku yang perlu di-submit.");
                            break;
                        }

                        Console.WriteLine("\n--- Pilih buku untuk di-submit ---");
                        foreach (var b in books)
                        {
                            Console.WriteLine($"[{b.Id}] {b.Title} oleh {b.Author}");
                        }

                        Console.Write("Pilih ID buku: ");
                        if (!int.TryParse(Console.ReadLine(), out int bookId))
                        {
                            Console.WriteLine("ID tidak valid.");
                            break;
                        }

                        var bookToSubmit = books.FirstOrDefault(b => b.Id == bookId);
                        if (bookToSubmit == null)
                        {
                            Console.WriteLine(" Buku tidak ditemukan.");
                            break;
                        }

                        // === INI ADALAH PERBAIKANNYA ===
                        await bookService.SubmitAsync(bookToSubmit.Id);
                        Console.WriteLine($" Buku \"{bookToSubmit.Title}\" telah berhasil diajukan dan menunggu verifikasi.");
                        break;

                    case "4":
                        // Bagian ini sudah benar
                        var booksWithReview = await bookService.GetVerifiedBooksAsync();
                        var reviewed = booksWithReview.Where(b => !string.IsNullOrEmpty(b.Review)).ToList();
                        if (!reviewed.Any())
                        {
                            Console.WriteLine("Belum ada review yang tersedia.");
                        }
                        else
                        {
                            foreach (var b in reviewed)
                            {
                                Console.WriteLine($"\n {b.Title}");
                                Console.WriteLine($"   Review: {b.Review}");
                                Console.WriteLine($"   Rating: {b.Rating}/5");
                            }
                        }
                        break;

                    case "0":
                        Console.WriteLine(" Keluar dari dashboard Donatur...");
                        return;

                    default:
                        Console.WriteLine(" Pilihan tidak valid.");
                        break;
                }
            }
        }
    }
}