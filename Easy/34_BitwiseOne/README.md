# 34_BitwiseOne Algoritma Sorusu

* İşlevin, ikili sayıları temsil eden eşit uzunlukta yalnızca iki dizi içerecek olan strArr'da saklanan dizeler dizisini almasını ve her iki dizide de bitsel OR işlemini gerçekleştiren son bir ikili diziyi döndürmesini sağlayın. Bitsel OR işlemi, her iki ikili dizide de sıfırların olduğu yeni diziye bir 0 yerleştirir, aksi takdirde o noktaya bir 1 yerleştirir.

## Örnek Girdi ve Çıktılar

~~~ C#
Console.WriteLine(BitwiseOne(new string[] { "1001", "0100" }));
// Çıktı: 1101
Console.WriteLine(BitwiseOne(new string[] { "100", "000" }));
// Çıktı: 100
Console.WriteLine(BitwiseOne(new string[] { "00011", "01010" }));
// Çıktı: 01011
~~~

## Yazdığım Kodları Adım Adım İnceleyelim.

* Kullanıcı tarafından girilen string bir ifade ikilik taban sayısı ise true, değilse false değerini döndüren hata kontrol metodudur.

~~~ C#
public static bool IkilikTabanSayisiMi(string veri)
{
    for (int i = 0; i < veri.Length; i++)
    {
        if (veri[i] != '1' && veri[i] != '0')
        {
            return false;
        }
    }
    return true;
}
~~~

* Kullanıcı tarafından girilen iki ikilik taban sayısının uzunlukları aynı ise true değeri, değilse false değerini döndüren hata kontrol metodudur.

~~~ C#
public static bool BitwiseOneUzunlukKontrol(string veri1, string veri2) 
{
    if (veri1.Length == veri2.Length)
    {
        return true;
    }
    else
    {
        return false;
    }
}
~~~

* Kullanıcı tarafından oluşturulmuş ikilik taban sayılarının herhangi birisinin aynı indiste karakteri 1 ise 1 eklenir. Değilse 0 eklenir ve oluşan string ifade döndürülür.

~~~ C#
public static string BitwiseOne(string[] arr)
{
    string sonuc = "";
    for (int i = 0; i < arr[0].Length; i++)
    {
        if (arr[0][i] == '1' || arr[1][i] == '1')
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
    Console.Write("Lütfen 1. ikilik taban sayısını giriniz: ");
    string veri1 = Console.ReadLine();
    Console.Write("Lütfen 2. ikilik taban sayısını giriniz: ");
    string veri2 = Console.ReadLine();
    if (!IkilikTabanSayisiMi(veri1) || !IkilikTabanSayisiMi(veri2) || !BitwiseOneUzunlukKontrol(veri1, veri2))
    {
        Console.WriteLine("Girilen ifadelerin ya uzunlukları eşit değil ya da ikilik taban sayısı değildir. Lütfen tekrar deneyiniz.");
        goto CONTROL;
    }
    Console.WriteLine("Sonuç: " + BitwiseOne(new string[] { veri1, veri2 }));

    Console.ReadKey();
}
~~~