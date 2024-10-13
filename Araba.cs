public class Araba{


    public string SaseNo;
    public string Marka;
    public string Model;
    

    public Araba()
    {
        //Default Ctor'da, şase no ürettik
        
        // Buraya yazılacak yorumu salı gününe bırakıyorum !!!
        SaseNo=new Random().Next().ToString();
    }
}