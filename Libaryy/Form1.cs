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
    public partial class Form1 : Form
    {
        // String koneksi ke database Anda
        string connectionString = "server=localhost;database=library;uid=root;pwd=;";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            // Validasi Input Kosong
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username dan Password harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT role FROM users WHERE username=@username AND password=@password";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        string role = result.ToString();

                        if (role == "admin")
                        {
                            MessageBox.Show("Login berhasil sebagai Admin!");
                            FormAdmin adminForm = new FormAdmin();

                            // --- PERUBAHAN DI SINI ---
                            // Saat form admin ditutup, panggil 'this.Show()'
                            // untuk menampilkan kembali form login.
                            adminForm.FormClosed += (s, args) => this.Show();

                            adminForm.Show();
                            this.Hide();
                        }
                        else if (role == "user")
                        {
                            MessageBox.Show("Login berhasil sebagai User!");
                            Form2 userForm = new Form2();

                            // --- PERUBAHAN DI SINI ---
                            // Saat Form2 (alur user) ditutup,
                            // panggil 'this.Show()' untuk menampilkan login lagi.
                            userForm.FormClosed += (s, args) => this.Show();

                            userForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Role tidak dikenal: " + role, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username atau password salah!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}