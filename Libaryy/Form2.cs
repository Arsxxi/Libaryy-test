using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // Pastikan ini ada

namespace Libaryy
{
    public partial class Form2 : Form
    {
        string connectionString = "server=localhost;database=libary;uid=root;pwd=;";

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nama = text_nama.Text;
            string nim = text_nim.Text;
            string jurusan = comboBox_jurusan.Text;

            // --- PERBAIKAN 1: Validasi Input ---
            if (string.IsNullOrEmpty(nama) || string.IsNullOrEmpty(nim) || string.IsNullOrEmpty(jurusan))
            {
                MessageBox.Show("Semua data (Nama, NIM, Jurusan) harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                // --- PERBAIKAN 2: Tambahkan try-catch ---
                try
                {
                    conn.Open();

                    // --- PERBAIKAN 3: Tambahkan id_anggota ke Kueri ---
                    string query = "INSERT INTO anggota (id_anggota, nama_lengkap, jurusan, nim) " +
                                   "VALUES (@id_anggota, @nama_lengkap, @jurusan, @nim)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    // Kita asumsikan id_anggota = nim
                    cmd.Parameters.AddWithValue("@id_anggota", nim);
                    cmd.Parameters.AddWithValue("@nama_lengkap", nama);
                    cmd.Parameters.AddWithValue("@jurusan", jurusan);
                    cmd.Parameters.AddWithValue("@nim", nim);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data berhasil disimpan!");

                    // --- PERUBAHAN UNTUK KEMBALI KE LOGIN ---
                    Form3 formPilihBuku = new Form3(nim);

                    // Tambahkan baris ini:
                    // Saat Form3 ditutup (setelah pinjam), Form2 akan ikut menutup.
                    formPilihBuku.FormClosed += (s, args) => this.Close();

                    formPilihBuku.Show();
                    this.Hide();
                    // --- SELESAI PERUBAHAN ---
                }
                catch (MySqlException ex)
                {
                    // Menangkap error jika NIM/ID Anggota sudah terdaftar
                    if (ex.Number == 1062) // Error code for 'Duplicate entry'
                    {
                        MessageBox.Show("Error: NIM atau ID Anggota '" + nim + "' sudah terdaftar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Error Database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } // 'conn' otomatis ditutup di sini
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // --- CATATAN ---
        // Fungsi kosong seperti Form2_Load, groupBox1_Enter, dll.
        // boleh dihapus jika tidak terpakai.
    }
}