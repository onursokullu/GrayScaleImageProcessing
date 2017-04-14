using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrayScaleImageProcessing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (openFileDialog1.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                return;
            }
            pictureBox1.ImageLocation = openFileDialog1.FileName;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(pictureBox1.Image);
            Bitmap gray = makeitgray(image);
            pictureBox2.Image = gray;

        }
        private Bitmap makeitgray(Bitmap image)
        {
            int i, j;
            for (i = 0; i < image.Height - 1; i++)
            {
                for (j = 0; j < image.Width; j++)
                {
                    int ort = (image.GetPixel(j, i).R + image.GetPixel(j, i).G + image.GetPixel(j, i).B) / 3;
                    Color color;
                    color = Color.FromArgb(ort, ort, ort);
                    image.SetPixel(j, i, color);

                }
            }
            return image;
        }
    }
}
