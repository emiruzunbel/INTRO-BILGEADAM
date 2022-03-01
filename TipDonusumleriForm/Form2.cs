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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_Toplam_Click(object sender, EventArgs e)
        {
            //    int sayiBir = 102;
            //    int sayiIki = 25;
            //    int toplam = sayiBir + sayiIki;

            ////Saşıda toplam değişeknini string'e çevirmeden yazdığımız halde derleyicinin bize kızmamasının sebebi "implicit convert" dediğimiz olaydır .. 
            ////Yani eğer bir toplama işleminde string varsa ,geriye kalan tüm değerler otomatik olarak string'e cevrilir.. 

            //    MessageBox.Show("Toplam Sonucu ="+ toplam);

            //    MessageBox.Show("Toplam sonuc= "+ (sayiBir+sayiIki));
            //    MessageBox.Show("Toplam sonucu "+ sayiBir+sayiIki);

            int sayi1 =Convert.ToInt32(  txt_SayiBir.Text);
            int sayi2 = Convert.ToInt32(txt_Sayi2.Text);
            int toplam = sayi1 + sayi2;
            MessageBox.Show("toplam  ="+toplam);

            txt_SayiBir.Text = "";
            txt_Sayi2.Text = "";

            // txt_Sayi2.Clear();
          
        }

        private void btn_Fark_Click(object sender, EventArgs e)
        {
         int fark=   Convert.ToInt32(txt_SayiBir.Text) - Convert.ToInt32(txt_Sayi2.Text);
            MessageBox.Show("Fark =" +fark);
            txt_SayiBir.Text = "";
            txt_Sayi2.Text = "";
        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Çarpma= "+(Convert.ToInt32(txt_SayiBir.Text)*Convert.ToInt32(txt_Sayi2.Text)).ToString());
            txt_SayiBir.Text = "";
            txt_Sayi2.Text = "";
        }

        private void btn_Bolme_Click(object sender, EventArgs e)
        {
            double bolme = Convert.ToDouble(txt_SayiBir.Text) / Convert.ToDouble(txt_Sayi2.Text);
            MessageBox.Show("Bölme =" + bolme);
            txt_SayiBir.Text = "";
            txt_Sayi2.Text = "";
        }

        private void btn_ModAlma_Click(object sender, EventArgs e)
        {
            double Mod = Convert.ToDouble(txt_SayiBir.Text) % Convert.ToDouble(txt_Sayi2.Text);
            MessageBox.Show("ModAlma =" + Mod);
            txt_SayiBir.Text = "";
            txt_Sayi2.Text = "";
        }
        private void btn_Pow_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Math.Pow(Convert.ToDouble(txt_SayiBir.Text), Convert.ToDouble(txt_Sayi2.Text)).ToString());
            txt_SayiBir.Text = "";
            txt_Sayi2.Text = "";
        }

        private void btnParseTopla_Click(object sender, EventArgs e)
        {
            //String int ,bool ,float, decimal, double gibi bir değişken değildir. String Referans tipili bir değişkendir .Bu nedenle toString Metodu  object class tanımlanmış olup bütün miras aldığı alt sınıflarda kullanılabilir.. 
            string deger = "True";
            string deger1 = "50";
          //int deger1=   int.Parse(deger);
            bool deger6 = bool.Parse(deger);
          decimal test =  decimal.Parse(deger1);



           // deger1++;
           // MessageBox.Show(deger1.ToString());

             
            string deger2 = "50";
            int sonuc=0;
           bool oldumu = int.TryParse(deger2, out sonuc);
            MessageBox.Show(oldumu.ToString() + sonuc);



            double deger50 = 5000;
            int castet = (int)deger50;


            int islem40 = 1000;
            short castet1 =(short)islem40;

            //C# Ortamında her değeri tutabilen değişken "Var".
            var deger100 = 5000;
            var deger101 = "5000";
            var deger103 = true;
           
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            label5.Text = (nud_sayiBir.Value + nud_SayiIki.Value).ToString();
        }
    }
}
