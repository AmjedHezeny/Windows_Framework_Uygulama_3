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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Image.FromFile(dosyaYolu) => Metodu aracılığı ile dış bir kaynaktaki resmi Image formatında alıp picturebox içerisinde gösterebilirsiniz
            pictureBox1.Image = Image.FromFile(@"C:\Users\sadullah.sener\Desktop\Yeni klasör\spongebob.jpg");
        }

      

        private void button2_Click(object sender, EventArgs e)
        {
            //Resources dosyası içerisine kayıt edilen dosyalara Resources. diyerek ulaşım sağlayabiliriz
            pictureBox1.Image = Resources.Squidward;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //ImageLocation => property si ile uzak sunucu üzerindeki resimleri projeniz içerisinde gösterebilirsiniz
            pictureBox1.ImageLocation = "https://static.wikia.nocookie.net/spongebob/images/5/5d/Patrick_stock_art.png/revision/latest?cb=20210812083708";
        }
    }
}
