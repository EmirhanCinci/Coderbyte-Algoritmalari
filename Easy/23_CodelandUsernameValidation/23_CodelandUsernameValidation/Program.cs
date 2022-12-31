using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_CodelandUsernameValidation
{
    internal class Program
    {
        // Girilen kullanıcı adını verilen şartlara göre uyumlu olup olmadığını kontrol eden metot
        public static bool CodelandUsernameValidation(string veri)
        {
            if (veri.Length < 4 && veri.Length > 25)
            {
                return false;
            }
            if (veri.EndsWith("_"))
            {
                return false;
            }
            if (!((veri[0] >= 65 && veri[0] <= 90) || (veri[0] >= 97 && veri[0] <= 122)))
            {
                return false;
            }
            if (!veri.Contains("_"))
            {
                return false;
            }
            char[] rakamlar = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            foreach (var item in veri)
            {
                if (rakamlar.Contains(item))
                {
                    return true;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            // İşlevin, iletilen str parametresini almasını ve aşağıdaki kurallara göre dizenin geçerli bir kullanıcı adı olup olmadığını belirlemesini sağlayın:
            // 1-) Kullanıcı adı 4 ile 25 karakter arasındadır.
            // 2-) Harf ile başlamalıdır.
            // 3-) Sadece harf, rakam ve alt çizgi karakteri içermelidir.
            // 4-) Alt çizgi karakteri ile bitemez.
            // Kullanıcı adı geçerliyse, programınız true dizesini döndürmelidir, aksi takdirde false dizesini döndürmelidir.

            // Örnek girdi: aa_
            //       çıktı: false
            // Örnek girdi: u__hello_world123
            //       çıktı: true
            // Örnek girdi: 12a_s5aaa
            //       çıktı: false
            // Örnek girdi: u__hello_world123_
            //       çıktı: false

            Console.Write("Lütfen bir kullanıcı adı giriniz: ");
            string veri = Console.ReadLine();
            Console.WriteLine("Sonuç: " + CodelandUsernameValidation(veri));

            Console.ReadKey();
        }
    }
}
