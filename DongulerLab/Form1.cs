using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DongulerLab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMukemmel_Click(object sender, EventArgs e)
        {
            //MÜKEMMEL SAYI : Kendisi hariç tam çarpanları toplamı kendisine eşit olan sayıya denir.

            int sayi = Convert.ToInt32(textBox1.Text);
            int toplam = 0;

            for (int i = 1; i < sayi; i++)
            {
                if (sayi%i==0)
                {
                    toplam = toplam + i;
                }
                
            }
            if (toplam==sayi)
            {
                MessageBox.Show("Mükemmel sayidir");

            }
            else
            {
                MessageBox.Show("Mükemmel Değildir.", "sonuc", MessageBoxButtons.OK);
            }



        }


    }
}
