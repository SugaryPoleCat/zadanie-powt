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
        private string sygnatura;
        private DateTime dataWydania;
        private decimal cenaPodstawowa;

        /// <summary>
        /// Statyczny konstruktor, ktory ustawia rzeczy
        /// </summary>
        /// <param name="ind">Indeks</param>
        /// <param name="cD">Cena Dodatkowa</param>
        static Publikacja()
        {
            indeks = 1;
            cenaDodatkowa = 1.5m;
        }

        /// <summary>
        /// Konstruktor domyslny, nie zawiera parametrow, tylko ustawia wartosci
        /// </summary>
        public Publikacja()
        {
            // SYG-00001; 
            // index = index + 1;
            // w sygnaturze index ma byc zwiekszany o 1.
            int ind = indeks;
            indeks++;
            //sygnatura = $"SYG-{ind.ToString("D").Length + 4}";
            this.sygnatura = $"SYG-{ind:0000}";
        }

        /// <summary>
        /// Kontruktor parametryczny ma dodatkowo parametry, w przeciwienstie do domyslnego
        /// </summary>
        /// <param name="dW">Data wydania</param>
        /// <param name="cP">Cena podstawowa</param>
        public Publikacja(string dW, decimal cP) : this()
        { 
            // dataWydania = dW;
            //DateTime.TryParse(dW, out dataWydania);
            DateTime.TryParseExact(dW, new string[] { "dd-MMM-yyyy" }, null, System.Globalization.DateTimeStyles.None, out dataWydania);
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

        /// <summary>
        /// Przeslonienie ToString zeby printowac syugnatura, obliczcene, datawydania w formacie dd-MMM-yyyy
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            decimal cena = ObliczCene();
            return $"{sygnatura}, {ObliczCene().ToString("C")}, {dataWydania:dd-MMM-yyyy}";
        }
    }
}