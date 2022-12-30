using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_AlphabetSoup
{
    internal class Program
    {
        // Verilen algoritmayı sağlayan metot
        public static string AlphabetSoup(string veri)
        {
            string sonuc = "";
            List<char> list = new List<char>();
            foreach (var item in veri)
            {
                if ((item >= 65 && item <= 90) || (item >= 97 && item <= 122))
                {
                    list.Add(item);
                }
            }
            list.Sort();
            foreach (var item in list)
            {
                sonuc += item;
            }
            return sonuc;
        }

        static void Main(string[] args)
        {
            // İşlevin, iletilen str string parametresini almasını ve dizeyi harflerle alfabetik sırayla döndürmesini sağlayın.
            // Sayıların ve noktalama işaretlerinin dizeye dahil edilmeyeceğini varsayalım.

            // Örnek girdi: coderbyte 
            //       çıktı: bcdeeorty
            // Örnek girdi: hooplah
            //       çıktı: ahhloop

            Console.Write("Lütfen bir ifade giriniz: ");
            string veri = Console.ReadLine();
            Console.WriteLine("Sonuç: " + AlphabetSoup(veri));

            Console.ReadKey();
        }
    }
}
