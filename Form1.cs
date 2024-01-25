using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testy
{
    public partial class Form1 : Form
    {
        Image NarysowanyObrazek;
        int WielkoscPedzla=1;
        string Nick;
        Color KolorPedzla= Color.FromArgb(0,0,0);

        public Form1()
        {
            InitializeComponent();
            NarysowanyObrazek = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = NarysowanyObrazek;
        }

        Graphics g; 

        private void PictureBox1_Hover(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                g = Graphics.FromImage(NarysowanyObrazek);
                g.DrawEllipse(new Pen(KolorPedzla, WielkoscPedzla * 4), e.X, e.Y, 1, 1);
                pictureBox1.Refresh();
                label1.Text = e.X.ToString(); label2.Text = e.Y.ToString();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                KolorPedzla = colorDialog1.Color;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            pictureBox1.Refresh();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            WielkoscPedzla = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            WielkoscPedzla = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            WielkoscPedzla = 3;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            WielkoscPedzla = 4;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            WielkoscPedzla = 5;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length<=1)
            {
                label8.Text = "Nieprawidłowy nick";
            }else
            {
                Nick = textBox1.Text;
                button4.Visible = false;
                label8.Visible = false;
                textBox1.Visible = false;
                pictureBox1.Visible = true;
                button1.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                label9.Visible = true;
                label9.Text = $"Nick: {Nick}, Teraz rysuje: ";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.Save(@"image.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
        }
    }
}
