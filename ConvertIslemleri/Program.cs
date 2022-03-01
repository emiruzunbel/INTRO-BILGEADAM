using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertIslemleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //Birveri tipindeki değişkeni , diğer bir veri tipine çevirmek için ihtiyacımız olan yardımcı bir sınıf vardır.Bu sınıf Convert sınıfıdır.
            //Burada ekstra bir durum daha söz konusu olabilir. Dış dünyadan gösterilecek olan ne varsa, bu değerler kesinlikle metinsel - string veri tipi olacaktır...Dolayısıylaa .net bize tipler arası geçişte kolaylık sağlar.

            int sayi = 23;
            Console.WriteLine(sayi.ToString());
                        
            sayi++;
            Console.WriteLine(sayi);           
           


            string cevirilecekDeger = "123";
            int cevrilmisDeger = Convert.ToInt32(cevirilecekDeger);
            byte cevrilendegeriki = Convert.ToByte(cevirilecekDeger);
            short cevrilmisdegeruc = Convert.ToInt16(cevirilecekDeger);
            long cevrilmisdegerDort = Convert.ToInt64(cevirilecekDeger);
            float cevrilmisdegerBes = Convert.ToSingle(cevirilecekDeger);


            bool sonuc = true;
            Console.WriteLine(sonuc.ToString());


            Console.ReadLine();
        }
    }
}
