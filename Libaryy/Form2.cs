using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Libaryy
{
    public partial class Form2 : Form
    {

        string connectionString = "server=localhost;database=libary_db;uid=root;pwd=;";
        public Form2()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_nim_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_jurusan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nama = text_nama.Text;
            string nim = text_nim.Text;
            string jurusan = comboBox_jurusan.Text;
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO peminjam (nama, nim, jurusan) VALUES (@nama, @nim, @jurusan)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nama", nama);
                cmd.Parameters.AddWithValue("@nim", nim);
                cmd.Parameters.AddWithValue("@jurusan", jurusan);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Data berhasil disimpan!");
            }
        }
    }
}
