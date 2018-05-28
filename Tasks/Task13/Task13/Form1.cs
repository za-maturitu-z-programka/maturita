using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace Task13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Graphics gr;
        SolidBrush brush;

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            gr = Graphics.FromImage(pictureBox1.Image);
            brush = new SolidBrush(Color.Black);
            gr.Clear(Color.White);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int sirka = Convert.ToInt32(numericUpDown1.Value);
                brush.Color = panel1.BackColor;

                gr.FillEllipse(brush, e.X - sirka / 2, e.Y - sirka / 2, sirka, sirka);

                pictureBox1.Refresh();
            }
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = panel1.BackColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                panel1.BackColor = colorDialog1.Color;
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int w = Convert.ToInt32(numericUpDown1.Value);
                brush.Color = panel1.BackColor;

                gr.FillEllipse(brush, e.X - w / 2, e.Y - w / 2, w, w);

                pictureBox1.Refresh();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "PNG soubor |*.png" +
                "|BMP soubor |*.bmp" +
                "|JPG soubor |*.jpg" +
                "|GIF soubor |*.gif";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        pictureBox1.Image.Save(saveFileDialog1.FileName, ImageFormat.Png);
                        break;
                    case 2:
                        pictureBox1.Image.Save(saveFileDialog1.FileName, ImageFormat.Bmp);
                        break;
                    case 3:
                        pictureBox1.Image.Save(saveFileDialog1.FileName, ImageFormat.Jpeg);
                        break;
                    case 4:
                        pictureBox1.Image.Save(saveFileDialog1.FileName, ImageFormat.Gif);
                        break;
                }
            }
        }
    }
}
