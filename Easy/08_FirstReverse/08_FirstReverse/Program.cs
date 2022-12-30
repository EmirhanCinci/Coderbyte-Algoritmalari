using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_FirstReverse
{
    internal class Program
    {
        // Verilen şartı sağlayan metot
        public static string FirstReverse(string veri)
        {
            string sonuc = "";
            for (int i = veri.Length - 1; i >= 0; i--)
            {
                sonuc += veri[i];
            }
            return sonuc;
        }

        // Verilen şartı sağlayan farklı bir metot
        public static string FirstReverse2(string veri)
        {
            char[] harfler = veri.ToCharArray();
            Array.Reverse(harfler);
            return new string(harfler);
        }

        static void Main(string[] args)
        {
            // Kullanıcı tarafından girilen string bir ifadeyi tersten yazdırılmasını sağlayın.
            // Örnek girdi: "I Love Code"
            //       çıktı: "edoC evoL I"
            // Örnek girdi: "Hello World"
            //       çıktı: "dlroW olleH"
            // Örnek girdi: "Emirhan CİNCİ"
            //       çıktı: "İCNİC nahrimE"

            Console.Write("Lütfen bir ifade giriniz: ");
            string veri = Console.ReadLine();
            Console.WriteLine("Sonuç: " + FirstReverse(veri));
            Console.WriteLine("Sonuç: " + FirstReverse2(veri));

            Console.ReadKey();
        }
    }
}
