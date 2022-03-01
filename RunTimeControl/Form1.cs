using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunTimeControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {    
            Random rndrenk = new Random(); // 1.Random renk ürettik
            
            for (int i = 0; i < 2000; i++) // 200 adet picturebox eklemek istediğimiz için for döngüsü
            {
                int a = rndrenk.Next(0, 255); //0 ile 255 arasında değer alır. bu aralıkta random int değerler dönecek.
                int b = rndrenk.Next(0, 255);
                int c = rndrenk.Next(0, 255);
                PictureBox pcb = new PictureBox(); // PictureBox new leyerek oluşturuyoruz.//Aşağıda da özelliklerini girdik.
                pcb.Width = 30;
                pcb.Height = 30;
                pcb.Margin = new Padding(1); //Dış kenar boşluğu
                pcb.BackColor = Color.FromArgb(a, b, c);//Color içinde RGB renkleri için bir formül 3 adet int değeri alıyor.
                flowLayoutPanel1.Controls.Add(pcb); //Flowlayoutpanel içine oluşturduğumuz pcb ları controls olarak ekledik.
            }
        }
    }
}
