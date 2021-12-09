using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadaniePowtorkowe
{
    internal class Publikacja
    {
        static int index;
        static decimal cenaDodatkowa;
        static string sygnatura;
        static DateTime dataWydania;
        static decimal cenaPodstawowa;

        static void indeks(int ind, decimal cD)
        {
            index = ind;
            cenaDodatkowa = cD;
        }
    }
}
