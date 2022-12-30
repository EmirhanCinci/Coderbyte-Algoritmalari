using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04_AlphabetSearching
{
    internal class Program
    {
        // Verilen algoritmanın şartlarını kontrol eden metot
        public static bool AlphabetSearching(string veri)
        {
            string alfabe = "abcdefghijklmnopqrstuvwxyz";
            int sayac = 0;
            foreach (var a in alfabe)
            {
                foreach (var v in veri)
                {
                    if (a == v)
                    {
                        sayac++;
                        break;
                    }
                }
            }
            if (sayac == 26)
            {
                return true;
            }
            return false;
        }

        // Verilen algoritmanın şartlarını kontrol eden farklı bir metot
        public static bool AlphabetSearching2(string veri)
        {
            string harfler = Regex.Replace(veri.ToLower(), @"[^a-z]+", "");
            var hashSet = new HashSet<char>(harfler.ToCharArray());
            if (hashSet.Count == 26)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main(string[] args)
        {
            // Metotun, iletilen str parametresini almasını ve dizide İngiliz alfabesinin her bir harfi varsa diziyi true döndürmesini sağlayın aksi takdirde diziyi false döndürün.

            // Örnek girdi: zacxyjbbkfgtbhdaielqrm45pnsowtuv
            //       çıktı: true
            // Örnek girdi: abcdefghijklmnopqrstuvwxyyyy
            //       çıktı: false
            // Örnek girdi: abc123456kmo
            //       çıktı: false

            Console.Write("Lütfen bir ifade giriniz: ");
            string veri = Console.ReadLine();
            Console.WriteLine("Sonuç: " + AlphabetSearching(veri));
            Console.WriteLine("Sonuç: " + AlphabetSearching2(veri));

            Console.ReadKey();
        }
    }
}
