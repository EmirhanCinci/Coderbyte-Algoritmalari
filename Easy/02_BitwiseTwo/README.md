# 02_BitwiseTwo Algoritma Sorusu

* İşlevin, eşit karakter uzunluğunda 2 tane ikilik taban sayısı tutan bir dizi oluşturun ve bu ikilik taban sayılardan aynı karakter sırasında olan karakterlerin ikisi de **'1'** karekteri ise 1 değeri değilse 0 değeri yazılmalıdır.

## Örnek Girdi ve Çıktılar

~~~ C#
// Örnek girdi:
Console.WriteLine(BitwiseTwo(new String[] { "100", "000" }));
// Çıktı:
// 000

// Örnek girdi:
Console.WriteLine(BitwiseTwo(new String[] { "10100", "11100" }));
// 10100

// Örnek girdi:
Console.WriteLine(BitwiseTwo(new String[] { "10111", "01101" }));
// Çıktı:
// 00101
~~~

## Yazdığım Kodları Adım Adım İnceleyelim.

* Kullanıcı tarafından oluşturulacak olan ikilik taban sayılarından oluşak dizinin başka ifadelerden oluşmaması için girilen ifadenin bir ikilik taban sayısı olup olmadığı kontrol edilir.

~~~ C#
public static bool IkilikTabanSayisiMi(string veri)
{
    char[] ikilik = { '0', '1' };
    foreach (var item in veri)
    {
        if (!ikilik.Contains(item))
        {
            return false;
        }
    }
    return true;
}
~~~

* İkilik taban sayısı kontrolünden sonra girilen bu iki sayının karakter sayısının aynı olup olmadığı kontrol edilir.

~~~ C#
public static bool UzunlukKontrol(string veri1, string veri2)
{
    if (veri1.Length == veri2.Length)
    {
        return true;
    }
    return false;
}
~~~

* Şimdi gelelim asıl algoritmamızın çıktısını veren metodu oluşturalım.

* Girilen dizinin elamanları hata kontrollerimizden dolayı eşit uzunluktadır. Bu nedenle herhangi bir dizi elemanın karakter sayısını almamız yeterlidir karakterleri tek tek for döngüsü ile dolaşmak için. Daha sonrasında bu iki dizi elemanının aynı karakter indisinde ortak '1' elemanını içeriyorsa sonuc değişkenine 1 yazdırılır değilse 0 yazdırılır. Son olarak sonuc değişkeni döndürülür.

~~~ C#
public static string BitwiseTwo(string[] arr)
{
    string sonuc = "";
    for (int i = 0; i < arr[0].Length; i++)
    {
        if (arr[0][i] == '1' && arr[1][i] == '1')
        {
            sonuc += "1";
        }
        else
        {
            sonuc += "0";
        }
    }
    return sonuc;
}
~~~

* Main metodu içerisine ise kullanıcının uygun yönergeler ile işlemlerin yapılması ve istenilen çıktının console ekranına yazılması sağlandı.

~~~ C#
static void Main(string[] args)
{
CONTROL:
    Console.WriteLine("-----> Lütfen gireceğiniz ikilik taban sayıları eşit uzunlukta olmalıdır. <-----");
    Console.Write("Lütfen 1. ikilik taban sayısını giriniz: ");
    string veri1 = Console.ReadLine();
    Console.Write("Lütfen 2. ikilik taban sayısını giriniz: ");
    string veri2 = Console.ReadLine();
    if (!IkilikTabanSayisiMi(veri1) || !IkilikTabanSayisiMi(veri2) || !UzunlukKontrol(veri1, veri2))
    {
        Console.WriteLine("Girmiş olduğunuz ikilik taban sayılarının ya uzunlukları eşit değildir ya da ikilik taban sayısı değildir. Lütfen tekrar deneyiniz.");
        goto CONTROL;
    }
    string[] dizi = { veri1, veri2 };
    Console.WriteLine("Sonuç: " + BitwiseTwo(dizi));

    Console.ReadKey();
}
~~~