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
            // static
            Publikacja.index(1, 1.5m);
            // domyslny
            Publikacja dupa = new Publikacja();
            // parametryczny
            Publikacja cycki = new Publikacja();

            Console.ReadKey();
        }
    }
}
