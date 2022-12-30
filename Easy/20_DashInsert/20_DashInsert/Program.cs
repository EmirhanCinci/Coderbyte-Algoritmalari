using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_DashInsert
{
    internal class Program
    {
        // Girilen string bir ifadenin pozitif tam sayı olup olmadığını kontrol eden metot
        public static bool PozitifTamSayiMi(string veri)
        {
            try
            {
                int sayi = Convert.ToInt32(veri);
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

        // Girilen string ifadeyi istenilen formata çeviren metot
        public static string DashInsert(string veri)
        {
            string sonuc = "";
            for (int i = 0; i < veri.Length - 1; i++)
            {
                if (Convert.ToInt32(veri[i]) % 2 == 1 && Convert.ToInt32(veri[i + 1]) % 2 == 1)
                {
                    sonuc += veri[i].ToString() + "-";
                }
                else
                {
                    sonuc += veri[i].ToString();
                }
            }
            sonuc += veri[veri.Length - 1];
            return sonuc;
        }

        static void Main(string[] args)
        {
            // İşlevin str'deki her iki tek sayının arasına tire (' - ') koymasını sağlayın.

            // Örnek girdi: 454793
            //       çıktı: 4547-9-3
            // Örnek girdi: 99946
            //       çıktı: 9-9-946
            // Örnek girdi: 56730
            //       çıktı: 567-30

        CONTROL:
            Console.Write("Lütfen pozitif bir tam sayı giriniz: ");
            string veri = Console.ReadLine();
            if (!PozitifTamSayiMi(veri))
            {
                Console.WriteLine("Hatalı giriş yapıldı. Lütfen tekrar deneyiniz.");
                goto CONTROL;
            }
            Console.WriteLine("Sonuç: " + DashInsert(veri));

            Console.ReadKey();
        }
    }
}
