namespace Libaryy
{
    partial class FormAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabBuku = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnResetBuku = new System.Windows.Forms.Button();
            this.btnHapusBuku = new System.Windows.Forms.Button();
            this.btnUpdateBuku = new System.Windows.Forms.Button();
            this.btnTambahBuku = new System.Windows.Forms.Button();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numStok = new System.Windows.Forms.NumericUpDown();
            this.txtKategori = new System.Windows.Forms.TextBox();
            this.txtJudulBuku = new System.Windows.Forms.TextBox();
            this.txtIdBuku = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvBuku = new System.Windows.Forms.DataGridView();
            this.tabPengguna = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnResetAnggota = new System.Windows.Forms.Button();
            this.btnHapusAnggota = new System.Windows.Forms.Button();
            this.btnUpdateAnggota = new System.Windows.Forms.Button();
            this.btnTambahAnggota = new System.Windows.Forms.Button();
            this.txtNim = new System.Windows.Forms.TextBox();
            this.txtJurusan = new System.Windows.Forms.TextBox();
            this.txtNamaLengkap = new System.Windows.Forms.TextBox();
            this.txtIdAnggota = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvAnggota = new System.Windows.Forms.DataGridView();
            this.tabLaporan = new System.Windows.Forms.TabPage();
            this.dgvLaporan = new System.Windows.Forms.DataGridView();
            this.btnKonfirmasiKembali = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabBuku.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuku)).BeginInit();
            this.tabPengguna.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnggota)).BeginInit();
            this.tabLaporan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaporan)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabBuku);
            this.tabControl1.Controls.Add(this.tabPengguna);
            this.tabControl1.Controls.Add(this.tabLaporan);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(705, 382);
            this.tabControl1.TabIndex = 0;
            // 
            // tabBuku
            // 
            this.tabBuku.Controls.Add(this.groupBox1);
            this.tabBuku.Controls.Add(this.dgvBuku);
            this.tabBuku.Location = new System.Drawing.Point(4, 22);
            this.tabBuku.Name = "tabBuku";
            this.tabBuku.Padding = new System.Windows.Forms.Padding(3);
            this.tabBuku.Size = new System.Drawing.Size(697, 356);
            this.tabBuku.TabIndex = 0;
            this.tabBuku.Text = "Manajemen Buku";
            this.tabBuku.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnResetBuku);
            this.groupBox1.Controls.Add(this.btnHapusBuku);
            this.groupBox1.Controls.Add(this.btnUpdateBuku);
            this.groupBox1.Controls.Add(this.btnTambahBuku);
            this.groupBox1.Controls.Add(this.cmbStatus);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numStok);
            this.groupBox1.Controls.Add(this.txtKategori);
            this.groupBox1.Controls.Add(this.txtJudulBuku);
            this.groupBox1.Controls.Add(this.txtIdBuku);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 159);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(681, 191);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detail Buku";
            // 
            // btnResetBuku
            // 
            this.btnResetBuku.Location = new System.Drawing.Point(432, 113);
            this.btnResetBuku.Name = "btnResetBuku";
            this.btnResetBuku.Size = new System.Drawing.Size(75, 23);
            this.btnResetBuku.TabIndex = 13;
            this.btnResetBuku.Text = "Reset";
            this.btnResetBuku.UseVisualStyleBackColor = true;
            this.btnResetBuku.Click += new System.EventHandler(this.btnResetBuku_Click);
            // 
            // btnHapusBuku
            // 
            this.btnHapusBuku.Location = new System.Drawing.Point(432, 84);
            this.btnHapusBuku.Name = "btnHapusBuku";
            this.btnHapusBuku.Size = new System.Drawing.Size(75, 23);
            this.btnHapusBuku.TabIndex = 12;
            this.btnHapusBuku.Text = "Hapus";
            this.btnHapusBuku.UseVisualStyleBackColor = true;
            this.btnHapusBuku.Click += new System.EventHandler(this.btnHapusBuku_Click);
            // 
            // btnUpdateBuku
            // 
            this.btnUpdateBuku.Location = new System.Drawing.Point(432, 55);
            this.btnUpdateBuku.Name = "btnUpdateBuku";
            this.btnUpdateBuku.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateBuku.TabIndex = 11;
            this.btnUpdateBuku.Text = "Update";
            this.btnUpdateBuku.UseVisualStyleBackColor = true;
            this.btnUpdateBuku.Click += new System.EventHandler(this.btnUpdateBuku_Click);
            // 
            // btnTambahBuku
            // 
            this.btnTambahBuku.Location = new System.Drawing.Point(432, 26);
            this.btnTambahBuku.Name = "btnTambahBuku";
            this.btnTambahBuku.Size = new System.Drawing.Size(75, 23);
            this.btnTambahBuku.TabIndex = 10;
            this.btnTambahBuku.Text = "Tambah";
            this.btnTambahBuku.UseVisualStyleBackColor = true;
            this.btnTambahBuku.Click += new System.EventHandler(this.btnTambahBuku_Click);
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Tersedia",
            "Tidak Tersedia"});
            this.cmbStatus.Location = new System.Drawing.Point(91, 138);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(121, 21);
            this.cmbStatus.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Status";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // numStok
            // 
            this.numStok.Location = new System.Drawing.Point(91, 103);
            this.numStok.Name = "numStok";
            this.numStok.Size = new System.Drawing.Size(120, 20);
            this.numStok.TabIndex = 7;
            // 
            // txtKategori
            // 
            this.txtKategori.Location = new System.Drawing.Point(91, 77);
            this.txtKategori.Name = "txtKategori";
            this.txtKategori.Size = new System.Drawing.Size(100, 20);
            this.txtKategori.TabIndex = 6;
            // 
            // txtJudulBuku
            // 
            this.txtJudulBuku.Location = new System.Drawing.Point(91, 49);
            this.txtJudulBuku.Name = "txtJudulBuku";
            this.txtJudulBuku.Size = new System.Drawing.Size(100, 20);
            this.txtJudulBuku.TabIndex = 5;
            // 
            // txtIdBuku
            // 
            this.txtIdBuku.Location = new System.Drawing.Point(91, 23);
            this.txtIdBuku.Name = "txtIdBuku";
            this.txtIdBuku.Size = new System.Drawing.Size(100, 20);
            this.txtIdBuku.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Judul Buku";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kategori";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Stok";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Buku";
            // 
            // dgvBuku
            // 
            this.dgvBuku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuku.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvBuku.Location = new System.Drawing.Point(3, 3);
            this.dgvBuku.Name = "dgvBuku";
            this.dgvBuku.Size = new System.Drawing.Size(691, 150);
            this.dgvBuku.TabIndex = 0;
            this.dgvBuku.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBuku_CellClick);
            // 
            // tabPengguna
            // 
            this.tabPengguna.Controls.Add(this.groupBox2);
            this.tabPengguna.Controls.Add(this.dgvAnggota);
            this.tabPengguna.Location = new System.Drawing.Point(4, 22);
            this.tabPengguna.Name = "tabPengguna";
            this.tabPengguna.Padding = new System.Windows.Forms.Padding(3);
            this.tabPengguna.Size = new System.Drawing.Size(697, 356);
            this.tabPengguna.TabIndex = 1;
            this.tabPengguna.Text = "Manajemen Pengguna";
            this.tabPengguna.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnResetAnggota);
            this.groupBox2.Controls.Add(this.btnHapusAnggota);
            this.groupBox2.Controls.Add(this.btnUpdateAnggota);
            this.groupBox2.Controls.Add(this.btnTambahAnggota);
            this.groupBox2.Controls.Add(this.txtNim);
            this.groupBox2.Controls.Add(this.txtJurusan);
            this.groupBox2.Controls.Add(this.txtNamaLengkap);
            this.groupBox2.Controls.Add(this.txtIdAnggota);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(0, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(697, 194);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detail Anggota";
            // 
            // btnResetAnggota
            // 
            this.btnResetAnggota.Location = new System.Drawing.Point(482, 123);
            this.btnResetAnggota.Name = "btnResetAnggota";
            this.btnResetAnggota.Size = new System.Drawing.Size(75, 23);
            this.btnResetAnggota.TabIndex = 17;
            this.btnResetAnggota.Text = "Reset";
            this.btnResetAnggota.UseVisualStyleBackColor = true;
            this.btnResetAnggota.Click += new System.EventHandler(this.btnResetAnggota_Click);
            // 
            // btnHapusAnggota
            // 
            this.btnHapusAnggota.Location = new System.Drawing.Point(482, 94);
            this.btnHapusAnggota.Name = "btnHapusAnggota";
            this.btnHapusAnggota.Size = new System.Drawing.Size(75, 23);
            this.btnHapusAnggota.TabIndex = 16;
            this.btnHapusAnggota.Text = "Hapus";
            this.btnHapusAnggota.UseVisualStyleBackColor = true;
            this.btnHapusAnggota.Click += new System.EventHandler(this.btnHapusAnggota_Click);
            // 
            // btnUpdateAnggota
            // 
            this.btnUpdateAnggota.Location = new System.Drawing.Point(482, 65);
            this.btnUpdateAnggota.Name = "btnUpdateAnggota";
            this.btnUpdateAnggota.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateAnggota.TabIndex = 15;
            this.btnUpdateAnggota.Text = "Update";
            this.btnUpdateAnggota.UseVisualStyleBackColor = true;
            this.btnUpdateAnggota.Click += new System.EventHandler(this.btnUpdateAnggota_Click);
            // 
            // btnTambahAnggota
            // 
            this.btnTambahAnggota.Location = new System.Drawing.Point(482, 36);
            this.btnTambahAnggota.Name = "btnTambahAnggota";
            this.btnTambahAnggota.Size = new System.Drawing.Size(75, 23);
            this.btnTambahAnggota.TabIndex = 14;
            this.btnTambahAnggota.Text = "Tambah";
            this.btnTambahAnggota.UseVisualStyleBackColor = true;
            this.btnTambahAnggota.Click += new System.EventHandler(this.btnTambahAnggota_Click);
            // 
            // txtNim
            // 
            this.txtNim.Location = new System.Drawing.Point(120, 113);
            this.txtNim.Name = "txtNim";
            this.txtNim.Size = new System.Drawing.Size(100, 20);
            this.txtNim.TabIndex = 7;
            // 
            // txtJurusan
            // 
            this.txtJurusan.Location = new System.Drawing.Point(120, 87);
            this.txtJurusan.Name = "txtJurusan";
            this.txtJurusan.Size = new System.Drawing.Size(100, 20);
            this.txtJurusan.TabIndex = 6;
            // 
            // txtNamaLengkap
            // 
            this.txtNamaLengkap.Location = new System.Drawing.Point(120, 61);
            this.txtNamaLengkap.Name = "txtNamaLengkap";
            this.txtNamaLengkap.Size = new System.Drawing.Size(100, 20);
            this.txtNamaLengkap.TabIndex = 5;
            // 
            // txtIdAnggota
            // 
            this.txtIdAnggota.Location = new System.Drawing.Point(120, 32);
            this.txtIdAnggota.Name = "txtIdAnggota";
            this.txtIdAnggota.Size = new System.Drawing.Size(100, 20);
            this.txtIdAnggota.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Jurusan:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Nama Lengkap:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "NIM:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "ID Anggota:";
            // 
            // dgvAnggota
            // 
            this.dgvAnggota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnggota.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvAnggota.Location = new System.Drawing.Point(3, 203);
            this.dgvAnggota.Name = "dgvAnggota";
            this.dgvAnggota.Size = new System.Drawing.Size(691, 150);
            this.dgvAnggota.TabIndex = 0;
            this.dgvAnggota.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAnggota_CellClick);
            // 
            // tabLaporan
            // 
            this.tabLaporan.Controls.Add(this.btnKonfirmasiKembali);
            this.tabLaporan.Controls.Add(this.dgvLaporan);
            this.tabLaporan.Location = new System.Drawing.Point(4, 22);
            this.tabLaporan.Name = "tabLaporan";
            this.tabLaporan.Padding = new System.Windows.Forms.Padding(3);
            this.tabLaporan.Size = new System.Drawing.Size(697, 356);
            this.tabLaporan.TabIndex = 2;
            this.tabLaporan.Text = "Laporan Peminjaman";
            this.tabLaporan.UseVisualStyleBackColor = true;
            // 
            // dgvLaporan
            // 
            this.dgvLaporan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLaporan.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvLaporan.Location = new System.Drawing.Point(3, 3);
            this.dgvLaporan.Name = "dgvLaporan";
            this.dgvLaporan.Size = new System.Drawing.Size(691, 150);
            this.dgvLaporan.TabIndex = 0;
            this.dgvLaporan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLaporan_CellClick);
            // 
            // btnKonfirmasiKembali
            // 
            this.btnKonfirmasiKembali.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnKonfirmasiKembali.Location = new System.Drawing.Point(3, 330);
            this.btnKonfirmasiKembali.Name = "btnKonfirmasiKembali";
            this.btnKonfirmasiKembali.Size = new System.Drawing.Size(691, 23);
            this.btnKonfirmasiKembali.TabIndex = 1;
            this.btnKonfirmasiKembali.Text = "Konfirmasi Pengembalian";
            this.btnKonfirmasiKembali.UseVisualStyleBackColor = true;
            this.btnKonfirmasiKembali.Click += new System.EventHandler(this.btnKonfirmasiKembali_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(705, 382);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabBuku.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuku)).EndInit();
            this.tabPengguna.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnggota)).EndInit();
            this.tabLaporan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaporan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabBuku;
        private System.Windows.Forms.TabPage tabPengguna;
        private System.Windows.Forms.TabPage tabLaporan;
        private System.Windows.Forms.DataGridView dgvBuku;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKategori;
        private System.Windows.Forms.TextBox txtJudulBuku;
        private System.Windows.Forms.TextBox txtIdBuku;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numStok;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btnResetBuku;
        private System.Windows.Forms.Button btnHapusBuku;
        private System.Windows.Forms.Button btnUpdateBuku;
        private System.Windows.Forms.Button btnTambahBuku;
        private System.Windows.Forms.DataGridView dgvAnggota;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNim;
        private System.Windows.Forms.TextBox txtJurusan;
        private System.Windows.Forms.TextBox txtNamaLengkap;
        private System.Windows.Forms.TextBox txtIdAnggota;
        private System.Windows.Forms.Button btnResetAnggota;
        private System.Windows.Forms.Button btnHapusAnggota;
        private System.Windows.Forms.Button btnUpdateAnggota;
        private System.Windows.Forms.Button btnTambahAnggota;
        private System.Windows.Forms.DataGridView dgvLaporan;
        private System.Windows.Forms.Button btnKonfirmasiKembali;
    }
}