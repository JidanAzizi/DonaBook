using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;
using DonaBook_Gui.Models;

namespace DonaBook_Gui.Forms
{
    public partial class FormPenerima : Form
    {
        private List<Donasi> daftarDonasi;
        private List<Permintaan> daftarPermintaan = new List<Permintaan>();
        private List<Ulasan> daftarUlasan = new List<Ulasan>();

        private string pathDonasi = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "buku_donasi.json");

        public FormPenerima()
        {
            InitializeComponent();
            LoadDonasi();
            RefreshGrid(daftarDonasi);
        }

        private void LoadDonasi()
        {
            try
            {
                if (!File.Exists(pathDonasi))
                {
                    daftarDonasi = new List<Donasi>();
                    return;
                }

                string json = File.ReadAllText(pathDonasi);
                daftarDonasi = JsonSerializer.Deserialize<List<Donasi>>(json) ?? new List<Donasi>();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data buku donasi: " + ex.Message);
                daftarDonasi = new List<Donasi>();
            }
        }

        private void RefreshGrid(List<Donasi> source)
        {
            dgvDonasi.DataSource = null;
            dgvDonasi.DataSource = source;
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            string keyword = txtCariJudul.Text.Trim().ToLower();
            var hasil = daftarDonasi.Where(d => d.Judul.ToLower().Contains(keyword)).ToList();

            if (hasil.Count == 0)
                MessageBox.Show("Buku tidak ditemukan.");

            RefreshGrid(hasil);
        }

        private void btnAjukanPermintaan_Click(object sender, EventArgs e)
        {
            if (dgvDonasi.CurrentRow == null)
            {
                MessageBox.Show("Pilih buku yang ingin diminta.");
                return;
            }

            string nama = txtNamaPenerima.Text.Trim();
            if (string.IsNullOrWhiteSpace(nama))
            {
                MessageBox.Show("Masukkan nama penerima.");
                return;
            }

            var buku = (Donasi)dgvDonasi.CurrentRow.DataBoundItem;

            var permintaanBaru = new Permintaan
            {
                JudulBuku = buku.Judul,
                NamaPenerima = nama,
                TanggalPermintaan = DateTime.Now
            };

            daftarPermintaan.Add(permintaanBaru);

            MessageBox.Show($"Permintaan buku '{buku.Judul}' berhasil diajukan oleh {nama}.");
            txtNamaPenerima.Text = "";
        }

        private void btnBeriUlasan_Click(object sender, EventArgs e)
        {
            if (dgvDonasi.CurrentRow == null)
            {
                MessageBox.Show("Pilih buku yang ingin diulas.");
                return;
            }

            string nama = txtNamaPenerima.Text.Trim();
            string isiUlasan = txtUlasan.Text.Trim();

            if (string.IsNullOrWhiteSpace(nama) || string.IsNullOrWhiteSpace(isiUlasan))
            {
                MessageBox.Show("Nama penerima dan isi ulasan harus diisi.");
                return;
            }

            var buku = (Donasi)dgvDonasi.CurrentRow.DataBoundItem;

            var ulasanBaru = new Ulasan
            {
                JudulBuku = buku.Judul,
                NamaPenerima = nama,
                IsiUlasan = isiUlasan,
                TanggalUlasan = DateTime.Now
            };

            daftarUlasan.Add(ulasanBaru);

            MessageBox.Show("Ulasan berhasil ditambahkan.");
            txtUlasan.Text = "";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            RefreshGrid(daftarDonasi);
            txtCariJudul.Text = "";
        }
    }
}
