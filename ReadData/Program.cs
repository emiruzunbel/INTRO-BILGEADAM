using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadData
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen adınızı ve soyadınızı giriniz");

            string adsoyad = Console.ReadLine();
            Console.WriteLine("Hoşgeldin " +  adsoyad + " " +
                "\n Çıkmak için bir tuşa basınız");

            //Dışarıdan değer alınması istendiğinde console sınıfının readline metodunu getireceksiniz.
            //Alt satıra geçmek için \n kullanılır.


    
            Console.ReadKey();


        }
    }
}
