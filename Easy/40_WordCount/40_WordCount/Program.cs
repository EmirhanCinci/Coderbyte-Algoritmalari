using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40_WordCount
{
    internal class Program
    {
        // Verilen şartı sağlayan metot
        public static int WordCount(string veri)
        {
            string[] kelime = veri.Split(' ');
            return kelime.Length;
        }

        static void Main(string[] args)
        {
            // İşlevin geçirilen str string parametresini almasını ve dizenin içerdiği kelime sayısını döndürmesini sağlayın.
            // "Asla kıyılmış buğday veya kek yemeyin" ifadesinde 6 değerini döndürür.
            // Kelimeler tek boşlukla ayrılacaktır.
            // Örnek girdi: Hello World
            //       çıktı: 2
            // Örnek girdi: one 22 three
            //       çıktı: 3

            Console.Write("Lütfen bir ifade giriniz: ");
            string veri = Console.ReadLine();
            Console.WriteLine("Sonuç: " + WordCount(veri));

            Console.ReadKey();
        }
    }
}
