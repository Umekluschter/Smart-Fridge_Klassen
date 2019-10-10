using System;

namespace Smart_Fridge_Klassen
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        public void Start()
        {
            Kuehlschrank kuehler = new Kuehlschrank();
            Produkt milch = new Produkt(1, "Milch", 1.5m, 1);

            kuehler.AddProdukt(milch, 1);
        }
    }
}
