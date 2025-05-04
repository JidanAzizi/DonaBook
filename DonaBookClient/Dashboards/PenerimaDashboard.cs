using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DonaBookApi.Model;
using DonaBookClient.Models;
using DonaBookClient.Services;

namespace DonaBookClient.Dashboards
{
    public static class PenerimaDashboard
    {
        public static async Task ShowAsync(User user)
        {
            var bookService = new BookApiService();

            while (true)
            {
                Console.WriteLine($"\n--- MENU PENERIMA ({user.Name}) ---");
                Console.WriteLine("1. Cari Buku");
                Console.WriteLine("2. Ambil Buku");
                Console.WriteLine("3. Beri Rating dan Review");
                Console.WriteLine("0. Logout");

                Console.Write("Pilih menu: ");
                var input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.Write("Masukkan kata kunci judul atau genre: ");
                        var keyword = Console.ReadLine();

                        var allBooks = await bookService.GetVerifiedBooksAsync();
                        var result = allBooks
                            .Where(b => b.Title.Contains(keyword!) || b.Genre.ToString().Contains(keyword!))
                            .ToList();
                        if (result.Count > 0)
                        {
                            Console.WriteLine("\n📚 Hasil pencarian:");
                            foreach (var b in result)
                            {
                                Console.WriteLine($"[{b.Id}] {b.Title} oleh {b.Author} ({b.Genre}) - Tersedia: {b.Quantity}");
                            }
                        }
                        else {
                            Console.WriteLine("Buku tidak ditemukan!");
                        }
                        break;

                    case "2":
                        Console.Write("ID Buku yang ingin diambil: ");
                        if (!int.TryParse(Console.ReadLine(), out int idToTake))
                        {
                            Console.WriteLine("ID tidak valid.");
                            break;
                        }

                        var success = await bookService.TakeBookAsync(idToTake);
                        Console.WriteLine(success ? "✅ Buku berhasil diambil." : "❌ Gagal mengambil buku (ID tidak ditemukan atau habis).");
                        break;

                    case "3":
                        Console.Write("ID Buku yang ingin direview: ");
                        if (!int.TryParse(Console.ReadLine(), out int reviewId))
                        {
                            Console.WriteLine("ID tidak valid.");
                            break;
                        }

                        Console.Write("Ulasan: ");
                        string reviewText = Console.ReadLine() ?? "";
                        Console.Write("Rating (1-5): ");
                        int rating = int.TryParse(Console.ReadLine(), out int r) ? r : 0;

                        bool reviewed = await bookService.SubmitReviewAsync(reviewId, reviewText, rating);
                        Console.WriteLine(reviewed ? "✅ Review berhasil dikirim." : "❌ Gagal mengirim review.");
                        break;

                    case "0":
                        Console.WriteLine("🔚 Keluar dari dashboard Penerima...");
                        return;

                    default:
                        Console.WriteLine("⚠️ Pilihan tidak valid.");
                        break;
                }
            }
        }
    }
}