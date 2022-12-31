using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38_ThirdGreatest
{
    internal class Program
    {
        // Verilen şartlara göre çıktı veren metot
        public static string ThirdGreatest(string[] arr)
        {
            string[] sonuc = arr.OrderByDescending(x => x.Length).ToArray();
            return sonuc[2];
        }

        static void Main(string[] args)
        {
            // İşlevin strArr'da saklanan dize dizisini almasını ve içindeki üçüncü en büyük sözcüğü döndürmesini sağlayın.
            // Örneğin: strArr ["hello", "world", "before", "all"] ise çıktınız world olmalıdır çünkü "before" 6 harf uzunluğundadır.
            // "hello" ve "world" her ikisi de 5'tir, ancak dizideki son 5 harfli kelime olarak göründüğü için çıktı dünya olmalıdır.
            // strArr ["hello", "world", "after", "all"] ise, çıktı after olmalıdır çünkü ilk üç kelimenin tümü 5 harf uzunluğundadır, bu nedenle sonuncuyu döndürün.
            // Dizi en az üç dize olacak ve her dize yalnızca harf içerecektir.
            // Örnek girdi: ["coder", "byte", "code"]
            //       çıktı: code
            // Örnek girdi: ["abc", "defg", "z", "hijk"]
            //       çıktı: abc

            Console.WriteLine("Sonuç: " + ThirdGreatest(new string[] { "hello", "world", "before", "all" }));
            Console.WriteLine("Sonuç: " + ThirdGreatest(new string[] { "hello", "world", "after", "all" }));
            Console.WriteLine("Sonuç: " + ThirdGreatest(new string[] { "coder", "byte", "code" }));
            Console.WriteLine("Sonuç: " + ThirdGreatest(new string[] { "abc", "defg", "z", "hijk" }));

            Console.ReadKey();
        }
    }
}
