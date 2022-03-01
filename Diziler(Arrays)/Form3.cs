using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diziler_Arrays_
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        string[] sehirler = {"Ankara","İzmir","Antalya","Eskişehir","Bursa","Aydın","Manisa","Trabzon","Samsun" };



        private void btnORNEK1_Click(object sender, EventArgs e)
        {
            //İlgili dizi içerisindeki her bir elemanı size "sehir" takma adı ile verir . Ve döngünün her bir adımında size dizinin bir elemanını teslim edecektir.

            foreach (var sehir in sehirler)
            {

                //Sehir diye adlandırdığımız değişken , döngünün devam edebilmesi için yardımcı bir araçtır.
                //Herhangi bir değeri yoktur.

                listBox1.Items.Add(sehir);
            }
        }

        private void btnORNEK2_Click(object sender, EventArgs e)
        {
            //ÖRNEK-2 : İkiye bölünenleri listbox1'e bölünmeyenleri listbox2'ye atın.Hem ikiye hem üçe bölünenlerin kaç tane olduğunu mbox ile gösterelim

            int[] dizi = { 125, 65, 215, 887, 76, 54, 4523, 23, 77, 734, 83, 45, 190 };
            int sayac=0;

            foreach (var Sayi in dizi)
            {
                if (Sayi%2==0 && Sayi%3==0)
                {
                    sayac++;                    
                }
                if (Sayi % 2 == 0)
                {
                    listBox1.Items.Add(Sayi);
                }
                else
                {
                    listBox2.Items.Add(Sayi);
                }                
            }
            MessageBox.Show($"Bu dizide hem ikiye hem üçe tam bölünen toplam {sayac} sayi vardır.");




        }

        private void btnORNEK3_Click(object sender, EventArgs e)
        {
            //örnek 3: Listboxd1deki seçili tüm elemanları (Birden fazla seçme şansım var ) listbox2 ye ekleyelim.


            foreach (var item in listBox1.SelectedItems)
            { 
                if (!listBox2.Items.Contains(item))
                {
                    listBox2.Items.Add(item);
                }
            }


            





        }

        private void btnOrnek4_Click(object sender, EventArgs e)
        {
            //Form üzerindeki tüm buttonların arkaplan ve yazı rengini değiştiriniz

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button)
                {
                    ctrl.BackColor = Color.Maroon;
                    ctrl.ForeColor = Color.Orange;
                }
            }
            

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        //Foreach:
        //-------------------
        //Kesinlikle index mantığı yoktur.
        //Tip bağımlı döngülerdir.
        //Çoğu zaman elimizdeki bir koleksiyonun her bir elemanını tek tek ele almak için kullanılır.
    }
}
