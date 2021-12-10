using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ZadaniePowtorkowe
{
    internal class Biblioteczka : ICloneable, IEquatable<Publikacja>, IComparable<Publikacja>
    {
        string nazwa;
        List<Publikacja> publikacje;

        /// <summary>
        /// Konstruktor inicjalizuje kolekcje
        /// </summary>
        public Biblioteczka()
        {
            // inicjalizuje kolekjcje
        }

        /// <summary>
        /// Konstruktor ustawia nazwe i wywoluje Bibilioteczka()
        /// </summary>
        public Biblioteczka(string nazwa) : this()
        {
            // ustaw
            this.nazwa = nazwa;

        }

        /// <summary>
        /// Konstruktor pobiera nazwe i publikajce
        /// </summary>
        /// <param name="cycki">jeszcze nie wiem czy potrzeba</param>
        /// <param name="dupa">jeszcze nie wiem czy potrzeba</param>
        public Biblioteczka(string cycki, string dupa)
        {
            // pobiera nazwe oraz publikacje.
            // dodaj publikacje do Biblioteczka
            // w tym momencie wywolaj konstruktor z nazwa
            // potem wywolaj metode Dodaj(Publikacja)
        }

        /// <summary>
        /// Dodaj nowa publikacje (nie moze byc null) na koniec kolekcji
        /// </summary>
        /// <param name="ubikacja">Publikacja</param>
        public void Dodaj(Publikacja ubikacja)
        {
            // musi miec pewnie trycatch bo nie moze byc null
            // tez moze byc w formacie try/catch

            /*
             * try{
             * publikacje.Add(ubikajce);
             * }
             * catch(ArgumentNullException e){
             * Console.WriteLine(e);
             * return;
             * }
             * catch(Exception e){
             * Console.WriteLine(e);
             * return;
             * }
             */

            // ale nie wiem czy wogule .Add moze dodac kompletenie pusty obiekt
            // BEZ wywolywania Exception.
            // moze trzeba uzyc odpowiedniego exception?
            if (ubikacja is null)
            {
                throw new ArgumentNullException();
                // mozna tez zrobic throw new exception, zeby pokazac error ze jest to null.
            }

            publikacje.Add(ubikacja);
        }

        /// <summary>
        /// Wstawia publikacje (nie moze byc null) na okreslona pozycje w kolekcji
        /// </summary>
        /// <param name="indeks">Pozycja</param>
        /// <param name="ubikacja">Publikcja</param>
        public void Wstaw(int indeks, Publikacja ubikacja)
        {
            // to samo co dodaj
        }

        /// <summary>
        /// Usuwa publikacje na danym indeksie
        /// </summary>
        /// <param name="indeks">Pozycja</param>
        public void Usun(int ind)
        {
            try {
                // najpierw znajdz publikacje
                //Publikacja p = publikacje.FirstOrDefault(pub => pub.indeks.Equals(ind));

            // potem ja usun.
                
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }
        }

        /// <summary>
        /// Zamien stara publikacje na nowa
        /// </summary>
        /// <param name="stara">Stara publikacja</param>
        /// <param name="nowa">Nowa publikacja</param>
        public void Zamien(Publikacja stara, Publikacja nowa)
        {

        }

        /// <summary>
        /// Wyswietla informacje o biblioteczce
        /// </summary>
        /// <returns>Info o bibliotece</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            
            // budujemy informacje o biblioteczce.
            // appendline: na koniec stringa, dodaj nowa linie z naszym tekstem/wartosiciami.
            sb.AppendLine();

            return sb.ToString();
        }

        /// <summary>
        /// nie wiem na chuj ten clone
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public object Clone()
        {
            throw new NotImplementedException();
        }

        // to kurwa wiadmom
        public bool Equals(Publikacja other)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///  na hcuj na to
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public int CompareTo(Publikacja other)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Zapisz nowy plik
        /// </summary>
        /// <param name="fileName"></param>
        public void ZapiszXML(string fileName)
        {
            XmlSerializer xs = new XmlSerializer(typeof(Biblioteczka));
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                xs.Serialize(sw, this);
            }
        }

        /// <summary>
        /// Odczytaj XML pliku
        /// </summary>
        /// <param name="nazwaPliku"></param>
        /// <returns>nowy objekt typu Biblioteczka</returns>
        public static Biblioteczka Odczytaj(string nazwaPliku)
        {
            try
            {
                // odczytaj plik
                StreamReader sr = new StreamReader(nazwaPliku);
                // serializacja naszej biblioteczki
                XmlSerializer xs = new XmlSerializer(typeof(Biblioteczka));
                // deserializacja pliku i zapisywanie jako nowy objekt Biblioteczki.
                Biblioteczka z = (Biblioteczka)xs.Deserialize(sr);
                sr.Close();
                return z;
            }
            catch (FileNotFoundException)
            {
                return null;
            }
        }
    }
}
