using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metotlar
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnOrnek1_Click(object sender, EventArgs e)
        {
            //ÖRNEK-1 : Sıfırdan 1000' kadar listbox'ın içerisine ekleyiniz.
            Saydirici();
        }

        void Saydirici()
        {
            for (int i = 0; i <= 1000; i++)
            {
                listBox1.Items.Add(i);
            }
        }

        private void btnORNEK2_Click(object sender, EventArgs e)
        {
            // ÖRNEK-2 : Formun arka plan rengini ve boyutlarını değiştirecek bir metot yazınız...
            //Arka plan rengi beyaz , boyutları ise 400 400 olsun

            formDuzenleyici();
        }

        void formDuzenleyici()
        {
            this.BackColor = Color.White;
            this.Width = 400;
            this.Height = 400;
        }
    }
}
