using System;
using System.Collections.Generic;

public class LayananDonasiBuku
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
            // Meminta bahasa terlebih dahulu
            string bahasa = PilihBahasa();

            // Mengatur konfigurasi berdasarkan bahasa yang dipilih
            konfigurasiDonasi.konfigurasi.bahasa = bahasa;

            Console.WriteLine(bahasa == "en" ? "Select your role: donor, recipient, volunteer" : "Pilih peran Anda: donatur, penerima, relawan");
            string peran = MintaPeranDariUser(bahasa);

            // Menampilkan fitur berdasarkan peran yang dipilih
            switch (peran)
            {
                case "donatur":
                    TampilkanFitur("Donatur", konfigurasiDonasi.konfigurasi.fitur_donatur);
                    break;
                case "penerima":
                    TampilkanFitur("Penerima", konfigurasiDonasi.konfigurasi.fitur_penerima);
                    break;
                case "relawan":
                    TampilkanFitur("Relawan", konfigurasiDonasi.konfigurasi.fitur_relawanan);
                    break;
            }

            // Menambahkan fitur baru dari user
            TambahFiturBaru(bahasa);

        }
        catch (Exception ex)
        {
            Console.WriteLine($"[ERROR] {ex.Message}");
        }
    }

    public string PilihBahasa()
    {
        string bahasa = "";
        bool valid = false;

        while (!valid)
        {
            Console.WriteLine("Pilih bahasa (id/en): ");
            bahasa = Console.ReadLine().ToLower().Trim();

            valid = bahasa == "id" || bahasa == "en";

            if (!valid)
                Console.WriteLine("Bahasa tidak valid. Harap pilih 'id' atau 'en'.");
        }

        return bahasa;
    }

    public string MintaPeranDariUser(string bahasa)
    {
        string peran = "";
        bool valid = false;

        while (!valid)
        {
            if (bahasa == "en")
                Console.Write("Select your role [donor/recipient/volunteer]: ");
            else
                Console.Write("Pilih peran Anda [donatur/penerima/relawan]: ");

            peran = Console.ReadLine().ToLower().Trim();

            // Validasi input dengan memperbolehkan input yang tidak terlalu ketat
            valid = peran == "donor" || peran == "recipient" || peran == "volunteer" ||
                    peran == "donatur" || peran == "penerima" || peran == "relawan";

            if (!valid)
            {
                if (bahasa == "en")
                    Console.WriteLine("Invalid input. Please enter donor, recipient, or volunteer.\n");
                else
                    Console.WriteLine("Input tidak valid. Harap masukkan donatur, penerima, atau relawan.\n");
            }
        }

        return peran;
    }
    public void TampilkanFitur<T>(string peran, List<T> daftarFitur)
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

    public void TambahFiturBaru(string bahasa)
    {
        Console.WriteLine(bahasa == "en" ? "\nWould you like to add a new feature? [yes/no]" : "\nApakah Anda ingin menambahkan fitur baru? [ya/tidak]");
        string tambahFitur = Console.ReadLine().ToLower().Trim();

        if (tambahFitur == "yes" || tambahFitur == "ya")
        {
            Console.WriteLine(bahasa == "en" ? "\nEnter the name of the new feature:" : "\nMasukkan nama fitur baru:");
            string namaFitur = Console.ReadLine().Trim();

            // Menambahkan fitur baru ke konfigurasi (akan diproses sesuai peran)
            if (konfigurasiDonasi.konfigurasi.fitur_donatur.Contains(namaFitur) || konfigurasiDonasi.konfigurasi.fitur_penerima.Contains(namaFitur) || konfigurasiDonasi.konfigurasi.fitur_relawanan.Contains(namaFitur))
            {
                Console.WriteLine(bahasa == "en" ? "\nThis feature already exists." : "\nFitur ini sudah ada.");
            }
            else
            {
                Console.WriteLine(bahasa == "en" ? "\nFeature added successfully." : "\nFitur berhasil ditambahkan.");
                // Menambahkan fitur ke list sesuai dengan peran user
                if (namaFitur.Contains("donatur"))
                    konfigurasiDonasi.konfigurasi.fitur_donatur.Add(namaFitur);
                else if (namaFitur.Contains("penerima"))
                    konfigurasiDonasi.konfigurasi.fitur_penerima.Add(namaFitur);
                else
                    konfigurasiDonasi.konfigurasi.fitur_relawanan.Add(namaFitur);
            }
        }
    }
    public string ValidasiBahasa(string input)
    {
        var trimmed = input.ToLower().Trim();
        if (trimmed == "id" || trimmed == "en")
            return trimmed;
        throw new ArgumentException("Bahasa tidak valid");
    }

    public bool ValidasiPeran(string bahasa, string inputPeran)
    {
        var peran = inputPeran.ToLower().Trim();
        if (bahasa == "en")
            return peran == "donor" || peran == "recipient" || peran == "volunteer";
        else if (bahasa == "id")
            return peran == "donatur" || peran == "penerima" || peran == "relawan";
        return false;
    }
}
