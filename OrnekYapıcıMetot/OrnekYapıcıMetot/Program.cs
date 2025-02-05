using OrnekYapıcıMetot;

internal class Program
{
    private static void Main(string[] args)
    {
        //string blg;
        //Console.Write("Ad-Kulüp ");
        //blg = Console.ReadLine();
        //Ogrenci ogrenci = new Ogrenci(blg);
        //Console.Read();
        Kimlik kimlik = new Kimlik();
        kimlik.AD = "Ahmet";
        kimlik.SOYAD = "met";
        kimlik.MEMLEKET = "İstanbul";
        kimlik.YAS = 20;
        Console.WriteLine(kimlik.AD);
        Console.WriteLine(kimlik.SOYAD);
        Console.WriteLine(kimlik.MEMLEKET);
        Console.WriteLine(kimlik.YAS);


    }
}