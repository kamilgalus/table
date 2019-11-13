using System;
using System.Collections.Generic;


namespace TablicaiPionki
{
    class Program
    {
        static void Main()
        {

            Pionek TabelaGlowna = new Pionek();                       //Tworze obiekt z którego tabeli będę korzystał ( jedna tabela na której pracuję )            
            List<Pionek> ListaObiektow = new List<Pionek>();          //Kolekcja służąca do dodawania obiektów (pionków) 
            int i;                                                    //Tworze zmienna ktora bedzie przechowywac indeks tablicy na ktorej chce zmienic znak 
            bool czyTablicaZapisana;                                  // Zmienna potwierdzająca uzupełnioną tablice
            int indeksTablicy = 0;                                    //Zmienna która iteruje tablice obiektow 

            TabelaGlowna.NadajWartoscTablicy(TabelaGlowna.tabela);     //Nadaje wartość tej nowej tablicy


            do
            {
                ListaObiektow.Add(new Pionek());                       //Dodaje do kolekcji obiekt klasy Pionek 
                TabelaGlowna.WyswietlTablice(TabelaGlowna.tabela);     //Wyswietlam tabele                              


                i = ListaObiektow[indeksTablicy].PodajPozycjePionka();                                                                 // Przypisuje jej zwracaną liczbę którą uzytkownik wybrał 
                TabelaGlowna.tabela = TabelaGlowna.UstawPionek(i, TabelaGlowna.tabela, ListaObiektow[indeksTablicy].pionek);           // w podanym indeksie tablicy zmieniam wartośc na znak pionka oraz przypisuje zwracaną tablice oryginalnej tablicy (czy mógłbym przez referencje pracować na tej tablicy?) 

                czyTablicaZapisana = TabelaGlowna.SprawdzTablice(TabelaGlowna.tabela, ListaObiektow[indeksTablicy].tabela);            // Porownując Tabele Głowną z uzupelniona Tabla Pionka sprawdzam czy w Tabeli Glownej na wszystkich miejscach stoją pionki
                Console.Clear();

                indeksTablicy++;                                                   // Zmienia indeks kolekcji "ListaObiektow", przmieszczając się miedzy obiektami 
            }
            while (czyTablicaZapisana == false);                                   // Jeśli FALSE to znaczy, że tabela ma jeszcze wolne miejsca na ktorych moze stanac pionek 
            {
                Console.Clear();
                Console.WriteLine("TABLICA ZAPISANA");
            }
        }


    }
}