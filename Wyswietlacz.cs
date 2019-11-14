using System;


namespace TabelaiPionki
{
    class Wyswietlacz
    {
        public int[] tablicaUstawionychPionkow = new int[5];   // tablica ktora będzie przechowywać inforamcje ktory pionek z koleji stoi na ktortym miejscu

        /* public Wyswietlacz()
        {
            for (int i = 0; i < 5; i++)          //Konstruktor zerujacy tablice 
            {
                miejsceKolejnychPionkow[i] = 0;
            }
        } 
        */

        public void UstawienieKolejnychPionkow(int nrPionka, int nrMiesjca, int[] tablica)  //Ustawia cyfry(nr pionka) na miejscu wybieranym przez uzytkownika 
        {
            tablica[nrMiesjca - 1] = nrPionka + 1;
        }

        public void WyswietlanieKolejnosciPionkow()           // Pokazuje ktory pionek jest na jakim miejscu (np. Pionek nr2 jest na miejscy 3: _ _ 2 _ _) 
        {
            Console.Write("Ustawienie pionkow w tabeli: ");
            for (int i = 0; i < tablicaUstawionychPionkow.Length; i++)
            {
                Console.Write(tablicaUstawionychPionkow[i]);
            }
            Console.WriteLine("\n");
        }

        public void WyswietlaniePozycjiPionków(int[] table)  // Pokazuje położenie konkretnego Pionka na przydzielonym mu miejscu 
        {
            char[] tablicaWypelnionaZerami = new char[5];

            for (int j = 1; j <=5; j++)
            {
                Console.Write("Pozycja {0} pionka na planszy: ", j);
                for (int i = 0; i < 5; i++)
                {                    
                    if (table[i] == j)
                    {
                        tablicaWypelnionaZerami[i] = '#';
                    }
                    else
                    {
                        tablicaWypelnionaZerami[i] = '_';
                    }
                    Console.Write(tablicaWypelnionaZerami[i]);
                }
               Console.WriteLine();
            }
        }
    }
}
