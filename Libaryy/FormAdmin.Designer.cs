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
            this.tabPengguna = new System.Windows.Forms.TabPage();
            this.tabLaporan = new System.Windows.Forms.TabPage();
            this.dgvBuku = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabBuku.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuku)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            // tabPengguna
            // 
            this.tabPengguna.Location = new System.Drawing.Point(4, 22);
            this.tabPengguna.Name = "tabPengguna";
            this.tabPengguna.Padding = new System.Windows.Forms.Padding(3);
            this.tabPengguna.Size = new System.Drawing.Size(697, 356);
            this.tabPengguna.TabIndex = 1;
            this.tabPengguna.Text = "Manajemen Pengguna";
            this.tabPengguna.UseVisualStyleBackColor = true;
            // 
            // tabLaporan
            // 
            this.tabLaporan.Location = new System.Drawing.Point(4, 22);
            this.tabLaporan.Name = "tabLaporan";
            this.tabLaporan.Padding = new System.Windows.Forms.Padding(3);
            this.tabLaporan.Size = new System.Drawing.Size(697, 356);
            this.tabLaporan.TabIndex = 2;
            this.tabLaporan.Text = "Laporan Peminjaman";
            this.tabLaporan.UseVisualStyleBackColor = true;
            // 
            // dgvBuku
            // 
            this.dgvBuku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuku.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvBuku.Location = new System.Drawing.Point(3, 3);
            this.dgvBuku.Name = "dgvBuku";
            this.dgvBuku.Size = new System.Drawing.Size(691, 150);
            this.dgvBuku.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 159);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(681, 191);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detail Buku";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 382);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            this.tabControl1.ResumeLayout(false);
            this.tabBuku.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuku)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
    }
}