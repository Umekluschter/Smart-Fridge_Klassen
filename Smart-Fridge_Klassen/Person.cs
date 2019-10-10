using System;
using System.Collections.Generic;
using System.Text;

namespace Smart_Fridge_Klassen
{
    class Person
    {
        public String Vorname { get; set; }
        public String Name { get; set; }
        public String Strasse { get; set; }
        public String Ort { get; set; }
        public String PLZ { get; set; }
        public decimal Guthaben { get; set; }

        public List<Produkt> einkaufsListe = new List<Produkt>();

        public void CreatePerson()
        {

        }
    }
}
