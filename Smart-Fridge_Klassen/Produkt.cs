using System;
using System.Collections.Generic;
using System.Text;

namespace Smart_Fridge_Klassen
{
    public class Produkt
    {
        public int Nummer { get; set; }
        public String Name { get; set; }
        public decimal Preis { get; set; }
        public int Menge { get; set; }

        public Produkt(int nummer, String name, decimal preis, int menge)
        {
            Nummer = nummer;
            Name = name;
            Preis = preis;
            Menge = menge;
        }
    }
}
