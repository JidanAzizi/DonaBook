using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DonaBookClient.Models;
using DonaBookClient.Services;
using DonaBookApi.Model;

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
                        Console.WriteLine("\n📚 Buku Terverifikasi:");
                        foreach (var b in verifiedBooks)
                        {
                            Console.WriteLine($"- [{b.Id}] {b.Title} oleh {b.Author} ({b.Genre})");
                        }
                        break;

                    case "2":
                        Console.Write("Judul: "); string? title = Console.ReadLine();
                        Console.Write("Penulis: "); string? author = Console.ReadLine();
                        Console.Write("Penerbit: "); string? publisher = Console.ReadLine();
                        Console.Write("Genre (Fiction, History, SelfHelp, etc.): "); string? genre = Console.ReadLine();
                        Console.Write("Kategori (AnakAnak, Remaja, Dewasa): "); string? category = Console.ReadLine();
                        Console.Write("Kondisi (Baru, BekasBaik, BekasRusak): "); string? condition = Console.ReadLine();
                        Console.Write("Jumlah: ");
                        string? qty = Console.ReadLine();
                        int quantity = int.Parse(qty!);

                        var book = new Book
                        {
                            Title = title!,
                            Author = author!,
                            Publisher = publisher!,
                            Genre = Enum.Parse<Genre>(genre!, ignoreCase: true),
                            Category = Enum.Parse<Category>(category!, ignoreCase: true),
                            Condition = Enum.Parse<BookCondition>(condition!, ignoreCase: true),
                            Quantity = quantity
                        };

                        await bookService.DonateBookAsync(book);
                        Console.WriteLine("✅ Donasi berhasil ditambahkan.");
                        break;

                    case "3":
                        var books = (await bookService.GetAllBooksAsync()).Where(b => !b.IsVerified).ToList();
                        foreach(var b in books)
                        {
                            Console.WriteLine($"[{b.Id}] {b.Title} oleh {b.Author}");
                        }
                        Console.WriteLine("Pilih buku untuk di-submit!");
                        if (!int.TryParse(Console.ReadLine(), out int bookId))
                        {
                            Console.WriteLine("ID tidak valid.");
                            break;
                        }
                        await bookService.SubmitAsync(books.Where(b => b.Id == bookId).FirstOrDefault()!);
                        break;

                    case "4":
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
                                Console.WriteLine($"\n📖 {b.Title}");
                                Console.WriteLine($"   Review: {b.Review}");
                                Console.WriteLine($"   Rating: {b.Rating}/5");
                            }
                        }
                        break;

                    case "0":
                        Console.WriteLine("🔚 Keluar dari dashboard Donatur...");
                        return;

                    default:
                        Console.WriteLine("⚠️ Pilihan tidak valid.");
                        break;
                }
            }
        }
    }
}