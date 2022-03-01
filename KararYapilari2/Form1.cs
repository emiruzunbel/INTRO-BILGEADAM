using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KararYapilari2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNotKontrol_Click(object sender, EventArgs e)
        {
            //ÖRNEK 1 = gİRİLEN NOT 0-30 aralığında ise "FF" , 30-50 aralığında ise "DD" , 50-70 aralığında ise "BB" , 70-100 aralığında ise "AA "yazdıralım
            int not = int.Parse(textBox1.Text);

            if (0<=not && not<=30)
            {
                MessageBox.Show("Harfli notunuz FF");
            }
            else if (30<not && not<=50)
            {
                MessageBox.Show("Harfli notunuz DD");
            }
            else if (50<not && not<=70)
            {
                MessageBox.Show("Harfli notunuz BB");
            }
            else if (70<not && not<=100)
            {
                MessageBox.Show("Harfli notunuz AA");
            }
            else
            {
                MessageBox.Show("Yanlış not girişi yaptınız");
            }


           
                










            
        }

        private void grpNotKontrol_Enter(object sender, EventArgs e)
        {

        }

        private void btnSor_Click(object sender, EventArgs e)
        {
            //Dışarıdan ürün adı girilererek , kasiyer bize ürünün hangi reyonda olduğuna dair bilge verecek.
            //Domates,Biber ,Patlıcan =>> Sebze Reyonu
            //Diş macunu,parfüm,Şampuan =>> Kozmetik Reyonu
            //Cep telefonu , bilgisayar , ses sistemi =>> Teknoloji Reyonu
            //Bu ürünlerden başka bir ürün girilmesi durumunda =>> Bu ürün mevcut değildir.

            string urun = textBox2.Text;
            string mesaj = "";
            if (urun == "Domates" || urun== "Biber" || urun == "Patlıcan")
            {
                mesaj = "Girdiğiniz ürün Sebze reyonundadır.";
            }
            else if (urun == "Diş macunu" || urun == "Parfüm" || urun == "Şampuan")
            {
                mesaj = "Girdiğiniz ürün Kozmetik reyonundadır.";
            }
            else if (urun == "Cep Telefonu" || urun == "Bilgisayar" || urun == "Ses sistemi")
            {
                mesaj = "Girdiğiniz ürün Teknoloji reyonundadır";
            }
            else
            {
                mesaj = "Girdiğiniz ürün mevcut değildir";
            }
            MessageBox.Show(mesaj);


        }

        private void btnSatıs_Click(object sender, EventArgs e)
        {
            //Dışarıdan sipariş alıncak olan kitap adet bilgisi girilsin. Sipariş sayısı 20'den az ise toplam ücretten %5 , 20-50 aralığında ise %10 , 50-100 aralığında ise %15 , 100 'den fazla ise %25 indirim yapılsın
            //Kitabın birim fiyatı =>>5 tl dir. Amac =>> Ödenecek olan tutarı kullanıya göstermek.


            int siparisAdet = int.Parse(textBox3.Text);
            int fiyat = 5;
            int toplamFiyat = (fiyat * siparisAdet);
            string sonuc = "";

            if (siparisAdet < 20)
            {
                int indirimliFiyat = toplamFiyat - (toplamFiyat * 5 / 100);
                sonuc = "Ödenecek Tutarı" +  Convert.ToString(indirimliFiyat);
            }
            else if (siparisAdet >= 20 && siparisAdet < 50)
            {
                int indirimliFiyat = toplamFiyat - (toplamFiyat * 10 / 100);
                sonuc = "Ödenecek Tutarı" + Convert.ToString(indirimliFiyat);
            }
            else if ((siparisAdet >= 50 && siparisAdet < 100))
            {
                int indirimliFiyat = toplamFiyat - (toplamFiyat * 15 / 100);
                sonuc = "Ödenecek Tutarı" + Convert.ToString(indirimliFiyat);
            }
            else if (siparisAdet >= 100)
            {
                int indirimliFiyat = toplamFiyat - (toplamFiyat * 25 / 100);
                sonuc = "Ödenecek Tutarı" + Convert.ToString(indirimliFiyat);
            }
            MessageBox.Show(sonuc);

            






            //Mantıksal Operatörler
            //------------------------------
            //Bazen birden fazla durumu aynı anda kontrol etmek istiyor olabiliriz.Bu gibi durumlarda operatörlerden yararlanılır.

            //&& (ve)(kontrol bloğu içerisinde yer alan tüm koşullardan herhangi birinin sağlanmaması durumunda işaret eder..)
            //Öylece bir koşul sağlansa bloğunuzda yazdığınız kodlar harekte geçmez.

            //|| (veya) alt gr - ile yapılır.
            //Kontrol bloğu içerisinde yer alan koşullardan herhangi birinin sağlanması durumuna işaret eder.
            //Öylece bir koşul sağlansa bile bloğunuzda yazdığınız kodlar hareke geçeer.

            //Yukarıda yazdığımız operatörler "Kısa devre operatörü olarak geçer".Koşulları kontrole el soldan başlar.Herhangi bir uygunsuzluk durumunda diğer koşullara asla bakmaz.

            //Aşağıdaki operatörlerde ise koşullara uysun veya uymasın hepsi kontrol edilir.
            // & => Ve
            // | => Veya
        }






    }
}
