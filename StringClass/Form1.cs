using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Elinizde var olan sahip olduğunuz metinsel değerleri değiştirmek üzerine etki etme gibi işlemler yapmanıza olanak sağlar.



        }

        private void btnCompareTo_Click(object sender, EventArgs e)
        {
            string OrnekDeger = txtMetinGiris.Text;
            int sonuc =OrnekDeger.CompareTo("bilgeadam");

            string mesaj = "";
            switch (sonuc)
            {
                case -1:
                    mesaj = "Kelime diğer kelime ile eşleşmiyor.Eksik karakterler mevcut.";
                    break;
                case 0:
                    mesaj = "Tebrikler.Eşleşme sağlandı.";
                    break;
                case 1:
                    mesaj = "Kelime diğer kelime eşleşmemektedir.Fazla karakter var.";
                    break;
                default:
                    break;                   
            }
            MessageBox.Show(mesaj);


        }

        private void btnContains_Click(object sender, EventArgs e)
        {
            string test =txtContains.Text;
            bool varMi =test.Contains("adam");

            MessageBox.Show("Aradığınız değer" + (varMi ? "Bulunmaktadır" : "Bulunmamaktadır"));
        }

        private void btnStartsWith_Click(object sender, EventArgs e)
        {
            //StartsWith => Kelimenizin parametrede gönderdiğiniz değerle başlayıp başlamadığını size bool olarak döndürür.

            string test1=txtStartsWith.Text;
            bool sonuc = test1.StartsWith("bil");
                MessageBox.Show(sonuc ? "kelime \"bil\" ile başlamaktadır.":"Kelime \"bil\"ile başlamamaktadır.");


        }

        private void btnEndWith_Click(object sender, EventArgs e)
        {
            string test1 = txtStartsWith.Text;
            MessageBox.Show(test1.EndsWith("dam")? "Kelime \"dam\" ile bitmektedir." : "Kelime \"dam\" ile bitmemektedir. ");


        }

        private void btnIndexOf_Click(object sender, EventArgs e)
        {
            //IndexOf=> Dizilerde gördüğünüz metodun aynı prensibleriyle çalışmaktadır..
            //Eğer harf varsa harfin indexini yoksa -1 değerini , harf birden fazla ise ilk harfin indexini döndürür..

            string test =txtIndexOf.Text;
            int index = test.IndexOf('g');
            MessageBox.Show(index.ToString());
        }

        private void btnLastIndexOf_Click(object sender, EventArgs e)
        {
            string test = txtLastIndexOf.Text;
            int index = test.LastIndexOf('g');
            MessageBox.Show(index.ToString());
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //Not : Bir string üzerinde yaptığınız değişiklikler o string'i değiştirmez, size yeni bir kopyasını verir.
            //Remove => (1.Kullanım : )=> Verdiğiniz index numarası dahil , o index'deki tüm karakterleri ortadan kaldıracaktır.
            //Remove=>> (2.Kullanım : )=> Verdiğiniz index numarası dahil 2.parametresinde göndermiş olduğunuz değer kadar eleman siler.

            //Birinci kullanım:
            string metin = txtRemove.Text;
            metin = metin.Remove(5);

            //İkinci kullanım:
            metin = metin.Remove(3, 2);
            MessageBox.Show(metin);


        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            //Replace = > Metninizi içerisindeki bir karakteri ya da bir bölümü yeni bir karkter - bölüm ile değiştirmesine olanak sağlar.

            string ornekMetin = txtReplace.Text;
            ornekMetin=ornekMetin.Replace("adam", "kadın");
            MessageBox.Show(ornekMetin);
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {

            //Split => Metinizinde özel bir karakter birden fazla parçaya ayırmaya olanak sğalayan metottur..
            //Aynı zamanda birden fazla özel karakterde verirsiniz.

            string mailAdresleri = txtSplit.Text;
            //sakivatansever@gmail.com ,umit.vatansever@bilgeadam.com,
            string[] adresler = mailAdresleri.Split(';', ',');
            foreach (var item in adresler)
            {
                MessageBox.Show(item);
            }        
                
        }

        private void btnSubString_Click(object sender, EventArgs e)
        {
            //Substring 
            //[1.Kullanımı] : Metninziden parametre gönderdiğinizde indexden başlayarak , geriye kalan tüm kısmı çekip almanıza yardımcı olacaktır..

            //[2.Kullanımı] : Metninizdeki,ilk parametrede verdiğiniz indexden başlayıp , ikinci parametredeki verdiğiniz değerin uzunluğu kadar alıp size döndürür.

            string metin = txtSubstring.Text;
            metin = metin.Substring(5, 1); //2.kullanım
            MessageBox.Show(metin);
        }

        private void btnLowwerUpper_Click(object sender, EventArgs e)
        {
            //ToLower => ilgili metnin tamamını küçük yapar;
            //ToUpper => ilgili metnin tamamını büyük yapar;
            this.Text = txtToLowerUpper.Text.ToLower();
            this.Text = txtToLowerUpper.Text.ToUpper();

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            //INSERT: Metinsel bir değerin herhangi bir pozisyonuna (index) yeni bir değeri iliştirmek isterseniz bu metodu kullanabilirsiniz.

            string deger = txtInsert.Text;
            deger = deger.Insert(5, "asd");
            MessageBox.Show(deger);
        }

        private void btnCharArray_Click(object sender, EventArgs e)
        {
            //Stringlerinizi charlarına ayırarak size char[] olarak teslim eder.
            string testMetni = txtCharArray.Text;
            char[] karakterler = testMetni.ToCharArray();
            //Örnek: Dışardan girilen metnin her bir karakterinin ascii değerleri toplamı nedir?
            int toplam = 0;
            for (int i = 0; i < karakterler.Length;i++)
            {
                toplam += karakterler[i];
            }
            MessageBox.Show("Toplam değer: " + toplam);
            
        }

        private void btnTrim_Click(object sender, EventArgs e)
        {
            //Trim =>> Metninizin sağından ya da solundan boşlukları temizlemesinde olanak sağlayan metottur.
            string test = txtTrim.Text;
            test = test.Trim();
            string test1 = txtTrim.Text;
            MessageBox.Show(string.Format("Boşluklarla hesaplanan karakter sayısı {0}\n boşluklar temizlenip hesaplanank karakter sayısı {1}",test.Length,test.Length));
        }
    }
}
