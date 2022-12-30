# 17_ABCheck Algoritma Sorusu

* Girilen string bir ifadenin içerisindeki a ve b karakterlerinin arası bir kez 3 karakter ise true; değil ise false döndürülmesini sağlayın.

## Örnek Girdi ve Çıktılar

~~~ C#
Console.WriteLine(ABCheck("after badly"));
// Çıktı: false
Console.WriteLine(ABCheck("Laura sobs"));
// Çıktı: true
~~~

## Yazdığım Kodları Adım Adım İnceleyelim.

* Kullanıcı tarafından girilen string bir ifadedeki a ve b karakterleri arasındaki uzaklık 3 karakter ise true, değilse false değerini döndüren metottur.

~~~ C#
public static bool ABCheck(string text)
{
    for (int i = 0; i < text.Length; i++)
    {
        if ((text[i] == 'a' && (i + 4) < text.Length && text[i + 4] == 'b') || (text[i] == 'b' && (i + 4) < text.Length && text[i + 4] == 'a'))
        {
            return true;
        }
    }
    return false;
}
~~~

* Main metodu içerisine ise kullanıcının uygun yönergeler ile işlemlerin yapılması ve istenilen çıktının console ekranına yazılması sağlandı.

~~~ C#
static void Main(string[] args)
{
    Console.Write("Lütfen bir ifade giriniz: ");
    string text = Console.ReadLine();
    if (ABCheck(text))
    {
        Console.WriteLine("Girmiş olduğunuz ifade kuralı karşılıyor.");
    }
    else
    {
        Console.WriteLine("Girmiş olduğunuz ifade kuralı karşılamıyor.");
    }

    Console.ReadKey();
}
~~~ 