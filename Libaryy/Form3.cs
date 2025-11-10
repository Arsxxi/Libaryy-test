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
        string nim; // nim dari form sebelumnya
        public Form3(string nim)
        {
            InitializeComponent();
            nim= nim;
            LoadBuku();
        }
        private void LoadBuku()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT judul_buku FROM buku WHERE status = 'tersedia'";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                checkedListBox1.Items.Clear();
                while (reader.Read())
                {
                    checkedListBox1.Items.Add(reader["judul_buku"].ToString());
                }
            }
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkedListBox1.BorderStyle = BorderStyle.None;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count == 0)
            {
                MessageBox.Show("Pilih minimal satu buku yang ingin dipinjam!");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                foreach (var item in checkedListBox1.CheckedItems)
                {
                    string query = "INSERT INTO peminjaman (nim, judul_buku, tanggal_pinjam) VALUES (@nim, @judul_buku, NOW())";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nim", nim);
                    cmd.Parameters.AddWithValue("@judul_buku", item.ToString());
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Buku berhasil dipinjam!");
            }
        }
    }
}
