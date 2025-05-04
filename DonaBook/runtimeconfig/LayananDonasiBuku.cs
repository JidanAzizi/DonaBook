using System;
using System.Collections.Generic;

class LayananDonasiBuku
{
    private KonfigurasiDonasiBuku konfigurasiDonasi;

    public LayananDonasiBuku()
    {
        konfigurasiDonasi = new KonfigurasiDonasiBuku();
    }

    public void Jalankan()
    {
        try
        {
            string bahasa = konfigurasiDonasi.konfigurasi.bahasa.ToLower();

            if (bahasa != "id" && bahasa != "en")
                throw new ArgumentException("Bahasa tidak didukung.");

            Console.WriteLine(bahasa == "en" ? "Features loaded in English." : "Fitur dimuat dalam Bahasa Indonesia.");

            TampilkanFitur("Donatur", konfigurasiDonasi.konfigurasi.fitur_donatur);
            TampilkanFitur("Penerima", konfigurasiDonasi.konfigurasi.fitur_penerima);
            TampilkanFitur("Relawan", konfigurasiDonasi.konfigurasi.fitur_relawanan);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"[ERROR] {ex.Message}");
        }
    }

    private void TampilkanFitur<T>(string peran, List<T> daftarFitur)
    {
        if (daftarFitur == null || daftarFitur.Count == 0)
        {
            Console.WriteLine($"Tidak ada fitur untuk peran {peran}.");
            return;
        }

        Console.WriteLine($"\nFitur untuk {peran}:");
        foreach (var fitur in daftarFitur)
        {
            Console.WriteLine($"- {fitur}");
        }
    }
}
