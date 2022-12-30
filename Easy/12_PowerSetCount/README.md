# 12_PowerSetCount Algoritma Sorusu

* Oluşturulan bir dizinin alt küme sayısını bulan metodu yazınız.

* Alt küme sayısını bulmak için kullanacağımız matematik formülü -----> 2 ^ (dizinin eleman sayısı)

## Örnek Girdi ve Çıktılar

~~~ C#
Console.WriteLine(PowerSetCount(new int[]{ 1, 2, 3, 4 }));
// Çıktı: 16
Console.WriteLine(PowerSetCount(new int[]{ 5, 6 }));
// Çıktı: 4
~~~

## Yazdığım Kodları Adım Adım İnceleyelim.

* Kullanıcı tarafından oluşturulacak dizinin eleman sayısını belirlerken pozitif tam sayı olup olmadığına dikkat edilmesi gerekir. Bu nedenle girilen string bir değişkenin pozitif tam sayıya dönüştürülüp dönüştürülemeyeceği kontrol edilir.

~~~ C#
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
~~~

* Kullanıcı tarafından oluşturulacak dizinin elemanları tam sayı olmalıdır. Bu nedenle girilen değerlerin tam sayı olup olmadığını kontrol eden bir hata kontrol metodu oluşturdum.

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

* Şimdi hata kontrollerimiz bittiğine göre gelelim asıl metodumuza.

* Dosyanın en başında bir dizinin alt kümesini bulan matematiksel formülü vermiştik. Math.Pow(); komutu ile bu formülü uyguladım.

~~~ C#
public static int PowerSetCount(int[] arr)
{
    return (int)Math.Pow(2, arr.Length);
}
~~~

* Main metodu içerisine ise kullanıcının uygun yönergeler ile işlemlerin yapılması ve istenilen çıktının console ekranına yazılması sağlandı.

~~~ C#
static void Main(string[] args)
{
CONTROL1:
    Console.Write("Oluşturulacak dizi kaç terimli olacak: ");
    string veri = Console.ReadLine();
    if (!PozitifTamSayiMi(veri))
    {
        Console.WriteLine("Girmiş olduğunuz ifade bir pozitif tam sayı değildir. Lütfen tekrar deneyiniz.");
        goto CONTROL1;
    }
    int terim = Convert.ToInt32(veri);
    int[] dizi = new int[terim];
    for (int i = 0; i < terim; i++)
    {
    CONTROL2:
        Console.Write("Dizinin " + (i + 1) + ". terimini giriniz: ");
        string deger = Console.ReadLine();
        if (!TamSayiMi(deger))
        {
            Console.WriteLine("Girmiş olduğunuz ifade bir tam sayı değildir. Lütfen tekrar deneyiniz.");
            goto CONTROL2;
        }
        dizi[i] = Convert.ToInt32(deger);
    }
    Console.WriteLine("Sonuç: " + PowerSetCount(dizi));

    Console.ReadKey();
}
~~~