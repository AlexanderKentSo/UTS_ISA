
namespace WindowsFormsApp1
{
    partial class FormStegano
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
            this.pictureBoxImg = new System.Windows.Forms.PictureBox();
            this.labelImg = new System.Windows.Forms.Label();
            this.buttonPickImg = new System.Windows.Forms.Button();
            this.labelKiriman = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImg)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxImg
            // 
            this.pictureBoxImg.Location = new System.Drawing.Point(28, 52);
            this.pictureBoxImg.Name = "pictureBoxImg";
            this.pictureBoxImg.Size = new System.Drawing.Size(193, 172);
            this.pictureBoxImg.TabIndex = 0;
            this.pictureBoxImg.TabStop = false;
            // 
            // labelImg
            // 
            this.labelImg.AutoSize = true;
            this.labelImg.Location = new System.Drawing.Point(28, 240);
            this.labelImg.Name = "labelImg";
            this.labelImg.Size = new System.Drawing.Size(141, 20);
            this.labelImg.TabIndex = 1;
            this.labelImg.Text = "(nama file gambar)";
            // 
            // buttonPickImg
            // 
            this.buttonPickImg.Location = new System.Drawing.Point(247, 52);
            this.buttonPickImg.Name = "buttonPickImg";
            this.buttonPickImg.Size = new System.Drawing.Size(145, 172);
            this.buttonPickImg.TabIndex = 2;
            this.buttonPickImg.Text = "Pilih Gambar";
            this.buttonPickImg.UseVisualStyleBackColor = true;
            this.buttonPickImg.Click += new System.EventHandler(this.buttonPickImg_Click);
            // 
            // labelKiriman
            // 
            this.labelKiriman.AutoSize = true;
            this.labelKiriman.Location = new System.Drawing.Point(28, 18);
            this.labelKiriman.Name = "labelKiriman";
            this.labelKiriman.Size = new System.Drawing.Size(159, 20);
            this.labelKiriman.TabIndex = 3;
            this.labelKiriman.Text = "(Nama paket kiriman)";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(28, 298);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(364, 48);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Simpan Gambar Stegano";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // FormStegano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 364);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelKiriman);
            this.Controls.Add(this.buttonPickImg);
            this.Controls.Add(this.labelImg);
            this.Controls.Add(this.pictureBoxImg);
            this.Name = "FormStegano";
            this.Text = "FormStegano";
            this.Load += new System.EventHandler(this.FormStegano_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxImg;
        private System.Windows.Forms.Label labelImg;
        private System.Windows.Forms.Button buttonPickImg;
        private System.Windows.Forms.Label labelKiriman;
        private System.Windows.Forms.Button buttonSave;
    }
}