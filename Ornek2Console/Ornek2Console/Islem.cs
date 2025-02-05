using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ornek2Console
{
    internal class Islem
    {
        public int topla(int s1,int s2)
        {
            int s3 = s1 + s2;
            Console.WriteLine("Sonuç:"+s3);
            return s3;
        }
        public int kareal(int deger)
        {
            int sonuc = deger * deger;
            Console.WriteLine("Sonuç"+sonuc);
            return sonuc;
        }

        public int DortIslem(int Sayi1,int Sayi2)
        {
            int Sonuc1 = Sayi1 + Sayi2;
            int Sonuc2 = Sayi1 * Sayi2;
            int Sonuc3 = Sayi1 - Sayi2;
            int Sonuc4 = Sayi1 / Sayi2;
            Console.WriteLine("1.Sonuc "+Sonuc1+" 2.Sonuc:"+Sonuc2+" 3.Sonuc:"+Sonuc3+" 4.Sonuc:"+Sonuc4);
            return Sonuc1;


        }
    }
}
