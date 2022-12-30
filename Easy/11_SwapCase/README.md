# 11_SwapCase Algoritma Sorusu

* Girilen bir metnin içerisindeki harfler büyük harf ise küçük harf; küçük harf ise büyük harf yapan algoritmadır.

# Örnek Girdi ve Çıktılar

~~~ C#
Console.WriteLine(SwapCase("Merhaba Dünya"));
// Çıktı: mERHABA dÜNYA
Console.WriteLine(SwapCase("EmirhaN CİNCİ"));
// Çıktı: eMİRHAn cinci
~~~ 

# Yazdığım Kodları Adım Adım İnceleyelim.

* İlk olarak string formatta içi boş bir sonuc değişkeni tanımlandı. Daha sonrasında kullanıcı tarafından girilen ifadenin karakterlerini tek tek inceleyen bir for döngüsü oluşturuldu. Karakterleri gezerken eğer karakter büyük harf ise küçük harfe, küçük harf ise büyük harfe dönüşterüp sonuc değişkenine ekler.

* Son olarak sonuc değişkeni döndürülür.

~~~ C#
public static string SwapCase(string veri)
{
    string sonuc = "";
    for (int i = 0; i < veri.Length; i++)
    {
        if (char.IsUpper(veri[i]))
        {
            sonuc += veri[i].ToString().ToLower();
        }
        else
        {
            sonuc += veri[i].ToString().ToUpper();
        }
    }
    return sonuc;
}
~~~

* Main metodu içerisine ise kullanıcının uygun yönergeler ile işlemlerin yapılması ve istenilen çıktının console ekranına yazılması sağlandı.

~~~ C#
static void Main(string[] args)
{
    Console.Write("Lütfen bir ifade giriniz: ");
    string veri = Console.ReadLine();
    Console.WriteLine("Sonuç: " + SwapCase(veri));

    Console.ReadKey();
}
~~~