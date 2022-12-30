using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace _07_CamelCase
{
    internal class Program
    {
        // Verilen şartları sağlayan metot
        public static string CamelCase(string veri)
        {
            string sonuc = "";
            veri = veri.ToLower();
            for (int i = 0; i < veri.Length; i++)
            {
                if (veri[i] < 97 || veri[i] > 122)
                {
                    sonuc += " ";
                }
                else
                {
                    if (i != 0 && sonuc[i - 1] == ' ')
                    {
                        sonuc += veri[i].ToString().ToUpper();
                    }
                    else
                    {
                        sonuc += veri[i].ToString();
                    }
                }
            }
            sonuc = sonuc.Replace(" ", "");
            return sonuc;
        }

        static void Main(string[] args)
        {
            // Metotun, iletilen txt parametresini almasını ve her kelimenin ilk harfinin (ilk harf hariç) büyük yazıldığı biçimde döndürmesini sağlayın.
            // Dize yalnızca harfleri ve her bir sözcüğü ayıran sınırlayıcı noktalama karakterlerinin bazı kombinasyonlarını içerecektir.

            // Örnek girdi: BOB loves-coding
            //       çıktı: bobLovesCoding
            // Örnek girdi: cats AND*Dogs-are Awesome
            //       çıktı: catsAndDogsAreAwesome
            // Örnek girdi: a b c d-e-f%g
            //       çıktı: aBCDEFG

            Console.Write("Lütfen bir ifade giriniz: ");
            string veri = Console.ReadLine();
            Console.WriteLine("Sonuç: " + CamelCase(veri));

            Console.ReadKey();
        }
    }
}
