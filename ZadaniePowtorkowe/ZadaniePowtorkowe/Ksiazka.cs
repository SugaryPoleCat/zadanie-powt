using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadaniePowtorkowe
{
    enum EnumDziedzina { ekonomia, informatyka, zarzadzanie };
    class Ksiazka : Publikacja
    {
        private string tytul;
        private EnumDziedzina dziedziny;

        private string tajtel(string taj)
        {
            // sprawdza czy tytul zaczyna sie od duzej litery
            for(int i = 0; i < taj.Length; i++)
            {
                if (!char.IsUpper(taj[i]))
                {
                    throw new FormatTytulException("Tytul nie zaczyna sie z duzej litery");
                }
            }

            return taj;
        }

        public Ksiazka(string dW, decimal cP, string title, EnumDziedzina dziedzina) : base(dW, cP)
        {
            // musi uzyc konstruktor parametrowy z klasy Publikacja
            
            // musimy sprawdzac czy zaczyna sie od duzej litery tytul.
            // jezeli tak, to tytul bedzie zapisany returnem z funkcji tajtel
            tytul = tajtel(title);

            // ma tez modyfikowac sygnature zeby miala na koncu -E, -I, -Z na podstawie dziedziny.
            // to akurat jest proste , bo mozna zrobic char.index czy cos takiegop
            dziedziny = dziedzina;
            switch (dziedzina)
            {
                case EnumDziedzina.informatyka:
                    base.sygnatura += "-I";
                    break;
                case EnumDziedzina.ekonomia:
                    base.sygnatura += "-E";
                    break;
                case EnumDziedzina.zarzadzanie:
                    base.sygnatura += "-Z";
                    break;
            }
        }

        public override decimal ObliczCene()
        {
            // OBLICZAMY CENE OVERRIDE
            // po polsku POWIELANIE


            // ZEBY obliczyc cene, trzeba najpierw zadeklarowac cene z KALSY BAZOWEJ
            // czyli z ktorej dziedziczymy funkcje
            // ZEBY obliczenia zostaly wykonane, bez potrzeby wpisywania kodu od nowa
            decimal cena = base.ObliczCene();
            // na postawie ktora to dziedizna dodac cene dodatkowa.
            switch (dziedziny)
            {
                // na podstawie naszego enum, dodaj odpowiednia cene.
                case EnumDziedzina.ekonomia:
                    cena += 50;
                    break;
                case EnumDziedzina.informatyka:
                    cena += 100;
                    break;
                case EnumDziedzina.zarzadzanie:
                    cena += 20;
                    break;
                default:
                    break;
            //cena += (EnumDziedzina)0;
            }

            return cena;
            //return base.ObliczCene();
        }

        public override string ToString()
        {
            // POPATRZ NA PUBLIKACJA BO TO TO SAMO

            // ma wypisywac
            // (np., SYG-00003-I, 166,00 zł, 17-kwi-2019, "Język C# 9.0", informatyka).
            string outp = base.ToString();
            return $"{outp}, \"{tytul}\", {dziedziny}";
        }
    }
}