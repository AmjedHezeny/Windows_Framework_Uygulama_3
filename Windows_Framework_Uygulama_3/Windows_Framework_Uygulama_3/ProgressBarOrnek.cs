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
    public partial class ProgressBarOrnek : Form
    {
        public ProgressBarOrnek()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                progressBar1.Value = textBox1.Text.Length;
            }
            catch 
            {

                MessageBox.Show("Max 100 karakter girebilirsiniz");
            }
        }
    }
}
