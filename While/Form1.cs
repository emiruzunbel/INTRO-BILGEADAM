using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace While
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOrnek1_Click(object sender, EventArgs e)
        {
            //bool sonuc = false;
            //while (!sonuc)
            //{                
            //    listBox1.Items.Add('a');
            //}

            int i = 0;
            while (i<100)
            {
                listBox1.Items.Add(i);
                i++;
            }




        }

        private void btnOrnek2_Click(object sender, EventArgs e)
        {
            //ÖRNEK-2 : Form üzerinde yer alan tüm button genişliklerini 100 px olarak ayarlayalım ve yukarıya doğru olan uzaklıklarını 20 px arttıralım. //TOP VE Width

            int i = 0;  
            while (i<this.Controls.Count)
            {
                if (this.Controls[i] is Button)
                {
                    this.Controls[i].Width = 100;
                    this.Controls[i].Top += 20;
                }
                i++;
            }

            for (int index = 0; index < this.Controls.Count; index++)
            {
                if (this.Controls[i] is Button)
                {
                    this.Controls[i].Width = 100;
                    this.Controls[i].Top += 20;
                }
                
            }




        }
        //While:
        //------------------------------------
        //1- For döngüsü ile yapabildiğiniz her şeyi rahatlıkla yapabilirsiniz.
        //2- For döngüsünden farklı olarak ,metotlardan gelen cevaplara gelen işlem yapabilme yeteneğine sahip olmasıdır.
        //Örnek =>> Ado.net 
    }
}
