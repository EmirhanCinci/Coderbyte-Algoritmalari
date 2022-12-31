using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_LongestWord
{
    internal class Program
    {
        // Girilen metin içerisindeki harf ve sayıları tutan metot
        public static string HarfveSayilar(string veri)
        {
            string sonuc = "";
            veri = veri.ToLower();
            for (int i = 0; i < veri.Length; i++)
            {
                if ((veri[i] >= 0 && veri[i] <= 9) || (veri[i] >= 97 && veri[i] <= 122) || veri[i] == ' ')
                {
                    sonuc += veri[i];
                }
            }
            return sonuc;
        }

        // İstenilen çıktıyı veren metot
        public static string LongestWord(string veri)
        {
            veri = HarfveSayilar(veri);
            string[] dizi = veri.Split(' ');
            string sonuc = dizi[0];
            for (int i = 1; i < dizi.Length; i++)
            {
                if (dizi[i].Length > sonuc.Length)
                {
                    sonuc = dizi[i];
                }
            }
            return sonuc;
        }

        static void Main(string[] args)
        {
            // İşlevin, iletilen str parametresini almasını ve dizedeki en uzun sözcüğü döndürmesini sağlayın.
            // Aynı uzunlukta iki veya daha fazla kelime varsa, dizeden bu uzunluktaki ilk kelimeyi döndürün.
            // Noktalama işaretlerini yoksayın ve str'nin boş olmayacağını varsayalım. Kelimeler aynı zamanda rakamlar da içerebilir.
            // Örneğin "Merhaba dünya123 567"
            // Örnek girdi: fun&!! time
            //       çıktı: time
            // Örnek girdi: I love dogs
            //       çıktı: love

            Console.WriteLine("Lütfen bir ifade giriniz: ");
            string veri = Console.ReadLine();
            Console.WriteLine("Sonuç: " + LongestWord(veri));

            Console.ReadKey();
        }
    }
}
