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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //Arrray -Dizi :
        //-----------------------
        //Birden fazla değeri tek bir değişkende tutmanız zordur. Dizi tipi tanımlayarak aynı değişken tipindeki verileri kullanarak dizini tipi belirlenir.

        //NOT: Eğer : Index was outside the bounds of the array hatasını alıyorsak dizinin boyutlarını aşacak şekilde eleman eklemeye çalışıyoruzdur.

        
        private void button1_Click(object sender, EventArgs e)
        {
            //DİZİ TANIMLAMA YOLU 1 : 
            //------------------------

            int[] dizi = new int[3];
            dizi[0] = 1;
            dizi[1] = 2;
            dizi[2] = 3;
            //dizi[3]=1 ; ==>> dizimiz 3 elemanlı olduğundan burada hata verir.

            //DİZİ TANIMLAMA YOLU 2 : 
            //------------------------
            string[] sehirler = new string[4]
            {
                "İzmir","İstanbul","Ankara","Muğla"
            };
            this.Text = sehirler[2];

            //DİZİ TANIMLAMA YOLU 3 : 
            //------------------------
            //Veritipi [] diziAdı ={Dizi elemanları};
            char[] karakterler = { 'a', 'b', 'c', 'd', 'e' };
            
        }











    }
}
