using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KişiselCalısma
{
    public partial class HazırClasslar : Form
    {
        public HazırClasslar()
        {
            InitializeComponent();
        }

        private void HazırClasslar_Load(object sender, EventArgs e)
        {
            //Pi double dönüyor.
            double pi = Math.PI;
            this.Text = pi.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ABS = MUTLAK DEĞER.
            int sayi = Math.Abs(Convert.ToInt32(textBox1.Text));
            MessageBox.Show(sayi.ToString());
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           double sayi1 = Math.Floor(Convert.ToDouble(textBox1.Text));
            MessageBox.Show(sayi1.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double sayi1 = Math.Ceiling(Convert.ToDouble(textBox1.Text));
            MessageBox.Show(sayi1.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double sayi1 = Math.Round(Convert.ToDouble(textBox1.Text));
            MessageBox.Show(sayi1.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double sayi1 = Math.Truncate(Convert.ToDouble(textBox1.Text));
            MessageBox.Show(sayi1.ToString());
        }
    }
}
