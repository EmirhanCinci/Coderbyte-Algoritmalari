# 16_SimpleEvens Algoritma Sorusu

* Girilen bir pozitif tam sayının her bir rakamı çift sayı olup olmadığını kontrol eden algoritmadır.

## Örnek Girdi ve Çıktılar

~~~ C#
Console.WriteLine(SimpleEvens(4602225));
// Çıktı: false
Console.WriteLine(SimpleEvens(226486));
// Çıktı: true
Console.WriteLine(SimpleEvens(2645846));
// Çıktı: false
~~~

## Yazdığım Kodları Adım Adım İnceleyelim.

*  Kullanıcı tarafından girilen string bir ifadenin tam sayıya dönüştürülüp dönüştürülmediğini kontrol eden metottur.

~~~ C#
public static bool TamSayiMi(string veri)
{
    try
    {
        int sayi = Convert.ToInt32(veri);
        return true;
    }
    catch (Exception)
    {
        return false;
    }
}
~~~

* Girilen bir tam sayının işareti çok önemli olmadığından dolayı ilk olarak sayının mutlak değeri alındı. Daha sonrasında sayının birler basamağından başlayarak en soldaki basamağına kadar bir kontrol işlemi yapıldı. Eğer basamaklardaki rakamlar 2'ye tam bölünmezse false değeri döndürür. Eğer tüm rakamlar 2'ye tam bölünürse true değeri döner.

~~~ C#
public static bool SimpleEvens(int sayi)
{
    sayi = Math.Abs(sayi);
    while (sayi > 0)
    {
        int kalan = sayi % 10;
        if (kalan % 2 != 0)
        {
            return false;
        }
        sayi /= 10;
    }
    return true;
}
~~~

* Main metodu içerisine ise kullanıcının uygun yönergeler ile işlemlerin yapılması ve istenilen çıktının console ekranına yazılması sağlandı.

~~~ C#
static void Main(string[] args)
{
CONTROL:
    Console.Write("Lütfen bir tam sayı giriniz: ");
    string veri = Console.ReadLine();
    if (!TamSayiMi(veri))
    {
        Console.WriteLine("Girmiş olduğunuz ifade bir tam sayı değildir. Lütfen tekrar deneyiniz.");
        goto CONTROL;
    }
    int sayi = Convert.ToInt32(veri);
    Console.WriteLine("Sonuç: " + SimpleEvens(sayi));

    Console.ReadKey();
}
~~~