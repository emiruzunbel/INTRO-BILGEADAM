using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayList1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //ArrayList nedir ??
        //-------------------------------
        //Şu zamana denk gördüğümüz ilkel kötü dizileri unutalım. (veritipi[] olarak tanımlananlar) en büyük özelliği : 
        //Tip bağımlılığı eleman sayısının zorunluğu idi
        //Ancak arraylist nesnesi ile birliklte bu bağımlılık ortadan kalkar.
        //Bir arraylist oluştururken ne bir değer aralığı vermek zorundasınız ne de bir tip belirtmek zorundasınız.
        //Boyut belirtebiliriz.
        // ArrayList yeniDizi = new ArrayList(4);

        //Dezavantajları nelerdir ??
        //-------------------------------
        //ArrayList içerisindeki elemanları otomatik olarak object veri tipinde döndürme özelliğine sahiptir.
        //Dolayısı ile bu verileri geri almak istediğinizde mecburen bir "cast" ya da "convert" işlemine gerek duyulur.
        //Bu da ekstra iş yapıyor olmak demektir.(objecto =>> int ,string gibi bu işleme unboxing denir)
        //Arraylist'i kullanabilmek için namespace 'lere using system.collections; ibaresi eklenmelidir.




        ArrayList ary = new ArrayList();

        private void button1_Click(object sender, EventArgs e)
        {

            //ary.Add(5);//İnt
            //ary.Add("5"); //string
            //ary.Add(new DateTime()); // meto
            //ary.Add(new Form()); //form classını oluşturdu
            //ary.Add(true); //bool

            //Form x = new Form();
            //x.Text = "Test";
            //Eğer bir nesnenin heap alanına direk ulaşmaya çalışırsanız ulaşamazsınız.Bu alana ulaşmak için bir tane referans tutucuya ihtiyacınız olacaktır.

            ary.Add("İstanbul");
            ary.Add("Ankara");
            ary.Add("İzmir");
            ary.Add("Manisa");
            ary.Add("Aydın");
            ary.Add("Antalya");
            ary.Add("Alanya");
            ary.Add("İstanbul");
            ary.Add("Gaziantep");
        }

        private void btnMetotlar_Click(object sender, EventArgs e)
        {
            //this.Text = (string)ary[0];

            //Form fr = (Form)ary[3];
            //MessageBox.Show(fr.Text);

            //Dizinin eleman sayısına nasıl ulaşırız ??
            this.Text = ary.Count.ToString();

            //Dizideki elemanın indexini nasıl alırız ??
            this.Text = ary.IndexOf("İzmir").ToString() ;

            this.Text = ary.LastIndexOf("İzmir").ToString();

            //Araya eleman ekleme
            ary.Insert(3, "Malatya");

            //İstenilen değeri silme
            ary.RemoveAt(3);
            ary.Remove("Antalya");

            //Sıralama
            ary.Sort();

            //Ters çevirme
            ary.Reverse();

            // Kapasiteyi o anki eleman sayısına eşitleme
            ary.TrimToSize();

            //dizi temizleme
            ary.Clear();

        }
    }
}
