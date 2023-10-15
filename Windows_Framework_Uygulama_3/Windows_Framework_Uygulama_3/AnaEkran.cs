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
    public partial class AnaEkran : Form
    {
        public AnaEkran()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f=new Form1();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Jackpot j=new Jackpot();
            j.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProgressBarr pb=new ProgressBarr();
            pb.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ProgressBarOrnek pb=new ProgressBarOrnek();
            pb.Show();
        }
    }
}
