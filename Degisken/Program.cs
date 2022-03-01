using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Degisken
{
    class Program
    {
        static void Main(string[] args)
        {

            //Degisken nedir ?
            //Degiskenin en kolay tanımı verilerin anlık depolandığı yerdir. 
            //Değişken içerisindeki veriler saklanabilir ve değişken içerisindeki verilere rahatlıkla program içerisinde istediğin gibi ulaşabilirsiniz

            #region NOTLAR
            //1)Kullanmayacağın değişkeni asla tanımlama
            //2)Değer aralıklarına göre doğru veri tipini seçtiğinden emin ol.
            //3)Değişken yönetimi == Performans yönetimi
            //4)Bir değişken adi asla iki kelimeden oluşmaz.eğer iki kelime veya daha fazla kelimeden oluşacaksa özel bir karakterle bağlanır. örneğin "_"
            //5)Değişken adları asla sayı ile başlamaz.Ancak sayı ile bitebilir.
            //6) \t =>> Metin içerisinde kullanıldığı yerde tab boşluk bırakır.
            //7)Tab boşluk 5 space boşluk bırakır.






            #endregion

            #region DEĞİŞKEN TİPLERİ

            #region RAKAMSAL VERİ TİPLERİ

            //TAM SAYILAR İÇİN;

            //1-Sbyte =>> 8 bit max 127 alır..Minimum olarakda -128 alır
            //sbyte deger = 127;
            //sbyte deger1= -128;

            //2-byte =>> 8 bit min: 0 max: 255
            //byte deger1 =255

            //3-short =>> 16 bit -32768 ile 32767
            //short deger1 = 32767;

            //4-ushort =>> min: 0 max 65535
            //ushort deger2 = 0
            //ushort deger3 = 65535

            //5-int =>> 32 bit dir. -2.147.483.648 ile max 2.147.483.647
            //int maxdeger = 2147483647;
            //int mindeger = -2147483648;

            //6-uint =>> 32 bit. yaklaşık 4.2 milyar.

            //7-long =>> -9223372036854775808, …, 9223372036854775807


            //ONDALIKLI SAYILAR İÇİN;

            //1-FLOAT =>> .'dan sonra 7 haneye kadar destek vermekte. =>> 32 bit
            //float ondalikbir =1.545645F;

            //2-Double =>>.'dan sonra 12-15 hane desteği mevcut =>> 64 bit
            //double ondalikiki=2.5456454;

            //3-decimal =>> .'dan sonra 20- 29 hane desteği =>>128 bit
            //decimal ondalikuc = 3.544654564M;


            #endregion

            #region MANTIKSAL VERİ TİPLERİ
            //1-bool : Doğru ya da yanlış veya evet veya hayır durumu için kullanılır.
            //bool derskaydialindimi = true;
            //bool havayagmurlu = false;
            //bool buyukmu = 10 > 2;

            #endregion

            #region METİNSEL VERİ TİPLERİ
            //string => Üzerinde bir kitap yazacak kadar uzunlukta metin tutmanızı sağlayan veri tipimizdir

            //string bosMetin = "";
            //string uzunMetin = "Bu alana çok uzun metinler bile yazılabilir";

            //string testMetni = "burası ilk satır \nburasıda ikinci satır.";
            //Console.WriteLine(testMetni);




















            #endregion




            #endregion















        }
    }
}
