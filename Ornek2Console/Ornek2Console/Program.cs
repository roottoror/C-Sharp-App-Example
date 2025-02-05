using Ornek2Console;

internal class Program
{
    private static void Main(string[] args)
    {
        Islem islem=new Islem();
        //islem.topla(5,2);
        //islem.kareal(2);
        Console.WriteLine("Birinci Sayiyi Giriniz:");
        int BirinciSayi = int.Parse(Console.ReadLine());
        Console.WriteLine("İkinci Sayiyi Giriniz:");
        int İkinciSayi= int.Parse(Console.ReadLine());
        islem.DortIslem(BirinciSayi,İkinciSayi);
        Console.Read();
    }
}