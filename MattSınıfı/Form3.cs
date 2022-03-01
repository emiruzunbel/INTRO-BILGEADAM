using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MattSınıfı
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnTimer_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled==false)
            {
                timer1.Start();
            }
            else
            {
                timer1.Stop();
            }
        }
        Random rnd = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            int index =rnd.Next(0, imgList.Images.Count);
            pcbResim.Image=imgList.Images[index];


            //Anlık olarak index değeri tag propu üzerinde tutuyorum.nedeni bu kısımda nesnenin kendisini taşıyacağım için bir yanlışlık olma ihtimalini kaldırıyorum.

            pcbResim.Tag = index;
        }

        private void btnPrevius_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            int index = Convert.ToInt32(pcbResim.Tag);

            index--;
            if (index<0)
            {
                index=imgList.Images.Count - 1;
            }
            else
            {
                pcbResim.Image=imgList.Images[index];
            }
            pcbResim.Tag = index;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            timer1.Stop();
            pcbResim.Image=imgList.Images[imgList.Images.Count - 1];
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            pcbResim.Image = imgList.Images[0];
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            int index = (int)pcbResim.Tag;
            index++;
            if (index<imgList.Images.Count)
            {
                pcbResim.Image = imgList.Images[index];
            }
            else
            {
                index = 0;
                pcbResim.Image = imgList.Images[0];
            }
            pcbResim.Tag = index;
        }
    }
}
