# 02_RunLength Algoritma Sorusu

* Girilen bir string formatındaki bir ifadenin kaç tane harfin art arda geldiğini belirten algoritmadır.

## Örnek Girdi ve Çıktılar

~~~ C#
Console.WriteLine(RunLength("aaabbcde"));
// Çıktı: 3a2b1c1d1e
Console.WriteLine(RunLength("wwwbbw"));
// Çıktı: 3w2b1w
~~~

## Yazdığım Kodları Adım Adım İnceleyelim.

* İlk olarak bir sonuc değişkeni ve bir de sayac değişkeni tanımlandı. Daha sonrasında girilen string ifadedeki ilk karakter alındı. Daha sonraki karakterlerle bir kontrol işlemi yapıldı.

* Bu kontrol işleminde tutulan harf sonraki karakter ile aynı ise sayac'ı bir arttırdık. Eğer değilse sonuc değişkeni sayacla beraber yazdırıldı ve harf değiştirildi, sayac 1 yapıldı. İşlem bu şekilde son karaktere kadar gider.

* For döngüsünden sonra bir kontrol işlemi daha yapmak zorundayız. Eğer son karakter aynı ise sayac'ı arttırıp döngüden çıkacak yani yazdırmayacak o nedenle for döngüsünden sonra if bloğunda bu durum kontrol altına alınıp sonuc değişkenine eklendi. Eğer son karakter aynı değilse bir önceki karakteri yazdırıp sayac'ı 1 yapacak ama bu kezde son karakter yazılmamış olacak o nedenle else bloğunda da o durum kontrol altına alındı. 

* Son olarak sonuc değişkeni döndürüldü.

~~~ C#
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
~~~

* Main metodu içerisine ise kullanıcının uygun yönergeler ile işlemlerin yapılması ve istenilen çıktının console ekranına yazılması sağlandı.

~~~ C#
static void Main(string[] args)
{
    Console.Write("Lütfen bir ifade giriniz: ");
    string text = Console.ReadLine();
    Console.WriteLine("Girmiş olduğunuz ifade: " + text + "\n" + "Metot Sonrası: " + RunLength(text));

    Console.ReadKey();
}
~~~