# 14_CheckNums Algoritma Sorusu

* Girilen sayı1 ve sayı2 durumlarını inceleyin. Eğer sayı1, sayı2'den büyük ise false; sayı2, sayı1'den büyük ise true; eşit ise -1'i ekrana yazdırılmasını sağlayın.

## Örnek Girdi ve Çıktılar

~~~ C#
Console.WriteLine(CheckNums(11, 26));
// Çıktı: true
Console.WriteLine(CheckNums(21, 2));
// Çıktı: false
Console.WriteLine(CheckNums(25, 25));
// Çıktı: -1
~~~

## Yazdığım Kodları Adım Adım İnceleyelim.

* Kullanıcıdan bir tam sayı alınacağı için bir hata kontrol metodu oluşturdum. Bu hata kontrolünde girilen string bir ifadenin tam sayıya dönüştürülüp dönüştürülmediği kontrol edildi.

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

* Hata kontrolünü yaptık. Şimdi asıl algoritmamızın çıktısını verecek metodu oluşturmaya.

* Girilen iki tam sayının birbirine göre durumunu inceler. Eğer ilk girilen sayı büyük ise false, ikinci girilen sayı büyükse true, eşitlerse -1 değeri döner.

~~~ C#
public static string CheckNums(int sayi1, int sayi2)
{
    if (sayi1 > sayi2)
    {
        return "false";
    }
    else if (sayi1 < sayi2)
    {
        return "true";
    }
    else
    {
        return "-1";
    }
}
~~~

* Main metodu içerisine ise kullanıcının uygun yönergeler ile işlemlerin yapılması ve istenilen çıktının console ekranına yazılması sağlandı.

~~~ C#
static void Main(string[] args)
{
CONTROL:
    Console.Write("Lütfen 1. sayıyı giriniz: ");
    string veri1 = Console.ReadLine();
    Console.Write("Lütfen 2. sayıyı giriniz: ");
    string veri2 = Console.ReadLine();
    if (!TamSayiMi(veri1) || !TamSayiMi(veri2))
    {
        Console.WriteLine("Girmiş olduğunuz ifadelerden biri veya ikisi de tam sayı değildir. Lütfen tekrar deneyiniz.");
        goto CONTROL;
    }
    int sayi1 = Convert.ToInt32(veri1);
    int sayi2 = Convert.ToInt32(veri2);
    Console.WriteLine("Sonuç: " + CheckNums(sayi1, sayi2));

    Console.ReadKey();
}
~~~