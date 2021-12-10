using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadaniePowtorkowe
{
    class Ksiazka : Publikacja
    {
        private string tytul;
        private enum EnumDziedzina { ekonomia, informatyka, zarzadzanie };

        /*
        private string tajtel(string taj)
        {
            // sprawdza czy tytul zaczyna sie od duzej litery
            for(int i = 0; i < taj.Length; i++)
            {
                try
                {
                    if () { }
                    else { }
                }
                catch(FormatTytulException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        */

        public Ksiazka(string dW, decimal cP, string title, string dziedzina) : base(dW, cP)
        {
            // musi uzyc konstruktor parametrowy z klasy Publikacja


        }

        public override decimal ObliczCene()
        {
            // OBLICZAMY CENE OVERRIDE
            // po polsku POWIELANIE


            // na podstawie ktora to dziedizna dodac cene dodatkowa.
            


            return base.ObliczCene();
        }

        public override string ToString()
        {
            // POPATRZ NA PUBLIKACJA BO TO TO SAMO

            // (np., SYG-00003-I, 166,00 zł, 17-kwi-2019, "Język C# 9.0", informatyka). 

            return base.ToString();
        }
    }
}
