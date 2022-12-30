# 07_CamelCase Algoritma Sorusu

* 

## Örnek Girdi ve Çıktılar

~~~ C#
Console.WriteLine(CamelCase("BOB loves-coding"));
// Çıktı: bobLovesCoding
Console.WriteLine(CamelCase("cats AND*Dogs-are Awesome"));
// Çıktı: catsAndDogsAreAwesome
Console.WriteLine(CamelCase("a b c d-e-f%g"));
// Çıktı: aBCDEFG
~~~

## Yazdığım Kodları Adım Adım İnceleyelim.

* İlk olarak string formatta içi boş bir sonuc değişkeni tanımlanır ve kullanıcının girdiği ifadeyi küçük harflere dönüştürürüz.

* Daha sonra for döngüsü içerisinde kullanıcının girdiği ifadedeki karakter tek tek incelenir. Eğer karakter küçük harf değilse sonuc değişkenine bir boşluk tanımlanır. Eğer harf ise tekrar bir kontrol işlemi olur.

* Eğer karakter küçük harf ise kontrol işlemi şu şekilde olur. İlk karakter olup olmadığını kontrol etmek için indexin 0'a eşit olup olmadığı kontrol edilir ve bir önceki karakterin boşluk karakteri olup olmadığına bakılır. Yani girilen verinin ilk karakteri değilse ve bir önceki karakter boşluk karakteri ise o karakter büyük harf olarak sonuc değişkenine eklenir. Şartlar sağlanmıyorsa olduğu gibi harf eklenir.

* Son olarak sonuc değişkenindeki boşluklar kaldırılır ve sonuc değişkeni döndürülür.

~~~ C#
public static string CamelCase(string veri)
{
    string sonuc = "";
    veri = veri.ToLower();
    for (int i = 0; i < veri.Length; i++)
    {
        if (veri[i] < 97 || veri[i] > 122)
        {
            sonuc += " ";
        }
        else
        {
            if (i != 0 && sonuc[i - 1] == ' ')
            {
                sonuc += veri[i].ToString().ToUpper();
            }
            else
            {
                sonuc += veri[i].ToString();
            }
        }
    }
    sonuc = sonuc.Replace(" ", "");
    return sonuc;
}
~~~

* Main metodu içerisine ise kullanıcının uygun yönergeler ile işlemlerin yapılması ve istenilen çıktının console ekranına yazılması sağlandı.

~~~ C#
static void Main(string[] args)
{
    Console.Write("Lütfen bir ifade giriniz: ");
    string veri = Console.ReadLine();
    Console.WriteLine("Sonuç: " + CamelCase(veri));

    Console.ReadKey();
}
~~~ 