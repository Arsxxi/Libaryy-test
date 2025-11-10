using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Libaryy
{
    public partial class FormAdmin : Form
    {
        string connectionString = "Server=localhost;Database=library;Uid=root;Pwd=;";
        string selectedBookId = "";
        string selectedAnggotaId = "";
        string selectedBorrowId = "";
        string bookIdToReturn = "";

        public FormAdmin()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            // Panggil fungsi untuk memuat data buku
            LoadDataBuku();
            LoadDataAnggota();
            LoadDataLaporan();

            // Isi pilihan untuk ComboBox Status
            cmbStatus.Items.Add("Tersedia");
            cmbStatus.Items.Add("Tidak Tersedia");
            cmbStatus.SelectedIndex = 0; // Set default ke "Tersedia"
        }

        // Buat fungsi baru untuk memuat data buku
        private void LoadDataBuku()
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();
                string query = "SELECT id_buku, judul_buku, kategori, stok, status FROM buku";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvBuku.DataSource = dt; // Tampilkan data ke DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data buku: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void dgvBuku_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTambahBuku_Click(object sender, EventArgs e)
        {
            // Pastikan ID Buku diisi (karena tidak auto-increment di desain Anda)
            if (string.IsNullOrEmpty(txtIdBuku.Text))
            {
                MessageBox.Show("ID Buku tidak boleh kosong!");
                return;
            }

            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();
                string query = "INSERT INTO buku (id_buku, judul_buku, kategori, stok, status) " +
                               "VALUES (@id, @judul, @kategori, @stok, @status)";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", txtIdBuku.Text);
                cmd.Parameters.AddWithValue("@judul", txtJudulBuku.Text);
                cmd.Parameters.AddWithValue("@kategori", txtKategori.Text);
                cmd.Parameters.AddWithValue("@stok", numStok.Value);
                cmd.Parameters.AddWithValue("@status", cmbStatus.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Buku berhasil ditambahkan!");

                LoadDataBuku(); // Refresh tabel
                ClearFormBuku(); // Bersihkan form
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menambah buku: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnUpdateBuku_Click(object sender, EventArgs e)
        {
            // Pastikan ada buku yang dipilih (selectedBookId tidak kosong)
            if (string.IsNullOrEmpty(selectedBookId))
            {
                MessageBox.Show("Silakan pilih buku dari tabel untuk di-update.");
                return;
            }

            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();
                string query = "UPDATE buku SET judul_buku = @judul, kategori = @kategori, " +
                               "stok = @stok, status = @status WHERE id_buku = @id";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@judul", txtJudulBuku.Text);
                cmd.Parameters.AddWithValue("@kategori", txtKategori.Text);
                cmd.Parameters.AddWithValue("@stok", numStok.Value);
                cmd.Parameters.AddWithValue("@status", cmbStatus.Text);
                cmd.Parameters.AddWithValue("@id", selectedBookId); // Kunci WHERE

                cmd.ExecuteNonQuery();
                MessageBox.Show("Buku berhasil di-update!");

                LoadDataBuku();
                ClearFormBuku();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal meng-update buku: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnHapusBuku_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedBookId))
            {
                MessageBox.Show("Silakan pilih buku dari tabel untuk dihapus.");
                return;
            }

            // Konfirmasi sebelum hapus
            if (MessageBox.Show("Anda yakin ingin menghapus buku '" + txtJudulBuku.Text + "'?",
                "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MySqlConnection conn = new MySqlConnection(connectionString);
                try
                {
                    conn.Open();
                    string query = "DELETE FROM buku WHERE id_buku = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", selectedBookId);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Buku berhasil dihapus!");

                    LoadDataBuku();
                    ClearFormBuku();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menghapus buku: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void ClearFormBuku()
        {
            txtIdBuku.Clear();
            txtJudulBuku.Clear();
            txtKategori.Clear();
            numStok.Value = 0;
            cmbStatus.SelectedIndex = 0; // Kembalikan ke "Tersedia"

            selectedBookId = ""; // Hapus ID yang tersimpan
            txtIdBuku.Enabled = true; // Aktifkan kembali textbox ID
        }
        private void btnResetBuku_Click(object sender, EventArgs e)
        {
            ClearFormBuku();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void LoadDataAnggota()
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();
                string query = "SELECT id_anggota, nama_lengkap, jurusan, nim FROM anggota";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvAnggota.DataSource = dt; // Tampilkan ke DataGridView di Tab 2
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data anggota: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void dgvAnggota_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvAnggota.Rows[e.RowIndex];

                // Simpan ID anggota yang dipilih
                selectedAnggotaId = row.Cells["id_anggota"].Value.ToString();

                // Masukkan data ke komponen form di Tab 2
                txtIdAnggota.Text = row.Cells["id_anggota"].Value.ToString();
                txtNamaLengkap.Text = row.Cells["nama_lengkap"].Value.ToString();
                txtJurusan.Text = row.Cells["jurusan"].Value.ToString();
                txtNim.Text = row.Cells["nim"].Value.ToString();

                // ID Anggota tidak boleh diubah saat mode update
                txtIdAnggota.Enabled = false;
            }
        }

        private void dgvBuku_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                // Pastikan yang diklik adalah baris yang valid
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dgvBuku.Rows[e.RowIndex];

                    // Simpan ID buku yang dipilih secara global
                    selectedBookId = row.Cells["id_buku"].Value.ToString();

                    // Masukkan data dari baris ke komponen form
                    txtIdBuku.Text = row.Cells["id_buku"].Value.ToString();
                    txtJudulBuku.Text = row.Cells["judul_buku"].Value.ToString();
                    txtKategori.Text = row.Cells["kategori"].Value.ToString();
                    numStok.Value = Convert.ToInt32(row.Cells["stok"].Value);
                    cmbStatus.Text = row.Cells["status"].Value.ToString();

                    // Saat data dipilih, ID Buku tidak boleh diubah
                    txtIdBuku.Enabled = false;
                }
            }
        }

        private void ClearFormAnggota()
        {
            txtIdAnggota.Clear();
            txtNamaLengkap.Clear();
            txtJurusan.Clear();
            txtNim.Clear();

            selectedAnggotaId = ""; // Hapus ID yang tersimpan
            txtIdAnggota.Enabled = true; // Aktifkan kembali textbox ID
        }

        private void btnResetAnggota_Click(object sender, EventArgs e)
        {
            ClearFormAnggota();
        }

        private void btnTambahAnggota_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdAnggota.Text) || string.IsNullOrEmpty(txtNamaLengkap.Text))
            {
                MessageBox.Show("ID Anggota dan Nama tidak boleh kosong!");
                return;
            }

            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();
                string query = "INSERT INTO anggota (id_anggota, nama_lengkap, jurusan, nim) " +
                               "VALUES (@id, @nama, @jurusan, @nim)";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", txtIdAnggota.Text);
                cmd.Parameters.AddWithValue("@nama", txtNamaLengkap.Text);
                cmd.Parameters.AddWithValue("@jurusan", txtJurusan.Text);
                cmd.Parameters.AddWithValue("@nim", txtNim.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Anggota berhasil ditambahkan!");

                LoadDataAnggota(); // Refresh tabel
                ClearFormAnggota(); // Bersihkan form
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menambah anggota: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnUpdateAnggota_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedAnggotaId))
            {
                MessageBox.Show("Silakan pilih anggota dari tabel untuk di-update.");
                return;
            }

            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();
                string query = "UPDATE anggota SET nama_lengkap = @nama, jurusan = @jurusan, nim = @nim " +
                               "WHERE id_anggota = @id";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nama", txtNamaLengkap.Text);
                cmd.Parameters.AddWithValue("@jurusan", txtJurusan.Text);
                cmd.Parameters.AddWithValue("@nim", txtNim.Text);
                cmd.Parameters.AddWithValue("@id", selectedAnggotaId); // Kunci WHERE

                cmd.ExecuteNonQuery();
                MessageBox.Show("Anggota berhasil di-update!");

                LoadDataAnggota();
                ClearFormAnggota();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal meng-update anggota: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnHapusAnggota_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedAnggotaId))
            {
                MessageBox.Show("Silakan pilih anggota dari tabel untuk dihapus.");
                return;
            }

            if (MessageBox.Show("Anda yakin ingin menghapus anggota '" + txtNamaLengkap.Text + "'?",
                "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MySqlConnection conn = new MySqlConnection(connectionString);
                try
                {
                    conn.Open();
                    string query = "DELETE FROM anggota WHERE id_anggota = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", selectedAnggotaId);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Anggota berhasil dihapus!");

                    LoadDataAnggota();
                    ClearFormAnggota();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menghapus anggota: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void LoadDataLaporan()
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();
                // Kueri ini menggabungkan 3 tabel dan membuat kolom 'Status'
                string query = @"
            SELECT 
                p.id_peminjaman, 
                a.nama_lengkap AS 'Peminjam', 
                b.judul_buku AS 'Judul Buku', 
                p.tanggal_pinjam, 
                p.tanggal_kembali,
                p.id_buku, 
                
                CASE 
                    WHEN p.tanggal_kembali IS NULL THEN 'Dipinjam' 
                    ELSE 'Selesai' 
                END AS 'Status'
                
            FROM peminjaman p
            JOIN anggota a ON p.id_anggota = a.id_anggota 
            JOIN buku b ON p.id_buku = b.id_buku
            ORDER BY Status, p.tanggal_pinjam DESC";

                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvLaporan.DataSource = dt;

                // Sembunyikan kolom id_buku yang tidak perlu dilihat user
                if (dgvLaporan.Columns["id_buku"] != null)
                    dgvLaporan.Columns["id_buku"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat laporan: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void dgvLaporan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvLaporan.Rows[e.RowIndex];

                // Simpan ID penting
                selectedBorrowId = row.Cells["id_peminjaman"].Value.ToString();
                bookIdToReturn = row.Cells["id_buku"].Value.ToString();

                // Ambil status dari kolom 'Status' virtual kita
                string status = row.Cells["Status"].Value.ToString();

                // Logika untuk mengaktifkan tombol
                if (status == "Dipinjam")
                {
                    btnKonfirmasiKembali.Enabled = true;
                }
                else // Jika status "Selesai"
                {
                    btnKonfirmasiKembali.Enabled = false;
                }
            }
        }

        private void btnKonfirmasiKembali_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedBorrowId))
            {
                MessageBox.Show("Pilih data peminjaman yang valid.");
                return;
            }

            // Tampilkan konfirmasi
            if (MessageBox.Show("Konfirmasi pengembalian buku ini?", "Konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            MySqlConnection conn = new MySqlConnection(connectionString);
            MySqlTransaction transaction = null; // Objek Transaksi

            try
            {
                conn.Open();
                transaction = conn.BeginTransaction(); // Mulai Transaksi

                MySqlCommand cmd = conn.CreateCommand();
                cmd.Transaction = transaction;

                // ------ Kueri 1: Update tabel peminjaman ------
                // Mengisi tanggal_kembali menjadi hari ini (NOW())
                cmd.CommandText = "UPDATE peminjaman SET tanggal_kembali = NOW() " +
                                  "WHERE id_peminjaman = @borrowId AND tanggal_kembali IS NULL";
                cmd.Parameters.AddWithValue("@borrowId", selectedBorrowId);

                int rowsAffected = cmd.ExecuteNonQuery();

                // Cek apakah ada baris yang ter-update
                if (rowsAffected > 0)
                {
                    // ------ Kueri 2: Update stok di tabel buku ------
                    cmd.CommandText = "UPDATE buku SET stok = stok + 1 WHERE id_buku = @bookId";
                    cmd.Parameters.AddWithValue("@bookId", bookIdToReturn);
                    cmd.ExecuteNonQuery();

                    // Jika kedua kueri sukses, simpan perubahan
                    transaction.Commit();
                    MessageBox.Show("Buku berhasil dikembalikan!");
                }
                else
                {
                    // Jika tidak ada baris ter-update (misal sudah dikembalikan)
                    transaction.Rollback();
                    MessageBox.Show("Buku ini sudah dikembalikan sebelumnya.");
                }

                // Refresh semua data yang relevan
                LoadDataLaporan();    // Refresh Tab 3
                LoadDataBuku();       // Refresh stok di Tab 1
                btnKonfirmasiKembali.Enabled = false; // Nonaktifkan tombol lagi
            }
            catch (Exception ex)
            {
                // Jika salah satu kueri gagal, batalkan SEMUA perubahan
                try
                {
                    transaction?.Rollback(); // ?. (Null-conditional)
                }
                catch (Exception rbEx)
                {
                    MessageBox.Show("Gagal melakukan rollback: " + rbEx.Message);
                }

                MessageBox.Show("Gagal melakukan konfirmasi: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
