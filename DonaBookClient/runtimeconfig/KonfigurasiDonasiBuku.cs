using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

class KonfigurasiDonasiBuku
{
    private const string LokasiFileKonfigurasi = "konfigurasi_donasi_buku.json";
    public Konfigurasi konfigurasi { get; set; }

    public KonfigurasiDonasiBuku()
    {
        try
        {
            if (!File.Exists(LokasiFileKonfigurasi))
                throw new FileNotFoundException("File konfigurasi tidak ditemukan.");

            konfigurasi = BacaFileKonfigurasi();
            ValidasiKonfigurasi(); // Defensive check
        }
        catch (Exception)
        {
            AturDefault();
            TulisFileKonfigurasiBaru();
        }
    }

    public class Konfigurasi
    {
        public string bahasa { get; set; } = "id";
        public List<string> fitur_donatur { get; set; }
        public List<string> fitur_penerima { get; set; }
        public List<string> fitur_relawanan { get; set; }
        public Dictionary<string, string> konfirmasi { get; set; }
    }

    private void ValidasiKonfigurasi()
    {
        // Design by Contract – precondition
        if (string.IsNullOrWhiteSpace(konfigurasi.bahasa))
            throw new Exception("Bahasa tidak boleh kosong.");

        if (konfigurasi.fitur_donatur == null || konfigurasi.fitur_donatur.Count == 0)
            throw new Exception("Fitur donatur tidak valid.");

        if (konfigurasi.fitur_penerima == null || konfigurasi.fitur_penerima.Count == 0)
            throw new Exception("Fitur penerima tidak valid.");

        if (konfigurasi.fitur_relawanan == null || konfigurasi.fitur_relawanan.Count == 0)
            throw new Exception("Fitur relawan tidak valid.");

        if (konfigurasi.konfirmasi == null || !konfigurasi.konfirmasi.ContainsKey("id") || !konfigurasi.konfirmasi.ContainsKey("en"))
            throw new Exception("Konfirmasi tidak valid.");
    }

    public void AturDefault()
    {
        konfigurasi = new Konfigurasi
        {
            bahasa = "id",
            fitur_donatur = new List<string>
            {
                "Mengajukan buku donasi",
                "Menghapus buku donasi",
                "Melihat semua buku donasi"
            },
            fitur_penerima = new List<string>
            {
                "Melihat semua buku donasi",
                "Mencari buku",
                "Mengajukan permintaan buku",
                "Memberi ulasan"
            },
            fitur_relawanan = new List<string>
            {
                "Melihat buku yang belum diverifikasi",
                "Memverifikasi kelayakan buku",
                "Membuat laporan (opsional)"
            },
            konfirmasi = new Dictionary<string, string>
            {
                { "en", "yes" },
                { "id", "ya" }
            }
        };
    }

    public void TulisFileKonfigurasiBaru()
    {
        JsonSerializerOptions opsi = new JsonSerializerOptions()
        {
            WriteIndented = true
        };

        string jsonString = JsonSerializer.Serialize(konfigurasi, opsi);
        File.WriteAllText(LokasiFileKonfigurasi, jsonString);
    }

    public Konfigurasi BacaFileKonfigurasi()
    {
        string isiFile = File.ReadAllText(LokasiFileKonfigurasi);
        return JsonSerializer.Deserialize<Konfigurasi>(isiFile);
    }
}
