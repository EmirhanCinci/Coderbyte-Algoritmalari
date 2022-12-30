using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_LetterCapitalize
{
    internal class Program
    {
        // Girilen string bir ifadenin baş harflerini büyük harf yapan metot
        public static string LetterCapitalize(string veri)
        {
            string sonuc = "";
            for (int i = 0; i < veri.Length; i++)
            {
                if (veri[i] == ' ')
                {
                    sonuc += " " + veri[i + 1].ToString().ToUpper();
                    i++;
                }
                else if (i == 0)
                {
                    sonuc += veri[i].ToString().ToUpper();
                }
                else
                {
                    sonuc += veri[i].ToString().ToLower();
                }
            }
            return sonuc;
        }

        static void Main(string[] args)
        {
            // İşlevin geçirilen str parametresini almasını ve her kelimenin ilk harfini büyük yazmasını sağlayın. Kelimeler sadece bir boşlukla ayrılacaktır.

            // Örnek girdi: hello world
            //       çıktı: Hello World
            // Örnek girdi: merhaBa HERKESE
            //       çıktı: Merhaba Herkese

            Console.Write("Lütfen bir ifade giriniz: ");
            string veri = Console.ReadLine();
            Console.WriteLine("Sonuç: " + LetterCapitalize(veri));

            Console.ReadKey();
        }
    }
}
