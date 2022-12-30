using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_SwapCase
{
    internal class Program
    {
        // Girilen metni istenilen hale getiren metot
        public static string SwapCase(string veri)
        {
            string sonuc = "";
            for (int i = 0; i < veri.Length; i++)
            {
                if (char.IsUpper(veri[i]))
                {
                    sonuc += veri[i].ToString().ToLower();
                }
                else
                {
                    sonuc += veri[i].ToString().ToUpper();
                }
            }
            return sonuc;
        }

        static void Main(string[] args)
        {
            // Girilen bir metnin içerisindeki harfler büyük harf ise küçük harf; küçük harf ise büyük harf yapan program
            // Örnek Girdi: SwapCase("Merhaba Dünya")
            //       Çıktı: mERHABA dÜNYA
            // Örnek Girdi: SwapCase("EmirhaN CİNCİ")
            //       Çıktı: eMİRHAn cinci

            Console.Write("Lütfen bir ifade giriniz: ");
            string veri = Console.ReadLine();
            Console.WriteLine("Sonuç: " + SwapCase(veri));

            Console.ReadKey();
        }
    }
}
