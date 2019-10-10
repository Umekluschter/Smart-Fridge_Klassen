using System;
using System.Collections.Generic;
using System.Text;

namespace Smart_Fridge_Klassen
{
    class Kuehlschrank
    {
        public Ebene[] Ebenen { get; } 

        public Kuehlschrank()
        {
            Ebenen = new Ebene[5];

            for (int i = 0; i < 5; i++)
            {
                Ebenen[i] = new Ebene(3);
            }
        }

        public void AddProdukt(Produkt produkt, int anzProdukte)
        {

        }


    }
}
