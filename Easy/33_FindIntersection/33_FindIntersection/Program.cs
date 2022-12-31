using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_FindIntersection
{
    internal class Program
    {
        // Verilen şartları kontrol eden metot
        public static string FindIntersection(string[] arr)
        {
            string sonuc = "";
            string[] birinci = arr[0].Split(',');
            string[] ikinci = arr[1].Split(',');
            foreach (var b in birinci)
            {
                foreach (var i in ikinci)
                {
                    if (b == i)
                    {
                        sonuc += b + " ";
                    }
                }
            }
            if (sonuc.Length > 0)
            {
                return sonuc;
            }
            return "false";
        }

        static void Main(string[] args)
        {
            // İşlevin strArr'da saklanan ve 2 öğe içerecek dize dizisini okumasını sağlayın.
            // İlk öğe, artan düzende sıralanmış virgülle ayrılmış sayıların bir listesini temsil edecek, ikinci öğe, virgülle ayrılmış sayıların ikinci bir listesini temsil edecek.
            // Amacınız, strArr öğelerinde oluşan sayıları sıralanmış düzende içeren virgülle ayrılmış bir dize döndürmektir.
            // Kesişme yoksa, dizgeyi false olarak döndürün.
            // Örnek girdi: ["1, 3, 4, 7, 13", "1, 2, 4, 13, 15"]
            //       çıktı: 1 4 13
            // Örnek girdi: ["1, 3, 9, 10, 17, 18", "1, 4, 9, 10"]
            //       çıktı: 1 9 10

            Console.Write("Lütfen birinci diziyi giriniz: ");
            string veri1 = Console.ReadLine();
            Console.Write("Lütfen ikinci diziyi giriniz: ");
            string veri2 = Console.ReadLine();
            Console.WriteLine("Sonuç: " + FindIntersection(new string[] { veri1, veri2 }));

            Console.ReadKey();
        }
    }
}
