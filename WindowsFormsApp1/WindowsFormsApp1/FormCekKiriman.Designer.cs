﻿
namespace WindowsFormsApp1
{
    partial class FormCekKiriman
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaBarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tujuanKirim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(321, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ambil Kiriman";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.namaBarang,
            this.tujuanKirim,
            this.status});
            this.dataGridView1.Location = new System.Drawing.Point(32, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(736, 316);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.Width = 150;
            // 
            // namaBarang
            // 
            this.namaBarang.HeaderText = "Nama Barang";
            this.namaBarang.MinimumWidth = 8;
            this.namaBarang.Name = "namaBarang";
            this.namaBarang.Width = 150;
            // 
            // tujuanKirim
            // 
            this.tujuanKirim.HeaderText = "Tujuan Kirim";
            this.tujuanKirim.MinimumWidth = 8;
            this.tujuanKirim.Name = "tujuanKirim";
            this.tujuanKirim.Width = 150;
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.MinimumWidth = 8;
            this.status.Name = "status";
            this.status.Width = 150;
            // 
            // FormCekKiriman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormCekKiriman";
            this.Text = "FormCekKiriman";
            this.Load += new System.EventHandler(this.FormCekKiriman_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaBarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn tujuanKirim;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}