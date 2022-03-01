using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calisma1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Random 20 sayıdan ortalamanın altında ve üstünde kalanları bulunuz

            int[] dizi = new int[20];
            Random rastgele = new Random();
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rastgele.Next(100);
                Console.WriteLine(dizi[i]);
            }
            int ortalama = 0;
            for (int i = 0; i < dizi.Length; i++)
            {
                ortalama +=dizi[i];
            }
            ortalama =ortalama / 20;

            int büyüksayiAdet = 0;
            int kücüksayiAdet = 0;
            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i]>ortalama)
                {
                    büyüksayiAdet++;
                }
                else
                {
                    kücüksayiAdet++;
                }                
            }
            Console.WriteLine("Ortalamanın üstünde : " + büyüksayiAdet + "sayi");
            Console.WriteLine("Ortalamanın üstünde : " + kücüksayiAdet + "sayi");














            Console.ReadLine();
        }
        
    }
}
