using System;

namespace TablicObiektowa
{
    class Program
    {
        static void Main()
        {
            Tablica tablica = new Tablica();
            int iterator = 0;

            do
            {                               
                tablica.WyswietlTablice();
                tablica.WstawPionek(tablica.GdziePostawicPionek(iterator));
                iterator++;
                Console.Clear();
            }
            while (tablica.CzyZapisanaTablica() == false);
            {
                
                tablica.WyswietlTablice();
                tablica.PokazMiejscaPionkow();

            }

            

        }
    }
}
