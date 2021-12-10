using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadaniePowtorkowe
{
    class Program
    {
        static void Main(string[] args)
        {
            Publikacja dupa = new Publikacja("20-jun-2020", 20);
            Publikacja cycki = new Publikacja("20-jun-2010", 21);
            Publikacja chuj = new Publikacja("20-jun-2000", 22);
            Console.WriteLine(dupa.ToString());
            Console.WriteLine(cycki.ToString());
            Console.WriteLine(chuj.ToString());

            Console.ReadKey();
        }
    }
}
