# 39_NumberAddition Algoritma Sorusu

* Fonksiyonun str parametresini almasını sağlayın, dizgedeki tüm sayıları arayın, bunları toplayın ve son sayıyı döndürün.

* Örneğin: dize "88Hello 3World!" ise çıktı 91 olmalıdır.

* Yukarıdaki örnekte olduğu gibi tek basamaklı sayılar ile çok basamaklı sayıları birbirinden ayırmanız gerekecektir. Yani "55Hello" ve "5Hello 5" iki farklı cevap vermelidir. Her dize en az bir harf veya sembol içerecektir.

## Örnek Girdi ve Çıktılar

~~~ C#
Console.WriteLine(NumberAddition("75Number9"));
// Çıktı: 84
Console.WriteLine(NumberAddition("10 2One Number*1*"));
// Çıktı: 13
~~~

## Yazdığım Kodları Adım Adım İnceleyelim.

* Kullanıcı tarafından girilen bir string ifadeyi rakam haricindeki tüm karakterlere göre ayırarak bir dizi haline getirdik.

* Daha sonra dizi içerisinde var ise integer veri tipine dönüştürerek toplanır. 

* Son olarak toplam döndürülür.

~~~ C#
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
~~~

* Main metodu içerisine ise kullanıcının uygun yönergeler ile işlemlerin yapılması ve istenilen çıktının console ekranına yazılması sağlandı.

~~~ C#
static void Main(string[] args)
{
            // Örnek girdi: 75Number9
            //       çıktı: 84
            // Örnek girdi: 10 2One Number*1*
            //       çıktı: 13

    Console.Write("Lütfen bir ifade giriniz: ");
    string veri = Console.ReadLine();
    Console.WriteLine("Sonuç: " + NumberAddition(veri));

    Console.ReadKey();
}
~~~