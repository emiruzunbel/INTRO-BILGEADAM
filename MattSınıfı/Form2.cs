using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MattSınıfı
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnORNEK1_Click(object sender, EventArgs e)
        {
            //Dışarıdan girilen 3 sayıdan en küçüğümü tek satırda gösteriniz
            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);
            int sayi3 = Convert.ToInt32(textBox3.Text);

            int sonuc =Math.Min(Math.Min(sayi1, sayi2),sayi3);
            MessageBox.Show(sonuc.ToString());
        }

        
    }
}
