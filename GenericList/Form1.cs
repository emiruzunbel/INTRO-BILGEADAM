using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenericList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
                        
        }

        private void btnORNEK1_Click(object sender, EventArgs e)
        {


            List<int> sayilar = new List<int>();
            sayilar.Add(1);
            sayilar.Add(2);
            sayilar.Add(3);
            sayilar.Add(4);
            sayilar.Add(5);
            sayilar.Add(6);
        }

        private void btnOrnek2_Click(object sender, EventArgs e)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("ANKARA");
            sehirler.Add("İzmir");
            sehirler.Add("Antalya");
            sehirler.Add("İstanbul");
            sehirler.Add("Muğla");
            sehirler.Add("Trabzon");
            sehirler.Add("Samsun");

            foreach (string sehir in sehirler)
            {
                MessageBox.Show(sehir);
            }




        }

        private void btnOrnek3_Click(object sender, EventArgs e)
        {
            List<string> sehirler = new List <string>();
            sehirler.Add("ANKARA");
            sehirler.Add("İzmir");
            sehirler.Add("Antalya");
            sehirler.Add("İstanbul");
            sehirler.Add("Muğla");
            sehirler.Add("Trabzon");
            sehirler.Add("Samsun");

            //Dizinin elemanlarını küçükten büyüğe , a'dan z'ye sıralar.
            sehirler.Sort();

            sehirler.ForEach(x => MessageBox.Show(x));
            
        }

        private void btnORNEK4_Click(object sender, EventArgs e)
        {

            //ÖRNEK : Eğer liste içerisinde yer alıyor ise edirne yer almaktadır diye mesaj versin yok almıyorsa istediğiniz şehir bulunamadı desin.


            List<string> sehirler = new List<string>();
            sehirler.Add("ANKARA");
            sehirler.Add("İzmir");
            sehirler.Add("Antalya");
            sehirler.Add("İstanbul");
            sehirler.Add("Muğla");
            sehirler.Add("Trabzon");
            sehirler.Add("Samsun");
            
            //1.yol:
            //--------
            if (sehirler.Contains("Edirne"))
            {
                MessageBox.Show("Edirne listede yer almaktadır");
            }
            else 
            {
                MessageBox.Show("İstediğiniz şehir bulunamadı");
            }

            //2.yol:
            //-------
            //MessageBox.Show(sehirler.Contains("Edirne") ? "şehirler dizisi içerisinde edirne ile yer almaktadır" : "İstediğiniz şehir listede yer almamaktadır");
        }

        private void btnSORU1_Click(object sender, EventArgs e)
        {
            //SORU-1: İçeriğine sizin karar vereceğiniz bir sayisal dizi oluşturunuz. Ve bu dizinin en küçük ve en büyük elemanlarını bulup messageBox'da gösteriniz

            int[] sayilar = { 435, 63, 74, 853, 36, 86, 97, 3, 5, 7, 8, 567, 234, 976, 34 };
            //MessageBox.Show("Minumum sayı: " + " "+sayilar.Min()+ "Maksimum sayı "+" "+ sayilar.Max());
            Array.Sort(sayilar);
            int enkucuk = sayilar[0];
            int enbuyuk = sayilar[sayilar.Length - 1];
            MessageBox.Show("En küçük = " + " " + enkucuk + " " + "En büyük =" + " " + enbuyuk);
        }

        string[] kayit = new string[0];
        int index = 0;
        private void btnSORU2_Click(object sender, EventArgs e)
        {
            //SORU 2:Textbox'dan girilen veri kayıtlar listesine eklensin her yeni kayıt dizininin sınırlarını değiştirsin
            //Elemanlar eklendikten sonra listBox'da gösteriniz
            //Format : => Eleman - Elemanindex

            Array.Resize(ref kayit, kayit.Length + 1);
            kayit[index] = textBox1.Text;
            listBox1.Items.Add(string.Format("{0}. eleman => {1}", index, kayit[index]));

            index++;

            





        }

        //GenericList
        //-------------------------------------
        //List<> içerisinde <T> verilen tipe bürünerek , o tipte bir koleksiyon oluşturmamıza olanak sağlayan dizi(koleksiyon) çeşididir.
        //Daha önceki diziler gibi boyut arttırma işlemine gerek duymadan ekleyebileceğimiz ve array sınıfını kullanmamıza gerek kalmadan üzerinden işlem yapabileceğimiz , gelişmiş bir sınıftır.

        //OLUŞTURMAK :
        //List<int> sayilar = new List<int>();









    }
}
