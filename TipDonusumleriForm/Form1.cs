using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TipDonusumleriForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba Dünya");


            int sayi = 25;
            MessageBox.Show(sayi.ToString());

        }

        private void btn_topla_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Toplama işlemi. yapar");
        }

        private void btnToplamaİslemi_Click(object sender, EventArgs e)
        {
            //Console bizlerin data okumasını sağlayan  metot Readline() ; 
            //Fakat burda bu şekilde bir metot 'a gerek yok çünkü nesneleri kullanıyoruz.



            //txtBirinciDeger.text =>> Textbox üzerindeki değeri size teslim eder .Text özellikleri istisnasiz sizlere "string"döner. 
            //İki metni toplarsanız. size o metinin yanyana gelmiş halini verir.
            string gelenDegerBir= txtBirinciSayi.Text;
            string gelenDegeriki= txt_ikinciSayi.Text;
            string toplam = gelenDegerBir + gelenDegeriki;
            MessageBox.Show(toplam);

             int cevrilenDegerBir= Convert.ToInt32(txtBirinciSayi.Text);
             int cevrilenDegerİki = Convert.ToInt32(txt_ikinciSayi.Text);
            int MatematikselToplam = cevrilenDegerBir + cevrilenDegerİki;


            MessageBox.Show(MatematikselToplam.ToString());
            this.Text = MatematikselToplam.ToString();

  

        }
    }
}
