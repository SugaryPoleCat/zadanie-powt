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

        /// <summary>
        /// Kontruktor parametryczny ma dodatkowo parametry, w przeciwienstie do domyslnego
        /// </summary>
        /// <param name="dW">Data wydania</param>
        /// <param name="cP">Cena podstawowa</param>
        public Publikacja(DateTime dW, decimal cP) {
            dataWydania = dW;
            cenaPodstawowa = cP;
        }

        /// <summary>
        /// Oblicz cene od daty wydania do teraz, na podstawie ceny podstawowej i dodatkowej.
        /// </summary>
        /// <returns>Decimal(cP + cD * age)</returns>
        virtual public decimal ObliczCene()
        {
            // * dataWydania jako DECIMNAL
            // liczba lat od daty wydania
            // czyli NOW - dataWydania;
            DateTime now = DateTime.Now;
            decimal age = now.Year - dataWydania.Year;
            return cenaPodstawowa + cenaDodatkowa * age;
        }
    }
}