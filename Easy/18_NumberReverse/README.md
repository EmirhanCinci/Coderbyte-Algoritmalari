# 18_NumberReverse Algoritma Sorusu

* İşlevin, bir sayı dizisi olacak arr parametresini iletmesini sağlayın ve sayılarla ters sırada yeni bir dize döndürün.

## Örnek Girdi ve Çıktılar

~~~ C#
Console.WriteLine(NumberReverse(new string[]{ "1", "2", "3" }));
// Çıktı: 3 2 1
Console.WriteLine(NumberReverse(new string[]{ "10", "20", "50" }));
// Çıktı: 50 20 10
~~~

## Yazdığım Kodları Adım Adım İnceleyelim.

* Kullanıcı tarafından girilen string formattaki verilerin pozitif tam sayılara dönüştürülüp dönüştürülmediğini kontrol eden hata kontrol metodudur.

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

* Alınan string formattaki pozitif tam sayılar dizisinin elemanlarını son elemandan başlayarak ilk elemana doğru tekrardan yazdıran metottur.

~~~ C#
public static string NumberReserve(string[] arr)
{
    string sonuc = "";
    for (int i = arr.Length - 1; i >= 0; i--)
    {
        sonuc += arr[i].ToString() + " ";
    }
    return sonuc;
}
~~~

* Main metodu içerisine ise kullanıcının uygun yönergeler ile işlemlerin yapılması ve istenilen çıktının console ekranına yazılması sağlandı.

~~~ C#
static void Main(string[] args)
{
CONTROL:
    Console.Write("Oluşturulacak dizi kaç terimli olacak: ");
    string veri = Console.ReadLine();
    if (!PozitifTamSayiMi(veri))
    {
        Console.WriteLine("Hatalı giriş yapıldı. Lütfen tekrar deneyiniz.");
        goto CONTROL;
    }
    int terim = Convert.ToInt32(veri);
    string[] dizi = new string[terim];
    for (int i = 0; i < terim; i++)
    {
    CONTROL2:
        Console.Write("Dizinin " + (i + 1) + ". terimini giriniz: ");
        string deger = Console.ReadLine();
        if (!PozitifTamSayiMi(veri))
        {
            Console.WriteLine("Hatalı giriş yapıldı. Lütfen tekrar deneyiniz.");
            goto CONTROL2;
        }
        dizi[i] = deger;
    }
    Console.WriteLine("Sonuç: " + NumberReserve(dizi));

    Console.ReadKey();
}
~~~