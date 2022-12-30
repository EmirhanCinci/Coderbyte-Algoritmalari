using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06_SnakeCase
{
    internal class Program
    {
        // Verilen string ifadeyi istenilen biçimde yazdıran metot
        public static string SnakeCase(string veri)
        {
            string sonuc = "";
            veri = veri.ToLower();
            foreach (var item in veri)
            {
                if (item >= 97 && item <= 122)
                {
                    sonuc += item;
                }
                else
                {
                    sonuc += "_";
                }
            }
            return sonuc;
        }

        // Verilen şartları sağlayan farklı bir metot
        public static string SnakeCase2(string veri)
        {
            return Regex.Replace(veri.ToLower(), "[^a-z]", "_");
        }

        static void Main(string[] args)
        {
            // İşlevin geçirilen str parametresini almasını ve her kelimenin küçük harfle yazıldığı ve bitişik kelimelerden bir alt çizgi ile ayrıldığı uygun yılan durumu biçiminde döndürmesini sağlayın.
            // Dize yalnızca harfleri ve her bir sözcüğü ayıran sınırlayıcı noktalama karakterlerinin bazı kombinasyonlarını içerecektir.

            // Örnek girdi: cats AND*Dogs-are Awesome
            //       çıktı: cats_and_dogs_are_awesome
            // Örnek girdi: a b c d-e-f%g
            //       çıktı: a_b_c_d_e_f_g
            // Örnek girdi: BOB loves-coding
            //       çıktı: bob_loves_coding

            Console.Write("Lütfen bir ifade giriniz: ");
            string veri = Console.ReadLine();
            Console.WriteLine("Sonuç: " + SnakeCase(veri));
            Console.WriteLine("Sonuç: " + SnakeCase2(veri));

            Console.ReadKey();
        }
    }
}
