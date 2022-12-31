# 23_CodelandUsernameValidation Algoritma Sorusu

* İşlevin, iletilen str parametresini almasını ve aşağıdaki kurallara göre dizenin geçerli bir kullanıcı adı olup olmadığını belirlemesini sağlayın:
    1-) Kullanıcı adı 4 ile 25 karakter arasındadır.
    2-) Harf ile başlamalıdır.
    3-) Sadece harf, rakam ve alt çizgi karakteri içermelidir.
    4-) Alt çizgi karakteri ile bitemez.
* Kullanıcı adı geçerliyse, programınız true dizesini döndürmelidir, aksi takdirde false dizesini döndürmelidir.

## Örnek Girdi ve Çıktılar

~~~ C#
Console.WriteLine(CodelandUsernameValidation("aa_"));
// Çıktı: false
Console.WriteLine(CodelandUsernameValidation("u__hello_world123"));
// Çıktı: true
Console.WriteLine(CodelandUsernameValidation("12a_s5aaa"));
// Çıktı: false
Console.WriteLine(CodelandUsernameValidation("u__hello_world123_"));
// Çıktı: false
~~~

## Yazdığım Kodları Adım Adım İnceleyelim.

* İlk olarak ilk kuralımız olan kullanıcı adı uzunluğu kontrolü yapılır. İstenilen uzunluk arasında değilse false değeri döndürür.

* İkinci olarak kullanıcıdan alınan ifade harf ile başlamalıdır. Bu nedenle string değişkenin ilk karakterinin ASCII kodları ile kontrol edildi. Eğer harf ile başlamıyorsa false değeri döndürürür.

* Üçüncü olarak alt çizgi karakteri içermiyorsa false değeri döndürür.

* Son olarak girilen ifade içerisinde rakamlar var mı yok mu o kontrol edilir. Eğer var ise true değeri döndürülür. Tabi ki true değeri döndürebilmesi için diğer if blokları içerisine girmemesi lazım.

~~~ C#
public static bool CodelandUsernameValidation(string veri)
{
    if (veri.Length < 4 && veri.Length > 25)
    {
        return false;
    }
    if (veri.EndsWith("_"))
    {
        return false;
    }
    if (!((veri[0] >= 65 && veri[0] <= 90) || (veri[0] >= 97 && veri[0] <= 122)))
    {
        return false;
    }
    if (!veri.Contains("_"))
    {
        return false;
    }
    char[] rakamlar = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    foreach (var item in veri)
    {
        if (rakamlar.Contains(item))
        {
            return true;
        }
    }
    return true;
}
~~~

* Main metodu içerisine ise kullanıcının uygun yönergeler ile işlemlerin yapılması ve istenilen çıktının console ekranına yazılması sağlandı.

~~~ C#
static void Main(string[] args)
{
    Console.Write("Lütfen bir kullanıcı adı giriniz: ");
    string veri = Console.ReadLine();
    Console.WriteLine("Sonuç: " + CodelandUsernameValidation(veri));

    Console.ReadKey();
}
~~~