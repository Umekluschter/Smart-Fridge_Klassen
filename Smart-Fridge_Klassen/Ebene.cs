using System;
using System.Collections.Generic;
using System.Text;

namespace Smart_Fridge_Klassen
{
    public class Ebene
    {
        public int AnzVorhandeneProdukte { get; }
        public int MaxAnzProdukte { get; private set; }
        public Produkt[] Produkte { get; }



        public Ebene(int anzMoeglicheProdukte)
        {
            MaxAnzProdukte = anzMoeglicheProdukte;

            Produkte = new Produkt[MaxAnzProdukte];
        }

        public void AddProdukt(Produkt produkt, int anzProdukte)
        {
            //if Abfrage, welche schaut ob Produkt schon vorhanden ist, oder ob es schon 10 hat.
            //Wenn OK, werden die Produkte eingefügt.
        }

        public void RemoveProdukt(Produkt produkt, int anzProdukte)
        {

        }
    }
}
