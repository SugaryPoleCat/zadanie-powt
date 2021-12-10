using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadaniePowtorkowe
{
    internal class FormatTytulException : Exception
    {
        /// <summary>
        /// Wypisz error i daj prawidwole exception, na podstawie tytulu.
        /// </summary>
        /// <param name="message">Wiadomosc do wypisania</param>
        public FormatTytulException(string message) : base(message)
        {
        }
    }
}
