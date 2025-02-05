using ConsoleOrnek;

internal class Program
{
    private static void Main(string[] args)
    {
        //Mesaj msj=new Mesaj();
        //msj.metin();
        Kisiler kisiler = new Kisiler();
        string AdıSoyadı, Meslegi, Yasi;
        Console.WriteLine("Kişinin adını soyadını mesleğini ve yaşını giriniz");
        AdıSoyadı =Console.ReadLine();
        Meslegi = Console.ReadLine();
        Yasi = Console.ReadLine();
        kisiler.kisilistesi(AdıSoyadı,Meslegi,Yasi);
        Console.Read();
    }
}