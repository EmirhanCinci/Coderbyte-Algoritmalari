# 27_LongestWord Algoritma Sorusu

* İşlevin, iletilen str parametresini almasını ve dizedeki en uzun sözcüğü döndürmesini sağlayın. Aynı uzunlukta iki veya daha fazla kelime varsa, dizeden bu uzunluktaki ilk kelimeyi döndürün. Noktalama işaretlerini yoksayın ve str'nin boş olmayacağını varsayalım. Kelimeler aynı zamanda rakamlar da içerebilir.

## Örnek Girdi ve Çıktılar

~~~ C#
Console.WriteLine(LongestWord("fun&!! time"));
// Çıktı: time
Console.WriteLine(LongestWord("I love dogs"));
// Çıktı: love
~~~

## Yazdığım Kodları Adım Adım İnceleyelim.

* İlk olarak kullanıcı tarafından girilen string bir ifadedeki harf, rakam ve boşluk karakteri haricindeki tüm karakterlerin kaldırılmış halini döndüren metot oluşturdum.

~~~ C#
public static string HarfveSayilar(string veri)
{
    string sonuc = "";
    veri = veri.ToLower();
    for (int i = 0; i < veri.Length; i++)
    {
        if ((veri[i] >= 0 && veri[i] <= 9) || (veri[i] >= 97 && veri[i] <= 122) || veri[i] == ' ')
        {
            sonuc += veri[i];
        }
    }
    return sonuc;
}
~~~

* Kullanıcı tarafından string bir ifade girildiğinde ilk olarak ifadede sadece harf, rakam ve boşluk karakteri kalması için HarflerveSayilar(); metodu kullanılır.

* Daha sonrasında girilen ifadedeki kelimelerden oluşan bir dizi oluşturuldu ve ilk kelime sonuc değişkenine atandı.

* Son olarak bir for döngüsü ile kelimeler arasında bir uzunluk kıyaslamaları yapıldı ve en uzun kelime döndürüldü.

~~~ C#
public static string LongestWord(string veri)
{
    veri = HarfveSayilar(veri);
    string[] dizi = veri.Split(' ');
    string sonuc = dizi[0];
    for (int i = 1; i < dizi.Length; i++)
    {
        if (dizi[i].Length > sonuc.Length)
        {
            sonuc = dizi[i];
        }
    }
    return sonuc;
}
~~~

* Main metodu içerisine ise kullanıcının uygun yönergeler ile işlemlerin yapılması ve istenilen çıktının console ekranına yazılması sağlandı.

~~~ C#
static void Main(string[] args)
{
    Console.WriteLine("Lütfen bir ifade giriniz: ");
    string veri = Console.ReadLine();
    Console.WriteLine("Sonuç: " + LongestWord(veri));

    Console.ReadKey();
}
~~~