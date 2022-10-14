using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taş_kağıt_makass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        int sen = 0;
            int cpu = 0;

            public string gonder()
            {
                Random sayi = new Random();
                int deger = sayi.Next(1, 4);
                string resimyol = "res" + deger + ".png";
                return resimyol;
            }
        

        private void button1_Click(object sender, EventArgs e)
        {
            string resimler = gonder();
            pictureBox2.ImageLocation = resimler;
            if (pictureBox1.ImageLocation == "res1.png" && pictureBox2.ImageLocation == "res2.png")
            {
                label6.Text = "Oyuncu Kazanır";
                sen++;
            }
            else if (pictureBox1.ImageLocation == "res2.png" && pictureBox2.ImageLocation == "res1.png")
            {
                label6.Text = "CPU Kazanır";
                cpu++;
            }
            else if (pictureBox1.ImageLocation == "res1.png" && pictureBox2.ImageLocation == "res3.png")
            {
                label6.Text = "CPU Kazanır";
                cpu++;
            }
            else if (pictureBox1.ImageLocation == "res3.png" && pictureBox2.ImageLocation == "res1.png")
            {
                label6.Text = "Oyuncu Kazanır";
                sen++;
            }
            else if (pictureBox1.ImageLocation == "res2.png" && pictureBox2.ImageLocation == "res3.png")
            {
                label6.Text = "Oyuncu Kazanır";
                sen++;
            }
            else if (pictureBox1.ImageLocation == "res3.png" && pictureBox2.ImageLocation == "res2.png")
            {
                label6.Text = "CPU Kazanır";
                cpu++;
            }
            else
            {
                label6.Text = "Beraberlik";
            }
            label3.Text = Convert.ToString(sen);
            label5.Text = Convert.ToString(cpu);
            if (label3.Text == "10")
            {
                label6.Text = "OYUN SONU\n SEN KAZANDIN";
                button1.Visible = false;
            }
            if (label5.Text == "10")
            {
                label6.Text = "OYUN SONU\n CPU KAZANDI";
                button1.Visible = false;
            }
            button1.Text = "TEKRAR";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "res3.png";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "res2.png";

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "res1.png";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = "0";
            label5.Text = "0";
            label6.Text = "SONUÇ";
            sen = 0;
            cpu = 0;
            button1.Visible = true;
            button1.Text = "BAŞLA";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
