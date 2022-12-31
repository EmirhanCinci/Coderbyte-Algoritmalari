# 32_SimpleSymbols Algoritma Sorusu

* İşlevin geçirilen str parametresini almasını ve dizgiyi true veya false döndürerek kabul edilebilir bir dizi olup olmadığını belirlemesini sağlayın. str parametresi, aralarında birkaç karakter bulunan + ve = sembollerinden oluşacaktır. Dizgenin doğru olması için her harfin bir + sembolü ile çevrelenmesi gerekir. Dize boş olmayacak ve en az bir harf içerecektir.

## Örnek Girdi ve Çıktılar

~~~ C#
Console.WriteLine(SimpleSymbols("++d+===+c++==a"));
// Çıktı: false
Console.WriteLine(SimpleSymbols("+d+=3=+s+"));
// Çıktı: true
Console.WriteLine(SimpleSymbols("f++d+"));
// Çıktı: false
~~~ 

## Yazdığım Kodları Adım Adım İnceleyelim.

* İlk olarak kullanıcı tarafından girilen string bir ifadedeki tüm karakterleri küçük harflere dönüştürdük.

* Daha sonrasında metodun false olma durumları incelendi. Bunlar sırasıyla ilk ve son karakterler harf ise false değeri döndürür. İlk ve son karakterler haricinde harflerin bir önceki ve bir sonraki karakterleri + karakteri değilse false değeri döner.

* Eğer bu kontrollerin hiçbirine takılmazsa false değeri döner.

~~~ C#
public static bool SimpleSymbols(string veri)
{
    veri = veri.ToLower();
    for (int i = 0; i < veri.Length; i++)
    {
        if (i == 0 || i == veri.Length - 1)
        {
            if (veri[i] >= 97 && veri[i] <= 122)
            {
                return false;
            }
        }
        if (veri[i] >= 97 && veri[i] <= 122)
        {
            if (veri[i -1] != '+' || veri[i + 1] != '+')
            {
                return false;
            }
        }
    }
    return true;
}
~~~

* Main metodu içerisine ise kullanıcının uygun yönergeler ile işlemlerin yapılması ve istenilen çıktının console ekranına yazılması sağlandı.

~~~ C#
static void Main(string[] args)
{
    Console.Write("Lütfen bir ifade giriniz: ");
    string veri = Console.ReadLine();
    Console.WriteLine("Sonuç: " + SimpleSymbols(veri));

    Console.ReadKey();
}
~~~