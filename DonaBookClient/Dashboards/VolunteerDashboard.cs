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
    public static class VolunteerDashboard
    {
        public static async Task ShowAsync(User user)
        {
            var bookService = new BookApiService();

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"\n--- MENU VOLUNTEER ({user.Name}) ---");
                Console.ResetColor();
                Console.WriteLine("1. Verifikasi Buku");
                Console.WriteLine("2. Lihat Buku yang Sudah Diterima");
                Console.WriteLine("3. Buat Laporan Buku");
                Console.WriteLine("0. Logout");

                Console.Write("Pilih menu: ");
                var input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        var pending = (await bookService.GetAllBooksAsync()).Where(b => !b.IsVerified).ToList();
                        if (!pending.Any())
                        {
                            Console.WriteLine("  Tidak ada buku yang menunggu verifikasi.");
                            break;
                        }

                        Console.WriteLine("\n Buku Belum Diverifikasi:");
                        Console.WriteLine($"{"ID",-4} {"Judul",-25} {"Penulis",-20} {"Qty",-5} {"Status",-10}");
                        Console.WriteLine(new string('-', 70));
                        foreach (var b in pending)
                        {
                            Console.WriteLine($"{b.Id,-4} {b.Title,-25} {b.Author,-20} {b.Quantity,-5} {b.State,-10}");
                        }

                        Console.Write("Masukkan ID buku yang ingin diverifikasi: ");
                        if (!int.TryParse(Console.ReadLine(), out int verifId))
                        {
                            Console.WriteLine("ID tidak valid.");
                            break;
                        }

                        var success = await bookService.VerifyBookAsync(verifId);
                        Console.WriteLine(success ? " Buku berhasil diverifikasi." : " Gagal verifikasi buku.");
                        break;

                    case "2":
                        var books = await bookService.GetVerifiedBooksAsync();
                        var taken = books.Where(b => b.Quantity == 0).ToList();

                        Console.WriteLine("\n📚 Buku yang Sudah Diterima (Quantity = 0):");
                        Console.WriteLine($"{"Judul",-30} {"Penulis",-25}");
                        Console.WriteLine(new string('-', 60));
                        foreach (var b in taken)
                        {
                            Console.WriteLine($"{b.Title,-30} {b.Author,-25}");
                        }
                        break;

                    case "3":
                        var allBooks = await bookService.GetAllBooksAsync();
                        int total = allBooks.Count;
                        int verified = allBooks.Count(b => b.IsVerified);
                        int unverified = total - verified;
                        int donated = allBooks.Sum(b => b.Quantity);

                        Console.WriteLine("\n Laporan Buku:");
                        Console.WriteLine($"Total Buku         : {total}");
                        Console.WriteLine($"Buku Terverifikasi : {verified}");
                        Console.WriteLine($"Buku Belum Verif   : {unverified}");
                        Console.WriteLine($"Total Donasi Buku  : {donated}");
                        break;

                    case "0":
                        Console.WriteLine("Keluar dari dashboard Volunteer...");
                        return;

                    default:
                        Console.WriteLine("Pilihan tidak valid.");
                        break;
                }
            }
        }
    }
}
