

// 1. tanımlama yöntemi
using System.Collections;

Personel p = new Personel();
p.Ad = "Nihat";
p.Soyad = "Şahin";
p.Yas = 30;




// 2 . tanımlama yöntemi 
Personel p1 = new Personel()
{
    Ad = "Nihat",
    Soyad = "Şahin",
    Yas = 60,
};

// Konu : Peki biz nesne heap bölgesinde oluşturulurken verileride yanında götürüp, tek seferde
// bu işlemi yapamaz mıyız ?

// Default Ctor  Çalıştı ve Nesne içerisindeki her bir değişkenin default değerini 
// bellekte allocate etti

Personel p2 = new Personel();
Console.WriteLine(p2.Ad);
Console.WriteLine(p2.Yas);

Personel p3 = new Personel();
Console.WriteLine(p3.Ad);
Console.WriteLine(p3.Yas);


// DEfault Ctor içerisnde bir değer tanımlaması olduğu için, her nesne o tanımlarla bellege gidecektir
// yukarıdaki nesneleri ekrana yazdırdığımızda, "Muhittin Kemal 70 dğerini göreceğiz.


// 3 parametreli ctor yazdık, bu ctor'u kullanarak bir nesne oluşturalım 

Personel p4 = new Personel("Yaşar","Kemal",80);

Console.WriteLine(p4.Ad);
Console.WriteLine(p4.Yas);
Console.WriteLine(p4.Soyad);





Araba a = new Araba();
a.Marka="BMW";
a.Model="420";


Araba a1 = new Araba();
a1.Marka="BMW";
a1.Model="530";


Araba a2 = new Araba();
a2.Marka="BMW";
a2.Model="670";


Araba a3 = new Araba();
a3.Marka="Mercedes";
a3.Model="C 200";


Araba a4 = new Araba();
a4.Marka="MErcedes";
a4.Model="S500";


Araba a5 = new Araba();
a5.Marka="Toyota";
a5.Model="Corolla";

//Ekrana bastıralım

ArrayList arabaListesi = new ArrayList();
arabaListesi.Add(a1);
arabaListesi.Add(a2);
arabaListesi.Add(a3);
arabaListesi.Add(a4);
arabaListesi.Add(a5);

foreach(Araba araba in arabaListesi){

    Console.WriteLine("Marka : {0}",araba.Marka);
    Console.WriteLine("Model : {0}",araba.Model);
    Console.WriteLine("Şasi : {0}",araba.SaseNo);
}


