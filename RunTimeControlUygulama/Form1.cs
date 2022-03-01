using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunTimeControlUygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //1- random için nesne oluşturdum
        Random rnd = new Random(); 
        private void Form1_Load(object sender, EventArgs e)
        {
            List<int> mayinlar = new List<int>(); //2- int tipinde liste oluşturdum.

            //3-Oluşturduğumuz nesneler içinde toplamda 20 adet mayın belirleyelim.
            //Rastgele belirlenen 20 sayısı , oluşan numaralara göre pcb lere atayalım

            for (int i = 0; i < 20; i++)
            {
                int mayin = rnd.Next(0, 170);
                if (!mayinlar.Contains(mayin))
                {
                    mayinlar.Add(mayin);
                }
                else
                {
                    i--;
                }
            }

            // istediğimiz adet kadar pcb oluşturalım ve özelliklerini belirleyelim. genişlik boy isim renk gibii gibi....
            for (int i = 0; i < 170; i++)
            {
                PictureBox pcb = new PictureBox();
                flowLayoutPanel1.Controls.Add(pcb);
                pcb.Name = "pcb" + i; // Oluşan pcb için her birine farklı isimler atamış olduk pcb1 pcb2 gibi
                pcb.Width = 30;
                pcb.Height = 30;
                pcb.Margin = new Padding(1);
                pcb.BackColor=Color.FromArgb(rnd.Next(0,256), rnd.Next(0, 256), rnd.Next(0, 256));



                //İ'nin o anki değeri mayınlar listesinde yer alıyor ise , bir durum bildirmemiz gerekiyor.
                if (mayinlar.Contains(i))
                {
                    pcb.Tag = true;
                }
                else
                {
                    pcb.Tag = false;
                }


                pcb.Click += Pcb_Click;
                flowLayoutPanel1.Controls.Add(pcb);

            }
            timer1.Start();
        }

        private void Pcb_Click(object sender, EventArgs e)
        {
            PictureBox pcb=(PictureBox)sender;
            Color background = pcb.BackColor;
            if ((bool)pcb.Tag)
            {
                timer1.Stop();
                foreach (var item in flowLayoutPanel1.Controls)
                {
                    pcb = (PictureBox)item;
                    pcb.BackColor = background;
                }
                MessageBox.Show("Mayın");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (var item in flowLayoutPanel1.Controls)
            {
                //Panel içerisinde sadece picturebox yer aldığından dolayı,kontrol etmenizede gerek yoktur.

                PictureBox pc = (PictureBox)item;
                pc.BackColor = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
            }
        }
    }
}
