
namespace WindowsFormsApp1
{
    partial class FormUtama
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kirimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cekBarangKirimanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kirimBarangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.antarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ambilBarangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selesaikanPengirimanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keluarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelRole = new System.Windows.Forms.Label();
            this.dekripsiSteganoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kirimToolStripMenuItem,
            this.antarToolStripMenuItem,
            this.keluarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kirimToolStripMenuItem
            // 
            this.kirimToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cekBarangKirimanToolStripMenuItem,
            this.kirimBarangToolStripMenuItem,
            this.dekripsiSteganoToolStripMenuItem});
            this.kirimToolStripMenuItem.Name = "kirimToolStripMenuItem";
            this.kirimToolStripMenuItem.Size = new System.Drawing.Size(68, 29);
            this.kirimToolStripMenuItem.Text = "Kirim";
            // 
            // cekBarangKirimanToolStripMenuItem
            // 
            this.cekBarangKirimanToolStripMenuItem.Name = "cekBarangKirimanToolStripMenuItem";
            this.cekBarangKirimanToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.cekBarangKirimanToolStripMenuItem.Text = "Cek Barang Kiriman";
            this.cekBarangKirimanToolStripMenuItem.Click += new System.EventHandler(this.cekBarangKirimanToolStripMenuItem_Click);
            // 
            // kirimBarangToolStripMenuItem
            // 
            this.kirimBarangToolStripMenuItem.Name = "kirimBarangToolStripMenuItem";
            this.kirimBarangToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.kirimBarangToolStripMenuItem.Text = "Kirim Barang";
            this.kirimBarangToolStripMenuItem.Click += new System.EventHandler(this.kirimBarangToolStripMenuItem_Click);
            // 
            // antarToolStripMenuItem
            // 
            this.antarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ambilBarangToolStripMenuItem,
            this.selesaikanPengirimanToolStripMenuItem});
            this.antarToolStripMenuItem.Name = "antarToolStripMenuItem";
            this.antarToolStripMenuItem.Size = new System.Drawing.Size(71, 29);
            this.antarToolStripMenuItem.Text = "Antar";
            // 
            // ambilBarangToolStripMenuItem
            // 
            this.ambilBarangToolStripMenuItem.Name = "ambilBarangToolStripMenuItem";
            this.ambilBarangToolStripMenuItem.Size = new System.Drawing.Size(288, 34);
            this.ambilBarangToolStripMenuItem.Text = "ambil barang";
            this.ambilBarangToolStripMenuItem.Click += new System.EventHandler(this.ambilBarangToolStripMenuItem_Click);
            // 
            // selesaikanPengirimanToolStripMenuItem
            // 
            this.selesaikanPengirimanToolStripMenuItem.Name = "selesaikanPengirimanToolStripMenuItem";
            this.selesaikanPengirimanToolStripMenuItem.Size = new System.Drawing.Size(288, 34);
            this.selesaikanPengirimanToolStripMenuItem.Text = "Selesaikan Pengiriman";
            this.selesaikanPengirimanToolStripMenuItem.Click += new System.EventHandler(this.selesaikanPengirimanToolStripMenuItem_Click);
            // 
            // keluarToolStripMenuItem
            // 
            this.keluarToolStripMenuItem.Name = "keluarToolStripMenuItem";
            this.keluarToolStripMenuItem.Size = new System.Drawing.Size(76, 29);
            this.keluarToolStripMenuItem.Text = "Keluar";
            this.keluarToolStripMenuItem.Click += new System.EventHandler(this.keluarToolStripMenuItem_Click);
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(584, 51);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(55, 20);
            this.labelUser.TabIndex = 1;
            this.labelUser.Text = "User : ";
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Location = new System.Drawing.Point(584, 89);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(46, 20);
            this.labelRole.TabIndex = 2;
            this.labelRole.Text = "Role:";
            // 
            // dekripsiSteganoToolStripMenuItem
            // 
            this.dekripsiSteganoToolStripMenuItem.Name = "dekripsiSteganoToolStripMenuItem";
            this.dekripsiSteganoToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.dekripsiSteganoToolStripMenuItem.Text = "Dekripsi Stegano";
            this.dekripsiSteganoToolStripMenuItem.Click += new System.EventHandler(this.dekripsiSteganoToolStripMenuItem_Click);
            // 
            // FormUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormUtama";
            this.Text = "FormUtama";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kirimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem antarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keluarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cekBarangKirimanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kirimBarangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ambilBarangToolStripMenuItem;
        public System.Windows.Forms.Label labelUser;
        public System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.ToolStripMenuItem selesaikanPengirimanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dekripsiSteganoToolStripMenuItem;
    }
}

