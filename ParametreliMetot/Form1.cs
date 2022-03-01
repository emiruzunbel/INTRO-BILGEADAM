using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParametreliMetot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void ParametreliSaydir(int kacaKadarSayalim)
        {
            listBox1.Items.Clear();
            for (int i = 0; i <= kacaKadarSayalim; i++)
            {
                listBox1.Items.Add(i);
            }
        }

        private void btnSaydır_Click(object sender, EventArgs e)
        {
            ParametreliSaydir(5000);
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            //ÖRNEK-2 : Dışarıdan girilen iki sayının toplamının küpünü messageBox lagösterecek bir metot yazınız.
            topKüp(4, 6);
        }

        void topKüp(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            int gelensonuc = Convert.ToInt32(Math.Pow(Convert.ToDouble(toplam), 3));
            MessageBox.Show(toplam.ToString());
        }

        void renkDegistir(string renk)
        {
            this.BackColor = Color.FromName(renk);
        }

        private void btnOrnek3_Click(object sender, EventArgs e)
        {
            //ÖRNEK3 : Combobox' dan seçilen rengi formun arka plan rengi olarak ayarlayan bir metot yazınız.
            //Bu soruyu çözerken color sınıfına göz atmayı unutmayalım.
            renkDegistir(comboBox1.SelectedItem.ToString());
        }
        void son3harf(string deger)
        {
            if (deger.Length <= 3)
            {

                MessageBox.Show(deger);
            }
            else
            {
                MessageBox.Show(deger.Substring(deger.Length - 3, 3));

            }

        }


        private void btnSon3_Click(object sender, EventArgs e)
        {
            //ÖRNEK-4 : Dışarıdan girilen son 3 harfini messageboxla veren bir metot yazınız.
            //Ancak girilen değer 3 harften azsa ya da eşit ise direk olarak tamamını gösteriniz.

            son3harf(textBox2.Text);
        }

        //ÖRNEK : Dışarıdan girilen telefon numaralarını ; , + gördüğü yerde ayırıp lisboxa dolduran

        void parcaliyici(string telefon)
        {
            string[] telefonlar =telefon.Split(';' , ',' , '+');
            foreach (var item in telefonlar)
            {
                listBox1.Items.Add(telefon);
            }
        }

        private void btnAyristirici_Click(object sender, EventArgs e)
        {
            parcaliyici(textBox3.Text);
        }
    }

       
}
