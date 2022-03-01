using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calısma1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int toplam = 0;
            int sayi;   
            
            for (int i = 0; i < 5; i++)
            {
                Random rastgele = new Random(i);
                sayi = rastgele.Next(0,40);
                listBox1.Items.Add(sayi);
                //toplam += sayi;
                //double ortalama = Convert.ToDouble(toplam / 5);
                //while (ortalama < sayi)
                //{
                //    listBox2.Items.Add(sayi);
                //}
            }
            




















        }
    }
}
