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
            // ustaw parametry statyczne
            // one beda uzywane przez wszystkie instancje publikacji
            // czyli przez wszystkie Publikacja nazwa = new Publikacja;
            // nigdy nie beda zmieniane.
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
            // :0000 = formatuje INT z 4 cyframi, dynamiczne
            // czyli jak mamy int 23, to print bedzie: 0023
            // jezili mamy int 1 to print bedzie 0001
            this.sygnatura = $"SYG-{indeks:0000}";
            // potem zwieksz indeks
            indeks++;
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

            // muysimy obliczyc ile lat minelo od daty wydania, zeby obliczyc nowa cene.
            // czemu to drozeje co roku? nikt kurwa nie wie.
            DateTime now = DateTime.Now;
            // w C# mozna wyciagnac .Year czyli rok z naszej daty.
            decimal age = now.Year - dataWydania.Year;
            // rob obliczenie.
            return cenaPodstawowa + cenaDodatkowa * age;
        }

        /// <summary>
        /// Przeslonienie ToString zeby printowac syugnatura, obliczcene, datawydania w formacie dd-MMM-yyyy
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            // mozna to teraz publikacja.ToString() i STANDARDOWO wyprintuje w konsoli nasza return linijke. 
            // decimal cena = ObliczCene();
            // ^ DO DEBUGU OBLICZ CENA CZY DZIALA

            // dataWydania:dd-MMM-yyyy ; formatuje nasz print czyli output naszej daty w tym formacie
            //ObliczCene().tostirng("c") formatuje nasz RETURN funkcjhi oblizcena w formacie Currency.,
            // toString("c") - c oznacza Currency, tylko musi byc duze C.
            return $"{sygnatura}, {ObliczCene().ToString("C")}, {dataWydania:dd-MMM-yyyy}";
        }
    }
}