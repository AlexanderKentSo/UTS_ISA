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
    public partial class FormStegano : Form
    {
        public Kiriman k;
        public FormStegano()
        {
            InitializeComponent();
        }

        private void FormStegano_Load(object sender, EventArgs e)
        {
            pictureBoxImg.SizeMode = PictureBoxSizeMode.Zoom;
            labelKiriman.Text = "Kiriman: " + k.Barang;
            labelImg.Text = "";
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

        private void buttonSave_Click(object sender, EventArgs e)
        {

            try
            {
                if (labelImg.Text != "")
                {
                    Bitmap img = new Bitmap(labelImg.Text);

                    // nyimpen id kirimannya di pojokan gambar
                    img.SetPixel(0, 0, Color.FromArgb(img.GetPixel(0, 0).R, img.GetPixel(0, 0).G, k.Id));

                    // kode kalau misalnya gambar ini memang mengandung data kiriman
                    img.SetPixel(img.Width - 1, 0, Color.FromArgb(img.GetPixel(img.Width - 1, 0).R, img.GetPixel(img.Width - 1, 0).G, 69));
                    img.SetPixel(0, img.Height - 1, Color.FromArgb(69, img.GetPixel(0, img.Height - 1).G, img.GetPixel(0, img.Height - 1).B));

                    // pengamanan extra supaya hacker nggak bisa membobol database kiriman dari ganti2 pixel
                    img.SetPixel(img.Width - 1, img.Height - 1, Color.FromArgb(k.IdPengirim, k.IdPenerima, img.GetPixel(img.Width - 1, img.Height - 1).B));

                    SaveFileDialog save = new SaveFileDialog();
                    save.Filter = "Images Files(*.png)|*.png";
                    save.InitialDirectory = @"C:\Users\user\Pictures";
                    if (save.ShowDialog() == DialogResult.OK)
                    {
                        img.Save(save.FileName.ToString());
                    }
                }
                else
                {
                    throw new Exception("pilih gambar terlebih dahulu");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
