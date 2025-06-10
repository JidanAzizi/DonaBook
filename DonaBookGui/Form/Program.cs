// Lokasi: DonaBookGui/Program.cs
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Windows.Forms;

// Pastikan namespace-nya benar sesuai nama proyek Anda
namespace DonaBookGui
{
    internal static class Program
    {
        // INILAH DEFINISI YANG DIBUTUHKAN OLEH BookApiService
        public static IConfiguration Configuration { get; private set; }

        [STAThread]
        static void Main()
        {
            // Kode ini akan membaca file appsettings.json
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            // dan menyimpan hasilnya di properti 'Configuration' di atas
            Configuration = builder.Build();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Ganti ini dengan Form Login Anda jika namanya berbeda
            Application.Run(new Forms.Auth.LoginForm());
        }
    }
}