using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutRefKeywordu
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        #region OUT ANAHTAR KELİMESİ
        //Out Anahtar Kelimesi:
        //---------------------------------------------------------------------------
        //Bir metot içerisinde dışarıya birden fazla değer döndürmek isteyebilirsiniz.
        //"return" anahtar kelimesi fonksiyonlarda size yetmeyecektir.
        //Void metotlar ise zate geriye değer döndürmezler
        //Bu yüzden birden fazla değer döndürmek için kullandığıımız anahtar kelime Out anahtar kelimesidir.


        #region OUT ORNEK-1
        //Üst alma örneği. tek değer geri dönüyor.
        void geriyeDegerDonen(int sayi, out double firlatilansonuc)
        {
            firlatilansonuc = Math.Pow(sayi, 2);
        }

        private void btnOut1_Click(object sender, EventArgs e)
        {
            double yakalanansonuc;
            geriyeDegerDonen(12, out yakalanansonuc);
            MessageBox.Show(yakalanansonuc.ToString());
        }
        #endregion

        #region OUT ORNEK-2
        //Sizden geriye değer dönmeyen bir hesapla metodu yazmanızı istiyorum

        void hesapla(int sayi1, int sayi2, out int toplam, out int fark, out int carpim, out double bolum, out double modd)
        {
            toplam = sayi1 + sayi2;
            fark = sayi1 - sayi2;
            carpim = sayi1 * sayi2;
            bolum = sayi1 / sayi2;
            modd = sayi1 % sayi2;
        }

        private void btnOut2_Click(object sender, EventArgs e)
        {
            int toplamsonuc;
            int farksonuc;
            int carpimsonuc;
            double bolumsonuc;
            double modsonuc;
            hesapla(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), out toplamsonuc, out farksonuc, out carpimsonuc, out bolumsonuc, out modsonuc);
            textBox3.Text = Convert.ToString(toplamsonuc);
            textBox4.Text = Convert.ToString(farksonuc);
            textBox5.Text = Convert.ToString(carpimsonuc);
            textBox6.Text = Convert.ToString(bolumsonuc);
            textBox7.Text = Convert.ToString(modsonuc);
        }


        #endregion

        #region OUT ORNEK-3
        void ListBoxElemanTemizle(ListBox hangiListBox, out int kacElemanSilindi)
        {
            kacElemanSilindi = hangiListBox.Items.Count;
            listBox1.Items.Clear();
        }
        private void btnOut3_Click(object sender, EventArgs e)
        {
            int silinenEleman;
            ListBoxElemanTemizle(listBox1, out silinenEleman);
            MessageBox.Show("Listbox'dan toplam " + " " + silinenEleman + " " + "eleman silinmiştir.");

        }
        #endregion

        #endregion

        #region PARAMS ANAHTAR KELİMESİ
        //Dışardan metotda kaç parametre geleceği bilinmemektedir.
        //Ancak gelecek olan tüm parametrelerle bir takım işler yapmak zorundasınız..
        //Bu sayısız parametre tutma yolu params anahtar kelimesinden geçer.
        //Params sizden bir dizi ister...


        double FiyatlariHesapla(params double[] fiyatlar)
        {
            double toplamTuar = 0;
            foreach (double item in fiyatlar)
            {
                toplamTuar += item;
            }
            return toplamTuar;
        }

        private void btnPARAMS_Click(object sender, EventArgs e)
        {
            FiyatlariHesapla(534, 363, 7, 63, 73, 86, 2342, 975, 235432, 79);
        }

        #endregion

        #region REF ANAHTAR KELİMESİ
        //REF Anahtar Kelimesi
        //---------------------
        //Ref parametre niteleyicisi c#'ın "değer olarak çağrı " yerine " referans olarak çağrı oluşturmasını sağlar.
        //Ref kullanarak void tipli metotlardan değer alabilirsiniz..Üstelik bu değeri alabilmek için yeni bir değişken atamanıza gerek yoktur.
        //Ref, metoda parametre olarak soktuğunuz , elinizde varolan değişkenin değerini değiştirebilir.

        //arrays,classlar,list,string referans tiplerdir.


        void MailListeliyicisi(ref string[] HangiDiziyeEklensin,string verilerNeredenGelecek)
        {
            string[] gelendegerler = verilerNeredenGelecek.Split(';');
            for (int i = 0; i < gelendegerler.Length; i++)
            {
                Array.Resize<string>(ref HangiDiziyeEklensin, HangiDiziyeEklensin.Length + 1);
                HangiDiziyeEklensin[i]= gelendegerler[i];
            }
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            string[] elemanlar = new string[0];
            MailListeliyicisi(ref elemanlar, textBox8.Text);

            foreach (var item in elemanlar)
            {
                listBox2.Items.Add(item);
            }
        }

        #region RECURSIVE
        //Bir fonksiyonun içine yine kendisinden bir parça bulunuyorsa bu fonksiyonlar yine özyineli (Recursive) fonksiyon denir.
        //Metot içerisinde kendisinin tekrar çağırma işlemi

        #region FAKTÖRİYEL NORMAL ÇÖZÜM
        
        private int Faktöriyel (int sayi)
        {
            int fak=1;
            for (int i=sayi; i >=1; i--)
            {
                fak = fak * i;
            }
            return fak;
        }
        private void btnRecursive_Click(object sender, EventArgs e)
        {
            int result = Faktöriyel(5);
            MessageBox.Show("İşlemin sonucu: " + result);
        }

        #endregion

        #region ÖRNEK-1 REVURSIVE 

        private int Fakt_Recu(int sayi)
        {
            if (sayi==0)
            {
                return 1;
            }
            else
            {
               return sayi * (Fakt_Recu(sayi - 1));
            }
        }


        private void btnRecursive1_Click(object sender, EventArgs e)
        {
            int result = Fakt_Recu(5);
            MessageBox.Show("İşlem sonucu : " + result);
        }

        #endregion

        #region TEMİZLEME NORMAL ÇÖZÜM
        void clean(Control.ControlCollection cls)
        {
            foreach (Control item in cls)
            {
                if (item  is TextBox)
                {
                    item.Text = " ";
                }
            }
        }


        private void btnORNEK3_Click(object sender, EventArgs e)
        {
            clean(this.Controls);
        }
        #endregion

        #region ÖRNEK-2 RECURSIVE
        void Temizle(Control.ControlCollection ctrl)
        {
            foreach (Control item in ctrl)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Clear();
                }
                else if (item is GroupBox)
                {
                    GroupBox grn = (GroupBox)item;
                    Temizle(grn.Controls);
                }
            }
        }

        private void btnORNEK4_Click(object sender, EventArgs e)
        {



        }


        #endregion

        #endregion
    }







}