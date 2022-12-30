# 09_ConsanantCount Algoritma Sorusu

* Girilen bir metnin içerisindeki ünsüz harf sayısını veren programı yazınız.

## Örnek Girdi ve Çıktılar

~~~ C#
Console.WriteLine(ConsanantCount("Hello World"));
// Çıktı: 7
Console.WriteLine(ConsanantCount("Alphabets"));
// Çıktı: 6
~~~

## Yazdığım Kodları Adım Adım İnceleyelim.

* İlk olarak ünsüz harfleri sayması için bir sayac değişkeni tanımlanır ve kullanıcının girdiği ifade küçük harflere dönüştürülür. 

* Daha sonrasında for döngüsü ile girilen ifadenin karakterleri harf olup olmadığı kontrol edilir. Eğer harf ise bu seferde ünsüz olup olmadığı kontrol edilir. Eğer ünsüz ise sayac bir arttırılır.

* Son olarak sayac değişkeni döndürülür.

~~~ C#
public static int ConsanantCount(string veri)
{
    int sayac = 0;
    veri = veri.ToLower();
    for (int i = 0; i < veri.Length; i++)
    {
        if (veri[i] >= 97 && veri[i] <= 122)
        {
            if (!(veri[i] == 'a' || veri[i] == 'e' || veri[i] == 'i' || veri[i] == 'o' || veri[i] == 'u' || veri[i] == 'ı' || veri[i] == 'ö' || veri[i] == 'ü'))
            {
                sayac++;
            }
        }
    }
    return sayac;
}
~~~

* Main metodu içerisine ise kullanıcının uygun yönergeler ile işlemlerin yapılması ve istenilen çıktının console ekranına yazılması sağlandı.

~~~ C#
static void Main(string[] args)
{
    Console.Write("Lütfen bir ifade giriniz: ");
    string veri = Console.ReadLine();
    Console.WriteLine("Sonuç: " + ConsanantCount(veri));

    Console.ReadKey();
}
~~~