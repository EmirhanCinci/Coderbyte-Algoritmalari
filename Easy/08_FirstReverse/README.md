# 08_FirstReverse Algoritma Sorusu

* Kullanıcı tarafından girilen string bir ifadeyi tersten yazdırılmasını sağlayın.

## Örnek Girdi ve Çıktılar

~~~ C#
Console.WriteLine(FirstReverse("I Love Code"));
// Çıktı: edoC evoL I
Console.WriteLine(FirstReverse("Hello World"));
// Çıktı: dlroW olleH
Console.WriteLine(FirstReverse("Emirhan CİNCİ"));
// Çıktı: İCNİC nahrimE
~~~

## Yazdığım Kodları Adım Adım İnceleyelim.

* İlk olarak string formatta bir sonuc değişkeni tanımlanır.

* Daha sonrasında kullanıcı tarafından girilen ifade for döngüsü yardımı ile son karakterden başlayarak ilk karaktere doğru karakterleri tek tek sonuc değişkenine eklemesi sağlandı. 

* Son olarak sonuc değişkeni döndürülür.

~~~ C#
public static string FirstReverse(string veri)
{
    string sonuc = "";
    for (int i = veri.Length - 1; i >= 0; i--)
    {
        sonuc += veri[i];
    }
    return sonuc;
}
~~~

* Şimdi farklı bir şekilde FirstReverse metodunu yazalım.

* İlk olarak kullanıcının girdiği ifadedeki karakterler bir diziye alınır ve dizi ters çevrilir. Son olarak ters çevrilmiş karakter dizisini string formata dönüştürür.

~~~ C#
public static string FirstReverse2(string veri)
{
    char[] harfler = veri.ToCharArray();
    Array.Reverse(harfler);
    return new string(harfler);
}
~~~

* Main metodu içerisine ise kullanıcının uygun yönergeler ile işlemlerin yapılması ve istenilen çıktının console ekranına yazılması sağlandı.

~~~ C#
static void Main(string[] args)
{
    Console.Write("Lütfen bir ifade giriniz: ");
    string veri = Console.ReadLine();
    Console.WriteLine("Sonuç: " + FirstReverse(veri));
    Console.WriteLine("Sonuç: " + FirstReverse2(veri));

    Console.ReadKey();
}
~~~