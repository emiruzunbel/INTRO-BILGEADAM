using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KararYapilari1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void BTNNotKontrolü_Click(object sender, EventArgs e)
        {
            int not = Convert.ToInt32(textBox1.Text);

            if (not < 0 )
            {
                MessageBox.Show("Sıfırdan küçük not girişi yapamazsınız");
            }
            else if (not >100)
            {
                MessageBox.Show("100'den büyük not giriş yapamazsınız");
            }
            else
            {
                MessageBox.Show("Başarılı not girişi yaptınız.");
            }
        }

        private void btnTekCiftKontrol_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox3.Text);

            if (sayi % 2 == 0)
            {
                MessageBox.Show("Girdiğiniz sayı çifttir");
            }
            else if (sayi % 2 == 1)
            {
                MessageBox.Show("Girdiğiniz sayı tektir.");
            }







        }

        private void btnPasswordKontrol_Click(object sender, EventArgs e)
        {
            int uzunluk = textBox6.Text.Length;
            if (uzunluk >= 8)
            {
                MessageBox.Show("Kayıt onaylandı.");
            }
            else
            {
                MessageBox.Show("Daha uzun bir şifre giriniz");
            }
        }
    }
}
