using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeriyeDegerDondurenMetot_Fonksiyonlar_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region NEDİR??     
        //Fonksiyonlar (Geriye değer döndüren metotlar)
        //-----------------------------------------------------
        //Tıpkı void metotlar gibi kendine ait bir alanda işlemler gerçekleştiren ancak bu işlemler neticesinde geriye değer dönen yapılardır













        #endregion

        #region GERİYE DEGER DÖNDÜRMESİ NE DEMEKTİR?

        //Metodun Geriye Değer Döndürmesi ne demektir ?
        //----------------------------------------------------
        //Ekrana çıktı vermek değildir.
        //Metodun geriye döndürdüğü değer ; algoritmanın akışında kullanılabilir değerdir.
        
        #endregion

        #region ÖRNEK-1:
        //Geriye değer döndüren:
        int toplamaYap(int s1,int s2,int s3)
        {
            int toplam = s1 + s2 + s3;
            //NOT: Bir metottan çıkan sonucu dış dünyaya döndürmek için kullandığımız anahtar kelimemiz 'return' dur.
            return toplam;
        }

        //Geriye değer döndürmeyen :
        //void toplamaYapp(int s1, int s2, int s3)
        //{
        //    int toplam = s1 + s2 + s3;
        //    MessageBox.Show(toplam.ToString());
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            int sonuc = toplamaYap(1, 2, 3);
            this.Text = toplamaYap(53, 27, 20).ToString();
            MessageBox.Show(toplamaYap(45, 45, 10).ToString());
        }

        #endregion
        #region ÖRNEK-2:
        int tekCiftKontrol(int girilenDeger)
        {
            int sonuc;
            if (girilenDeger==0)
            {
                sonuc = 0;
            }
            else if (girilenDeger%2==0)
            {
                sonuc = -1;
            }
            else
            {
                sonuc = 1;
            }
            return sonuc;
        }


        private void btnOrnek2_Click(object sender, EventArgs e)
        {
            //ÖRNEK-2 : Dışarıdan girilen değerin teklik ve çiftlik durumuna bakarak çiftse -1 tekse 1 0'a eşitse 0 olarak geriye değer döndüren bir metot yazınız
            int gelendeger = tekCiftKontrol(Convert.ToInt32(textBox1.Text));
            MessageBox.Show(gelendeger.ToString());
        }
        #endregion
        #region ÖRNEK-3:
        string kelimeGuncelle(string ad, string soyad)
        {
            ad = textBox2.Text.ToUpper().Substring(0, 2) + textBox2.Text.ToLower().Substring(2, ad.Length - 2);
            soyad = textBox3.Text.Replace('a', 'e');
            return (soyad + "@bilgeadam.com");
            return ad;
        }

        private void btnOrnek3_Click(object sender, EventArgs e)
        {
            //Dışarıdan girilen ilk kelimenin ilk İKİ harfini büyük,geri kalanını küçük alınız
            //ikinci kelimenin içerisinde geçen tüm a'ları e ile değiştiriniz ve sonralarına @bilgeadam.com ekleyerek geri döndürünüz

            MessageBox.Show(kelimeGuncelle(textBox2.Text, textBox3.Text));

        }
        #endregion
        #region ÖRNEK-4:
        //Dışarıdan bir int[] dizisini parametre olarak alan bir metot yazınız.
        //Metot , parametredeki dizide yer alan elemanların toplamının karakökünü döndürsün.
        
        
        double KarakokHesapla(int[] dizi)
        {
            double toplam = 0;
            foreach (var item in dizi)
            {
                toplam = toplam + item;
            }
            return Math.Sqrt(toplam); 
            
        }

        private void btnDiziİsleme_Click(object sender, EventArgs e)
        {
            int[] gonderilecek = { 1, 2, 3, 10 };
            MessageBox.Show(KarakokHesapla(gonderilecek).ToString());
        }


        #endregion
        #region ÖRNEK-5:
        //Parametre olarak bir kontrol alan metot yazınız.Bu metot ilgili kontrolün arkaplan rengini(color)geri döndürsün.Daha sonra mettottandan gelen herhangi bir yere atayabilirsiniz.


        Color arkaplanRenk(Control arkaplanıYakalanacakOlanNesne)
        {

            return arkaplanıYakalanacakOlanNesne.BackColor;
           
        }

        private void btnRenkyolla_Click(object sender, EventArgs e)
        {
            this.BackColor = arkaplanRenk(btnRenkyolla);
        }

        #endregion


    }
}
