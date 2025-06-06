using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using DonaBook_Gui.Models;

namespace DonaBook_Gui.Forms
{
    public partial class FormDonatur : Form
    {
        private List<Donasi> daftarDonasi;
        private string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "buku_donasi.json");

        public FormDonatur()
        {
            InitializeComponent();
            LoadDonasi();
            RefreshGrid();
        }

        private void LoadDonasi()
        {
            try
            {
                if (!File.Exists(path))
                {
                    daftarDonasi = new List<Donasi>();
                    return;
                }

                string json = File.ReadAllText(path);
                daftarDonasi = JsonSerializer.Deserialize<List<Donasi>>(json) ?? new List<Donasi>();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data buku donasi: " + ex.Message);
                daftarDonasi = new List<Donasi>();
            }
        }

        private void SaveDonasi()
        {
            try
            {
                string json = JsonSerializer.Serialize(daftarDonasi, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(path, json);
                MessageBox.Show("Data buku donasi berhasil disimpan.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan data: " + ex.Message);
            }
        }

        private void RefreshGrid()
        {
            dgvDonasi.DataSource = null;
            dgvDonasi.DataSource = daftarDonasi;
        }

        private void btnAjukan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtJudul.Text) ||
                string.IsNullOrWhiteSpace(txtPenulis.Text) ||
                string.IsNullOrWhiteSpace(txtPenerbit.Text) ||
                string.IsNullOrWhiteSpace(txtTahun.Text))
            {
                MessageBox.Show("Semua kolom harus diisi.");
                return;
            }

            if (!int.TryParse(txtTahun.Text, out int tahun))
            {
                MessageBox.Show("Tahun terbit harus berupa angka.");
                return;
            }

            var donasi = new Donasi
            {
                Judul = txtJudul.Text.Trim(),
                Penulis = txtPenulis.Text.Trim(),
                Penerbit = txtPenerbit.Text.Trim(),
                TahunTerbit = tahun
            };

            daftarDonasi.Add(donasi);
            RefreshGrid();
            ClearInputs();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dgvDonasi.CurrentRow == null)
            {
                MessageBox.Show("Pilih buku donasi yang ingin dihapus.");
                return;
            }

            int index = dgvDonasi.CurrentRow.Index;
            if (index >= 0 && index < daftarDonasi.Count)
            {
                daftarDonasi.RemoveAt(index);
                RefreshGrid();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SaveDonasi();
        }

        private void ClearInputs()
        {
            txtJudul.Text = "";
            txtPenulis.Text = "";
            txtPenerbit.Text = "";
            txtTahun.Text = "";
        }
    }
}
