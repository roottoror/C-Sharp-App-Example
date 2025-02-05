using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOrnek
{
    internal class Kisiler
    {
        public void kisilistesi(string adsoyad,string yası,string meslek)
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(adsoyad,yası,meslek);
            }
        }
    }
}
