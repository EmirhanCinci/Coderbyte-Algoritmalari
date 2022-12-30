# 13_HappyNumbers Algoritma Sorusu

* Girilen bir pozitif tam sayının basamaklarındaki rakamlarının kareleri toplamı 1 ise mutlu sayıdır; değil ise mutlu sayı değildir.

## Örnek Girdi ve Çıktılar

* 10 sayısını inceleyelim... -----> 1^2 + 0^2 = 1 + 0 = 1 olduğu için mutlu sayıdır.

~~~ C#
Console.WriteLine(HappyNumbers(1));
// Çıktı: true
Console.WriteLine(HappyNumbers(10));
// Çıktı: true
Console.WriteLine(HappyNumbers(101));
// Çıktı: false
~~~

## Yazdığım Kodları Adım Adım İnceleyelim.

* Kullanıcıdan bir pozitif tam sayı alınacağı için bir hata kontrol metodu oluşturdum. Bu hata kontrolünde girilen string bir ifadenin pozitif tam sayı dönüştürülüp dönüştürülmediği kontrol edildi.

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

* Hata kontrolünü yaptığımıza göre şimdi gelelim asıl algoritmamızın çıktısını veren metoda.

* İlk olarak toplam değişkeni tanımlandı ve değer olarak sıfır atandı. Daha sonra while döngüsü yardımı ile sayının rakamları tek tek bulundu ve kareleri alındı. Alınan kareler toplam değişkenine eklendi.

* Son olarak döngü bittiğinde toplam değişkeni 1'e eşit olup olmadığı kontrol edildi. Eğer 1'e eşitse true değeri; değilse false değeri döndürdü. 

~~~ C#
public static bool HappyNumbers(int sayi)
{
    int toplam = 0;
    while (sayi > 0)
    {
        int kalan = sayi % 10;
        toplam += (int)Math.Pow(kalan, 2);
        sayi /= 10;
    }
    if (1 == toplam)
    {
        return true;
    }
    else
    {
        return false;
    }
}
~~~

* Main metodu içerisine ise kullanıcının uygun yönergeler ile işlemlerin yapılması ve istenilen çıktının console ekranına yazılması sağlandı.

~~~ C#
static void Main(string[] args)
{
CONTROL:
    Console.Write("Lütfen pozitif bir tam sayı giriniz: ");
    string veri = Console.ReadLine();
    if (!PozitifTamSayiMi(veri))
    {
        Console.WriteLine("Girmiş olduğunuz ifade pozitif bir tam sayı değildir. Lütfen tekrar deneyiniz.");
        goto CONTROL;
    }
    int sayi = Convert.ToInt32(veri);
    Console.WriteLine("Sonuç: " + HappyNumbers(sayi));

    Console.ReadKey();
}
~~~