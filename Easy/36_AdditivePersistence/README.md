# 36_AdditivePersistence Algoritma Sorusu

* İşlevin, her zaman pozitif bir tamsayı olacak olan geçirilmekte olan num parametresini almasını ve tek bir basamağa ulaşana kadar num'daki basamakları toplamanız gereken sayı olan toplama kalıcılığını döndürmesini sağlayın. Örneğin: num 2718 ise programınız 2 döndürmelidir. Çünkü 2 + 7 + 1 + 8 = 18 ve 1 + 8 = 9 ve 9'da durursunuz.

## Yazdığım Kodları Adım Adım İnceleyelim.

* Algoritmamızın çalışması için kullanıcıdan bir pozitif tam sayı girmesini istediğimiz için ilk olarak pozitif tam sayı kontrolü yapılır. Yani kullanıcı pozitif bir tam sayı yerine metinsel ifade, işaretler veya pozitif tam sayı olmayan sayılar girebilir. Bunun için bir hata kontrolü yapıldı.

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

* Kullanıcı tarafından girilen bir sayının basamak rakamlarını toplayan metottur.

~~~ C#
public static int BasamakToplami(int sayi)
{
    int toplam = 0;
    while (sayi > 0)
    {
        int kalan = sayi % 10;
        toplam += kalan;
        sayi /= 10;
    }
    return toplam;
}
~~~

* Burada sürekli olrak basamakları toplanır ta ki basamakları toplamı 1 basamaklı olana kadar.

~~~ C#
public static int AdditivePersistence(int sayi)
{
    int sonuc = 0;
    if (sayi < 10)
    {
        return sayi;
    }
    while (sayi > 10)
    {
        sonuc = BasamakToplami(sayi);
        sayi = BasamakToplami(sayi);
    }
    return sonuc;
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
        Console.WriteLine("Hatalı giriş yapıldı. Lütfen tekrar deneyiniz.");
        goto CONTROL;
    }
    int sayi = Convert.ToInt32(veri);
    Console.WriteLine("Sonuç: " + AdditivePersistence(sayi));

    Console.ReadKey();
}
~~~