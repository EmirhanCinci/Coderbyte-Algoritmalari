using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace _32_SimpleSymbols
{
    internal class Program
    {
        // Verilen şartları kontrol eden metot
        public static bool SimpleSymbols(string veri)
        {
            veri = veri.ToLower();
            for (int i = 0; i < veri.Length; i++)
            {
                if (i == 0 || i == veri.Length - 1)
                {
                    if (veri[i] >= 97 && veri[i] <= 122)
                    {
                        return false;
                    }
                }
                if (veri[i] >= 97 && veri[i] <= 122)
                {
                    if (veri[i -1] != '+' || veri[i + 1] != '+')
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            // İşlevin geçirilen str parametresini almasını ve dizgiyi true veya false döndürerek kabul edilebilir bir dizi olup olmadığını belirlemesini sağlayın.
            // str parametresi, aralarında birkaç karakter bulunan + ve = sembollerinden oluşacaktır.
            // Dizgenin doğru olması için her harfin bir + sembolü ile çevrelenmesi gerekir.
            // Dize boş olmayacak ve en az bir harf içerecektir.
            // Örnek girdi: ++d+===+c++==a
            //       çıktı: false
            // Örnek girdi: +d+=3=+s+
            //       çıktı: true
            // Örnek girdi: f++d+
            //       çıktı: false

            Console.Write("Lütfen bir ifade giriniz: ");
            string veri = Console.ReadLine();
            Console.WriteLine("Sonuç: " + SimpleSymbols(veri));

            Console.ReadKey();
        }
    }
}
