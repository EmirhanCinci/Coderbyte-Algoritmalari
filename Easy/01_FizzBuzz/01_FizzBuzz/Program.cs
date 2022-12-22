using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_FizzBuzz
{
    internal class Program
    {
        // Girilen string bir ifadenin pozitif tam sayı olup olmadığı kontrol edilir.
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

        // Girilen sayıyı istenilen formattaki string halini tutar.
        public static string FizzBuzz(int sayi)
        {
            string sonuc = "";
            for (int i = 1; i <= sayi; i++)
            {
                if (i % 3 == 0 && i % 5 != 0)
                {
                    sonuc += "Fizz "; 
                }
                else if (i % 5 == 0 && i % 3 != 0)
                {
                    sonuc += "Buzz ";
                }
                else if (i % 3 == 0 && i % 5 == 0)
                {
                    sonuc += "FizzBuzz ";
                }
                else
                {
                    sonuc += i.ToString() + " ";
                }
            }
            return sonuc;
        }

        // Girilen sayıyı istenilen formattaki string halini tutan farklı bir metot
        public static string FizzBuzz2(int sayi)
        {
            return String.Join(" ", Enumerable.Range(1, sayi)
                .Select(x => x % 15 == 0 ? "FizzBuzz" 
                : x % 3 == 0 ? "Fizz" 
                : x % 5 == 0 ? "Buzz" 
                : x.ToString()));
        }

        // String.Join(); komutu ile dizi içerisindeki elemanları ayırıcı ile birleştirerek string formata getirilmesini sağlar.
        // Enumerable.Range(); komutu ile bir tam sayı aralığı sağlar.

        static void Main(string[] args)
        {
            // Kullanıcı tarafından girilen pozitif bir tam sayı girer ve 1'den başlayarak girilen sayıya kadar birer birer bir kontrol işlemi yapılır.
            // Eğer sayı 3'e bölünürse Fizz; 5'e bölünürse Buzz; hem 3'e hem 5'e tam bölünürse FizzBuzz yazdırılır.
            // Sayı yukarıdaki kurallara uymuyorsa sayının kendisi yazdırılır.
            // Örnek girdi: 12 
            //       çıktı: 1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz
            // Örnek girdi: 16
            //       çıktı: 1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz 16
            // Örnek girdi: 32
            //       çıktı: 1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz 16 17 Fizz 19 Buzz Fizz 22 23 Fizz Buzz 26 Fizz 28 29 FizzBuzz 31 32

            // Algoritmamızı kullanıcının kullanabilmesi için gerekli yönlendirici komutlar kümesidir.
        CONTROL:
            Console.Write("Lütfen pozitif bir tam sayı giriniz: ");
            string veri = Console.ReadLine();
            if (!PozitifTamSayiMi(veri))
            {
                Console.WriteLine("Hatalı giriş yaptınız. Lütfen bir pozitif tam sayı giriniz.");
                goto CONTROL;
            }
            int sayi = Convert.ToInt32(veri);
            Console.WriteLine("Girmiş " + sayi + " sayısının sonucu: " + FizzBuzz(sayi));
            Console.WriteLine("Girmiş " + sayi + " sayısının sonucu: " + FizzBuzz2(sayi));
            Console.ReadKey();
        }
    }
}
