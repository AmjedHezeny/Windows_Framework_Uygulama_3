using _4.Ders.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4.Ders
{
    public partial class Jackpot : Form
    {
        public Jackpot()
        {
            InitializeComponent();
        }
        int cevirmeSuresi = 3000;
        int resimDegistirmeSuresi = 100;
        int sayac = 0;
        List<Bitmap> resimler = new List<Bitmap>()
        {
            Resources.ananas,
            Resources.armut,
            Resources.cilek,
            Resources.elma,
            Resources.kiraz,
            Resources.muz,
            Resources.seftali

        };
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            Random rnd= new Random();

            int rastgeleSayi;

            rastgeleSayi = rnd.Next(0,resimler.Count);
            pictureBox1.Image = resimler[rastgeleSayi];

            rastgeleSayi=rnd.Next(0,resimler.Count);
            pictureBox2.Image = resimler[rastgeleSayi];

            rastgeleSayi=rnd.Next(0,resimler.Count);
            pictureBox3.Image = resimler[rastgeleSayi];

            if (sayac==(cevirmeSuresi/resimDegistirmeSuresi))
            {
                timer1.Stop();
                sayac = 0;
                KontrolEt();
            }


        }

        private void KontrolEt()
        {
            if 
                (pictureBox1.Image==pictureBox2.Image && pictureBox1.Image==pictureBox3.Image)
            {
                label1.Text = "Tebrikler Kazandınız";
                label1.ForeColor = Color.Green;
            }
            else if (
                pictureBox1.Image==pictureBox2.Image || pictureBox1.Image==pictureBox3.Image ||
                pictureBox2.Image==pictureBox3.Image
                )
            {
                label1.Text = "Amorti Kazandınız";
                label1.ForeColor = Color.Orange;
            }
            else
            {
                label1.Text = "Malesef Kaybettiniz";
                label1.ForeColor = Color.Red;
            }
        }
    }
}
