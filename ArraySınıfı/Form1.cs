using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArraySınıfı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] ornekDizi = { "İstanbul", "Ankara", "İzmir", "Antalya", "Eskişehir", "Samsun", "Bursa", "Konya"};
        
        private void btnORNEK1_Click(object sender, EventArgs e)
        {
            //Array.Clear(); =>> Diziden eleman silmek için kullanılan metottur.

            //Yapısı : Array.Clear(ornekDizi,2,3);
            //1.Parametre kaynakdizi
            //2.Parametre başlangıç index değerini alır.
            //3.Parametre silinecek eleman sayısını alır.

            //ÖRNEK-1 :Dizinin tamamınnın silinmesini istiyorsak :
            //------------------------------------------------------
            //Array.Clear(ornekDizi, 0, ornekDizi.Length);
           
        }

        private void btnCOPY_Click(object sender, EventArgs e)
        {
            string[] yeniSehirler = new string[5];

            Array.Copy(ornekDizi, yeniSehirler, 5);
            //Yapısı:
            //1.Parametre kaynak dizi
            //2.Parmetre hedef dizi
            //3.Parametre kaynak diziden hedef diziye kaç eleman kopyalayacak


            //Diğer kullanım :
            Array.Copy(ornekDizi, 3, yeniSehirler, 1, 1);
            //1.Parametre kaynak dizi
            //2.Source index : kaynak dizide kopyalamaya kaçıncı indexden başlanacağı
            //3.Parmetre hedef dizi
            //4.hedef dizinin kaçıncı değerinden eklemeye başlayacak
            //5.parametre hedef dizi kaç eleman kopyalayacak

        }

        private void btnIndexOf_Click(object sender, EventArgs e)
        {
            //Array Indexof():
            //Dizide aradığınız elemanın index numarasını döndüren metotdur.
            //Eğer aradığınız değer dizi içerisinde mevcut değilse size -1 döner.

            int gelenIndexNo=Array.IndexOf(ornekDizi,textBox1.Text);
            //İLK KULLANIM YAPISI:
            //-----------------------------
            //1.Parametre kaynak dizi
            //2.Parametre aranılacak nesne(object tipinde olduğu için veri ister dizinin tipinde ister o tipde olmasada farklı tipte olması farketmeyecektir.           

            //Aranan eleman dizide yer almamaktadır. Eleman index değeri gösteriniz.
            int bulunanindex = Array.IndexOf(ornekDizi, textBox1.Text);
            if (bulunanindex==-1)
            {
                MessageBox.Show("Aranan eleman dizide bulunmamaktadır.");
            }

            bulunanindex = Array.IndexOf(ornekDizi, textBox1.Text, 5);
            //İKİNCİ KULLANIM YAPISI
            //-----------------------------
            //1.Parametre kaynak dizi
            //2.Parametre aranılacak nesne(object tipinde olduğu için veri ister dizinin tipinde ister o tipde olmasada farklı tipte olması farketmeyecektir.
            //3.Parametrede aramaya kaçıncı index'den başlayacağı söylenir.


            bulunanindex = Array.IndexOf(ornekDizi, textBox1.Text, 5,2);
            //ÜÇÜNCÜ KULLANIM YAPISI
            //-----------------------------
            //1.Parametre kaynak dizi
            //2.Parametre aranılacak nesne(object tipinde olduğu için veri ister dizinin tipinde ister o tipde olmasada farklı tipte olması farketmeyecektir.
            //3.Parametrede aramaya kaçıncı index'den başlayacağı söylenir.
            //4.Parametre başlanılacak index değerinin sonraki kaç eleman içerisinde arama yapılmalıdır.

        }

        private void btnLastIndexOf_Click(object sender, EventArgs e)
        {
            //Array.lastindexof() =>> Dizide indexlemede bir değişiklik yoktur.Sadece sondan bakmaya başlar.Bulduğu andan indexi döndürür ve metot görevini tamamlar.

            //SORU : Bir dizide bir elemanın birden fazla olup olmama durumunu kontrol ediniz
            int AranılacakDeger = Array.IndexOf(ornekDizi, "Ankara");
            int ikinciaranılanindex = Array.LastIndexOf(ornekDizi, "Ankara");

            if (AranılacakDeger==ikinciaranılanindex)
            {
                this.Text = "Bu dizide aradığınız elemandan bir adet vardır. ";
            }
            else
            {
                this.Text = "Bu dizide aradığınız elemandan birden fazla defa geçmektedir.";
            }

        }

        private void btnResize_Click(object sender, EventArgs e)
        {
            Array.Resize<string>(ref ornekDizi, 23);
            //İlke dizinin eleman sayısını arttırmak - azaltmak için kullanılan bir metottur.
            //Birinci kullanım ile ikinci kullanım arasındaki fark , sizden öncelikle bir dizi tipi istemesi ve daha sonra sadece o tipdeki dizileri resize edebilme kabiliyetine kavuşmasıdır.

            Array.Resize(ref ornekDizi, 50);

            Array.Resize<string>(ref ornekDizi, 80);

        }

        private void btnSORT_Click(object sender, EventArgs e)
        {

            //SORT :Elemanların yerlerini değiştirdiği için indexlerde değişecektir.
            //Sıralama a'dan z'ye ve küçükten büyüğe gerçekleşir...


            //1.OVERLOAD =>>> Array.Sort(ornekDizi); 


            //5.OVERLOAD =>>> 
            //-----------------
            //1.Parametre kaynak dizi
            //2.Parametre başlangıç index
            //3.Parametre başlangıç index değerinden sonra kaç elaman sıralacak

            Array.Sort(ornekDizi, 4, 2);









        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            //REVERSE : 
            //--------------------------
            //Diziyi tersine çevrilmesine sağlayan hazır metottur.Kesinlikle sıralama yapmaz.

            //1.YOL
            //------------------------
            Array.Reverse(ornekDizi);


            //2.YOL
            //------------------------
            //1.Parametre kaynakDizi
            //2.Parametre başlangıç index değeri
            //3.Parametre başlangıç değerinden sonra kaç eleman tersine çevirecek.

            Array.Reverse(ornekDizi, 5, 4);
            
        }

        }



        //ARRAY SINIFI :
        //------------------------------
        //Şu ana dek görmüş olduğumuz ilkel diziler , bize üzerinde çok fazla işlem yapma olanağı sağlamaktadır.
        //Eğer dizinin yeniden boyutlandırmak,temizlemek,sıralamak,ters çevirmek gibi temel işlemleri yapmak isterseniz array sınıfını kullanmalısınız.








    }
}
