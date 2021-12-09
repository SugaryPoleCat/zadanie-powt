using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadaniePowtorkowe
{
    class Publikacja
    {
        static int indeks;
        static decimal cenaDodatkowa;
        static string sygnatura;
        static DateTime dataWydania;
        static decimal cenaPodstawowa;

        /// <summary>
        /// Statyczny konstruktor, ktory ustawia rzeczy
        /// </summary>
        /// <param name="ind">Indeks</param>
        /// <param name="cD">Cena Dodatkowa</param>
        static public void index(int ind, decimal cD)
        {
            indeks = ind;
            cenaDodatkowa = cD;
        }

        /// <summary>
        /// Konstruktor domyslny, nie zawiera parametrow, tylko ustawia wartosci
        /// </summary>
        public Publikacja()
        {
            // SYG-00001; 
            // index = index + 1;
            // w sygnaturze index ma byc zwiekszany o 1.
            int ind = indeks + 1;
            sygnatura = $"SYG-{ind}";
        }

        public int 
    }
}
