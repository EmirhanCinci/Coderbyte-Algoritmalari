# 25_LargestPair Algoritma Sorusu

* İşlevin geçirilen num parametresini almasını ve tam sayı içindeki en büyük çift basamaklı sayıyı belirlemesini sağlayın. Giriş her zaman en az iki pozitif basamak içerecektir.

## Örnek Girdi ve Çıktılar

~~~ C#
Console.WriteLine(LargestPair(4759472));
// Çıktı: 94 
Console.WriteLine(LargestPair(453857));
// Çıktı: 85
Console.WriteLine(LargestPair(363223311));
// Çıktı: 63
~~~

## Yazdığım Kodları Adım Adım İnceleyelim.

* Algoritmamızın çalışması için kullanıcıdan bir pozitif tam sayı girmesini istediğimiz için ilk olarak pozitif tam sayı kontrolü yapılır. Yani kullanıcı pozitif bir tam sayı yerine metinsel ifade, işaretler veya pozitif tam sayı olmayan sayılar girebilir. Bunun için bir hata kontrolü yapıldı.

~~~ C#
public static bool PozitifTamSayiMi(string veri)
{
    try
    {
        uint sayi = (uint)Convert.ToUInt64(veri);
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

* Kullanıcının girdiği pozitif tam sayıyı string veri tipine dönüştürürüz. Daha sonra for döngüsü yardımı ile sayının ilk karakterden son karakterine kadar bir kontrol ve işlemler yaparız. 

* Burada ikili ikili olarak karakterler alınır ve enButuk değerle kıyaslama yapılarak enBuyuk değer bulunur. For döngüsünden sonra enBuyuk değer buluur ve int formatta döndürülür.

~~~ C#
public static int LargestPair(uint sayi)
{
    int enBuyuk = 0;
    string veri = sayi.ToString();
    for (int i = 0; i < veri.Length - 1; i++)
    {
        string metin = veri[i].ToString() + veri[i + 1].ToString();
        int gecici = Convert.ToInt32(metin);
        if (gecici > enBuyuk)
        {
            enBuyuk = gecici;
        }
    }
    return enBuyuk;
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
    uint sayi = (uint)Convert.ToUInt64(veri);
    Console.WriteLine("Sonuç: " + LargestPair(sayi));

    Console.ReadKey();
}
~~~