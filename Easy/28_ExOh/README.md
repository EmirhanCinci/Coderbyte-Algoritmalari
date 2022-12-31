# 28_ExOh Algoritma Sorusu

* İşlevin, iletilen str parametresini almasını ve eşit sayıda x ve o varsa dizgeyi true, aksi halde false dizisini döndürmesini sağlayın. Dizide sadece bu iki harf girilecek, noktalama işareti veya sayı girilmeyecektir.

## Örnek Girdi ve Çıktılar

~~~ C#
Console.WriteLine(ExOh("xooxxxxooxo"));
// Çıktı: false
Console.WriteLine(ExOh("xooxxo"));
// Çıktı: true
Console.WriteLine(ExOh("x"));
// Çıktı: false
~~~

## Yazdığım Kodları Adım Adım İnceleyelim.

* Kullanıcı tarafından girilen ifadede sadece x ve o karakterlerinin olup olmadığını kontrol eden metottur. Yani x veya o karakteri dışında farklı bir karaktere denk gelirse false değeri, aksi halde true değeri döner.

~~~ C#
public static bool ExOhKontrol(string veri)
{
    veri = veri.ToLower();
    for (int i = 0; i < veri.Length; i++)
    {
        if (!(veri[i] == 120 || veri[i] == 111))
        {
            return false;
        }
    }
    return true;
}
~~~

* Hata kontrolünden sonra girilen ifadedeki tüm karakterleri küçük harfe dönüştürüp iki farklı sayac tanımladık.

* Daha sonra for döngüsü yardımıyla karakterleri tek tek kontrol işlemi yaptık. Örneğin karakter x ise xSayac; o ise oSayac bir arttırıldı.

* Sayım işi ve for döngüsü bittiğinde ise sayaclar aynı ise true değeri değilse false değeri döner.

~~~ C#
public static bool ExOh(string veri)
{
    veri = veri.ToLower();
    int xSayac = 0;
    int oSayac = 0;
    for (int i = 0; i < veri.Length; i++)
    {
        if (veri[i] == 120)
        {
            xSayac++;
        }
        if (veri[i] == 111)
        {
            oSayac++;
        }
    }
    if (oSayac == xSayac)
    {
        return true;
    }
    return false;
}
~~~

* Main metodu içerisine ise kullanıcının uygun yönergeler ile işlemlerin yapılması ve istenilen çıktının console ekranına yazılması sağlandı.

~~~ C#
static void Main(string[] args)
{
CONTROL:
    Console.Write("Lütfen bir ifade giriniz: ");
    string veri = Console.ReadLine();
    if (!ExOhKontrol(veri))
    {
        Console.WriteLine("Girilen ifade hatalıdır. Lütfen tekrar deneyiniz.");
        goto CONTROL;
    }
    Console.WriteLine("Sonuç: " + ExOh(veri));

    Console.ReadKey();
}
~~~