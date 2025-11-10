using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libaryy
{
    public partial class Form3 : Form
    {
        string connectionString = "server=localhost;database=libary;uid=root;pwd=;";
        string idAnggota; // Kita ganti nama 'nim' menjadi 'idAnggota' agar lebih jelas

        // --- PERBAIKAN 1: Constructor ---
        public Form3(string nimAtauIdAnggota)
        {
            InitializeComponent();
            // 'this.idAnggota' adalah variabel class, 'nimAtauIdAnggota' adalah parameter
            this.idAnggota = nimAtauIdAnggota;
            LoadBuku();
        }

        // --- PERBAIKAN 2: LoadBuku (Menggunakan DataSource) ---
        private void LoadBuku()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    // Ambil ID dan Judul, hanya buku yang 'Tersedia' DAN stoknya ada
                    string query = "SELECT id_buku, judul_buku FROM buku WHERE status = 'Tersedia' AND stok > 0";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    da.Fill(dt);

                    // Gunakan DataTable sebagai sumber data
                    checkedListBox1.DataSource = dt;
                    checkedListBox1.DisplayMember = "judul_buku"; // Tampilkan judul
                    checkedListBox1.ValueMember = "id_buku";      // Simpan id_buku
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal memuat daftar buku: " + ex.Message);
                }
            }
        }

        // --- PERBAIKAN 3 & 4: button1_Click (Transaksi Peminjaman & Update Stok) ---
        private void button1_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count == 0)
            {
                MessageBox.Show("Pilih minimal satu buku yang ingin dipinjam!");
                return;
            }

            // Kita harus menggunakan Transaksi
            // Ini memastikan KEDUA kueri (INSERT peminjaman & UPDATE stok) berhasil
            // atau KEDUA-DUANYA gagal.

            MySqlConnection conn = new MySqlConnection(connectionString);
            MySqlTransaction transaction = null;

            try
            {
                conn.Open();
                transaction = conn.BeginTransaction(); // Mulai Transaksi

                // Loop untuk setiap buku yang dicentang
                foreach (object itemChecked in checkedListBox1.CheckedItems)
                {
                    DataRowView rowView = itemChecked as DataRowView;
                    string idBuku = rowView[checkedListBox1.ValueMember].ToString();

                    // Buat ID Peminjaman unik (Contoh: P11054932)
                    string idPeminjaman = "P" + DateTime.Now.ToString("HHmmss") + new Random().Next(10, 99);

                    // --- Kueri 1: INSERT ke tabel peminjaman ---
                    string queryPinjam = "INSERT INTO peminjaman (id_peminjaman, id_buku, id_anggota, tanggal_pinjam, tanggal_kembali) " +
                                         "VALUES (@id_peminjaman, @id_buku, @id_anggota, NOW(), NULL)";

                    MySqlCommand cmdPinjam = new MySqlCommand(queryPinjam, conn, transaction);
                    cmdPinjam.Parameters.AddWithValue("@id_peminjaman", idPeminjaman);
                    cmdPinjam.Parameters.AddWithValue("@id_buku", idBuku);
                    cmdPinjam.Parameters.AddWithValue("@id_anggota", this.idAnggota); // idAnggota dari constructor
                    cmdPinjam.ExecuteNonQuery();

                    // --- Kueri 2: UPDATE stok buku ---
                    // Mengurangi stok & mengubah status jika stok = 0
                    string queryUpdateStok = @"
                        UPDATE buku 
                        SET 
                            stok = stok - 1, 
                            status = CASE 
                                WHEN (stok - 1) = 0 THEN 'Tidak Tersedia' 
                                ELSE 'Tersedia' 
                            END
                        WHERE id_buku = @id_buku AND stok > 0";

                    MySqlCommand cmdUpdate = new MySqlCommand(queryUpdateStok, conn, transaction);
                    cmdUpdate.Parameters.AddWithValue("@id_buku", idBuku);
                    cmdUpdate.ExecuteNonQuery();
                }

                // Jika semua kueri di loop berhasil, simpan perubahan
                transaction.Commit();
                MessageBox.Show("Buku berhasil dipinjam!");

                // Refresh daftar buku dan tutup form
                LoadBuku();
                this.Close(); // Menutup Form3, kembali ke form sebelumnya (jika ada)
            }
            catch (Exception ex)
            {
                // Jika ada SATU saja error, batalkan SEMUA perubahan
                try
                {
                    transaction?.Rollback(); // Batalkan transaksi
                }
                catch (Exception rbEx)
                {
                    MessageBox.Show("Gagal melakukan Rollback: " + rbEx.Message);
                }

                MessageBox.Show("Gagal meminjam buku: " + ex.Message, "Error Transaksi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        // Fungsi-fungsi kosong (bisa dihapus jika tidak dipakai)
        private void Form3_Load(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}   