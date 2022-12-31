# 30_SimpleAdding Algoritma Sorusu

* İşlevin 1'den num'a kadar tüm sayıları toplamasını sağlayın.

* Örneğin: giriş 4 ise, programınız 10 döndürmelidir çünkü 1 + 2 + 3 + 4 = 10. Test durumları için, parametre num 1 ile 1000 arasında herhangi bir sayı olacaktır.

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

* Burada toplamı n * (n + 1) / 2 formülü ile kısa yoldan for döngüsüne girmeden bulabilirdik. 

* Formülü kullanmadan ise for döngüsü yardımıyla 1'den başlayarak girilen pozitif tam sayıya kadar olan tüm tam sayıları toplayan bir metottur.

~~~ C#
public static int SimpleAdding(int sayi)
{
    int toplam = 0;
    for (int i = 1; i <= sayi; i++)
    {
        toplam += i;
    }
    return toplam;
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
        Console.WriteLine("Hatalı bir giriş yapıldı. Lütfen tekrar deneyiniz.");
        goto CONTROL;
    }
    int sayi = Convert.ToInt32(veri);
    Console.WriteLine("Sonuç: " + SimpleAdding(sayi));

    Console.ReadKey();
}
~~~