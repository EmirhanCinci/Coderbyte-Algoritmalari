using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _28_ExOh
{
    internal class Program
    {
        // Girilen string bir ifade de x ve o kontrolleri yapılır. 
        public static bool ExOhKontrol(string veri)
        {
            veri = veri.ToLower();
            for (int i = 0; i < veri.Length; i++)
            {
                if (!(veri[i] == 120 || veri[i] == 111))
                {
                    return false;
                }
            }
            return true;
        }

        // Girilen string bir ifade de verilen kurallar kontrol edilir.4
        public static bool ExOh(string veri)
        {
            veri = veri.ToLower();
            int xSayac = 0;
            int oSayac = 0;
            for (int i = 0; i < veri.Length; i++)
            {
                if (veri[i] == 120)
                {
                    xSayac++;
                }
                if (veri[i] == 111)
                {
                    oSayac++;
                }
            }
            if (oSayac == xSayac)
            {
                return true;
            }
            return false;
        }

        static void Main(string[] args)
        {
            // İşlevin, iletilen str parametresini almasını ve eşit sayıda x ve o varsa dizgeyi true, aksi halde false dizisini döndürmesini sağlayın.
            // Dizide sadece bu iki harf girilecek, noktalama işareti veya sayı girilmeyecektir.
            // Örneğin: str "xooxxxxooxo" ise, 6 x ve 5 o olduğundan çıktı false döndürmelidir.
            // Örnek girdi: xooxxo
            //       çıktı: true
            // Örnek girdi: x
            //       çıktı: false

        CONTROL:
            Console.Write("Lütfen bir ifade giriniz: ");
            string veri = Console.ReadLine();
            if (!ExOhKontrol(veri))
            {
                Console.WriteLine("Girilen ifade hatalıdır. Lütfen tekrar deneyiniz.");
                goto CONTROL;
            }
            Console.WriteLine("Sonuç: " + ExOh(veri));

            Console.ReadKey();
        }
    }
}
