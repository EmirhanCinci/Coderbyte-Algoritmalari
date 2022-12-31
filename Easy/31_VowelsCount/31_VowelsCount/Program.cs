using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_VowelsCount
{
    internal class Program
    {
        // Verilen şartlara göre çıktı veren metot
        public static int VowelsCount(string veri)
        {
            int sesli = 0;
            char[] sesliHarfler = { 'A', 'E', 'I', 'O', 'U', 'Ö', 'İ', 'Ü', 'a', 'e', 'ı', 'o', 'u', 'ö', 'i', 'ü' };
            for (int i = 0; i < veri.Length; i++)
            {
                if (sesliHarfler.Contains(veri[i]))
                {
                    sesli++;
                }
            }
            return sesli;
        }

        static void Main(string[] args)
        {
            // İşlevin, iletilen str string parametresini almasını ve dizenin içerdiği sesli harflerin sayısını döndürmesini sağlayın.
            // Örnek girdi: hello
            //       çıktı: 2
            // Örnek girdi: coderbyte
            //       çıktı: 3

            Console.Write("Lütfen bir ifade giriniz: ");
            string veri = Console.ReadLine();
            Console.WriteLine("Sonuç: " + VowelsCount(veri));

            Console.ReadKey();
        }
    }
}
