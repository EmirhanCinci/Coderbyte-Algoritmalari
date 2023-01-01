using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_RunLength
{
    internal class Program
    {
        // Verilen kurala uygun bir şekilde işlemi gerçekleşiren metot
        public static string RunLength(string text)
        {
            string sonuc = "";
            int sayac = 1;
            char harf = text[0];
            for (int i = 1; i < text.Length; i++)
            {
                if (text[i] == harf)
                {
                    sayac++;
                }
                else
                {
                    sonuc += sayac + harf.ToString();
                    harf = text[i];
                    sayac = 1;
                }
            }
            if (harf == text[text.Length - 1])
            {
                sonuc += sayac + harf.ToString();
            }
            else
            {
                sayac = 1;
                sonuc += sayac + harf.ToString();
            }
            return sonuc;
        }

        static void Main(string[] args)
        {
            // Girilen bir string formatındaki bir ifadenin kaç tane harfin art arda geldiğini belirten metot
            // Örnek girdi: RunLength("aaabbcde")
            //       çıktı: 3a2b1c1d1e
            // Örnek girdi: RunLength("wwwbbw")
            //       çıktı: 3w2b1w

            Console.Write("Lütfen bir ifade giriniz: ");
            string text = Console.ReadLine();
            Console.WriteLine("Girmiş olduğunuz ifade: " + text + "\n" + "Metot Sonrası: " + RunLength(text));
            Console.ReadKey();
        }
    }
}
