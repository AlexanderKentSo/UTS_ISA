using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lib;

namespace WindowsFormsApp1
{
    public partial class FormDekripsi : Form
    {
        public FormDekripsi()
        {
            InitializeComponent();
        }

        private void buttonPickImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog img = new OpenFileDialog();
            img.Filter = "Images Files(*.png,*.jpg)|*.png;*.jpg";
            img.InitialDirectory = @"C:\Users\user\Pictures";
            if (img.ShowDialog() == DialogResult.OK)
            {
                labelImg.Text = img.FileName.ToString();
                pictureBoxImg.ImageLocation = labelImg.Text;
            }
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                if (labelImg.Text != "")
                {
                    Bitmap img = new Bitmap(labelImg.Text);
                    Kiriman.printKirimanStegano(img);
                }
                else
                {
                    throw new Exception("pilih gambar terlebih dahulu");
                }
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void FormDekripsi_Load(object sender, EventArgs e)
        {
            pictureBoxImg.SizeMode = PictureBoxSizeMode.Zoom;
            labelImg.Text = "";
        }
    }
}
