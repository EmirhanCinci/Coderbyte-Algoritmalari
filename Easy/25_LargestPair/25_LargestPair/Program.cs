using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_LargestPair
{
    internal class Program
    {
        // Girilen string bir ifadenin pozitif tam sayı olup olmadığını kontrol eden metot
        public static bool PozitifTamSayiMi(string veri)
        {
            try
            {
                uint sayi = (uint)Convert.ToUInt64(veri);
                if (sayi > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        // Verilen şartlara göre çıktı veren metot
        public static int LargestPair(uint sayi)
        {
            int enBuyuk = 0;
            string veri = sayi.ToString();
            for (int i = 0; i < veri.Length - 1; i++)
            {
                string metin = veri[i].ToString() + veri[i + 1].ToString();
                int gecici = Convert.ToInt32(metin);
                if (gecici > enBuyuk)
                {
                    enBuyuk = gecici;
                }
            }
            return enBuyuk;
        }

        static void Main(string[] args)
        {
            // İşlevin geçirilen num parametresini almasını ve tam sayı içindeki en büyük çift basamaklı sayıyı belirlemesini sağlayın. Giriş her zaman en az iki pozitif basamak içerecektir.

            // Örnek girdi: 4759472
            //       çıktı: 94
            // Örnek girdi: 453857
            //       çıktı: 85
            // Örnek girdi: 363223311
            //       çıktı: 63

        CONTROL:
            Console.Write("Lütfen pozitif bir tam sayı giriniz: ");
            string veri = Console.ReadLine();
            if (!PozitifTamSayiMi(veri))
            {
                Console.WriteLine("Hatalı giriş yapıldı. Lütfen tekrar deneyiniz.");
                goto CONTROL;
            }
            uint sayi = (uint)Convert.ToUInt64(veri);
            Console.WriteLine("Sonuç: " + LargestPair(sayi));

            Console.ReadKey();
        }
    }
}
