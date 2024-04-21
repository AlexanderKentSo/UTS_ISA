
namespace WindowsFormsApp1
{
    partial class FormDekripsi
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
            this.buttonPickImg = new System.Windows.Forms.Button();
            this.pictureBoxImg = new System.Windows.Forms.PictureBox();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.labelImg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImg)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPickImg
            // 
            this.buttonPickImg.Location = new System.Drawing.Point(244, 33);
            this.buttonPickImg.Name = "buttonPickImg";
            this.buttonPickImg.Size = new System.Drawing.Size(145, 172);
            this.buttonPickImg.TabIndex = 4;
            this.buttonPickImg.Text = "Pilih Gambar";
            this.buttonPickImg.UseVisualStyleBackColor = true;
            this.buttonPickImg.Click += new System.EventHandler(this.buttonPickImg_Click);
            // 
            // pictureBoxImg
            // 
            this.pictureBoxImg.Location = new System.Drawing.Point(25, 33);
            this.pictureBoxImg.Name = "pictureBoxImg";
            this.pictureBoxImg.Size = new System.Drawing.Size(193, 172);
            this.pictureBoxImg.TabIndex = 3;
            this.pictureBoxImg.TabStop = false;
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Location = new System.Drawing.Point(25, 271);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(364, 48);
            this.buttonDecrypt.TabIndex = 6;
            this.buttonDecrypt.Text = "Dekripsi Gambar Stegano";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // labelImg
            // 
            this.labelImg.AutoSize = true;
            this.labelImg.Location = new System.Drawing.Point(25, 213);
            this.labelImg.Name = "labelImg";
            this.labelImg.Size = new System.Drawing.Size(141, 20);
            this.labelImg.TabIndex = 5;
            this.labelImg.Text = "(nama file gambar)";
            // 
            // FormDekripsi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 333);
            this.Controls.Add(this.buttonDecrypt);
            this.Controls.Add(this.labelImg);
            this.Controls.Add(this.buttonPickImg);
            this.Controls.Add(this.pictureBoxImg);
            this.Name = "FormDekripsi";
            this.Text = "FormDekripsi";
            this.Load += new System.EventHandler(this.FormDekripsi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPickImg;
        private System.Windows.Forms.PictureBox pictureBoxImg;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.Label labelImg;
    }
}