using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _39_NumberAddition
{
    internal class Program
    {
        public static int NumberAddition(string veri)
        {
            int toplam = 0;
            string[] sayilar = Regex.Split(veri, @"\D+");
            foreach (string item in sayilar)
            {
                if (!string.IsNullOrEmpty(item))
                {
                    toplam += Convert.ToInt32(item);
                }
            }
            return toplam;
        }
        
        static void Main(string[] args)
        {
            // Fonksiyonun str parametresini almasını sağlayın, dizgedeki tüm sayıları arayın, bunları toplayın ve son sayıyı döndürün.
            // Örneğin: dize "88Hello 3World!" ise çıktı 91 olmalıdır.
            // Yukarıdaki örnekte olduğu gibi tek basamaklı sayılar ile çok basamaklı sayıları birbirinden ayırmanız gerekecektir.
            // Yani "55Hello" ve "5Hello 5" iki farklı cevap vermelidir. Her dize en az bir harf veya sembol içerecektir.
            // Örnek girdi: 75Number9
            //       çıktı: 84
            // Örnek girdi: 10 2One Number*1*
            //       çıktı: 13

            Console.Write("Lütfen bir ifade giriniz: ");
            string veri = Console.ReadLine();
            Console.WriteLine("Sonuç: " + NumberAddition(veri));

            Console.ReadKey();
        }
    }
}
