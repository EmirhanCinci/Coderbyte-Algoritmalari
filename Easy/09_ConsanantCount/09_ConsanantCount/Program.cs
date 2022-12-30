using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _09_ConsanantCount
{
    internal class Program
    {
        // Verilen şartları sağlayan metot
        public static int ConsanantCount(string veri)
        {
            int sayac = 0;
            veri = veri.ToLower();
            for (int i = 0; i < veri.Length; i++)
            {
                if (veri[i] >= 97 && veri[i] <= 122)
                {
                    if (!(veri[i] == 'a' || veri[i] == 'e' || veri[i] == 'i' || veri[i] == 'o' || veri[i] == 'u' || veri[i] == 'ı' || veri[i] == 'ö' || veri[i] == 'ü'))
                    {
                        sayac++;
                    }
                }
            }
            return sayac;
        }

        static void Main(string[] args)
        {
            // Girilen bir metnin içerisindeki ünsüz harf sayısını veren programı yazınız.
            // Örnek Girdi: ConsonantCount("Hello World")
            //       Çıktı: 7
            // Örnek Girdi: ConsonantCount("Alphabets")
            //       Çıktı: 6

            Console.Write("Lütfen bir ifade giriniz: ");
            string veri = Console.ReadLine();
            Console.WriteLine("Sonuç: " + ConsanantCount(veri));

            Console.ReadKey();
        }
    }
}
