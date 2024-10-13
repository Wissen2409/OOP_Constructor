public class Personel
{

    public string Ad;
    public string Soyad;
    public int Yas;

    // Ctor kuralları  : Metoda benzerler, ancak geri dönüş değerleri yoktur.
    // Ctor'un adı, sınıfın adı ile aynı olmak zorundadır.
    // ileride göreceğimiz, farklı parametreler alan ctorlar olabilir
    public Personel()
    {


        // Default Ctor : Default Ctor, nesne heap alanına giderken, bu Ctor'u çalıştırır
        // Bu ctor eğer sizin tarafınızdan yazılmazsa, derleyici bir tane yazar
        // Siz yazdığınız anda, artık derleyici yazmaz sizin yazmış olduğunuz kullanılır.

        // Ctor'ların amacı nedir ? 

        // Ctorların amacı : Nesne belleğe çıkarken ,nesneye ait verilerinde belleğe götülrülmesidir
        // Dolayısıyla : Nesne içerisindeki her bir değişkenin değerini tek tek heap alanına giderek değil de
        // tek seferde tüm verileri götürmektedir.

        // Peki ben default ctor içerisnde bir veri vermezsem ne oluyor, Yada ben ctor yazmaz ve derleyici yazarsa 
        // neden yazıyor amacı nedir ? 

        // Peki ben ctor içerisinde, değişkenlerimin başlangıç değerlerini verebilir miyim ? 

        Ad = "Muhittin";
        Soyad = "Kemal";
        Yas = 70;


    }



}