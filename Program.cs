using System;
using System.Collections.Generic;


namespace TabelaiPionki
{
    class Program
    {
        static void Main()
        {
            Pionek TabelaGlowna = new Pionek();                       //Tworze obiekt z którego tabeli będę korzystał ( jedna tabela na której pracuję )     
            Wyswietlacz PolozeniePionkow = new Wyswietlacz();            
            List<Pionek> ListaObiektow = new List<Pionek>();          //Kolekcja służąca do dodawania obiektów (pionków) 
            int pozycjaPionka;                                        //Zmienna do przechowywania indeksu na ktorym użytkownik chce ustawić pionek 
            bool czyTablicaZapisana;                                  //Zmienna potwierdzająca uzupełnioną tablice
            int indeksTablicy = 0;                                    //Zmienna która iteruje kolekcje obiektow 


            
            do
            {
                ListaObiektow.Add(new Pionek());                       //Dodaje do kolekcji obiekt klasy Pionek 
                TabelaGlowna.WyswietlTablice(TabelaGlowna.tabela);     //Wyswietla tabele  ktora jest wypelniona znakimi '_'                            


                pozycjaPionka = ListaObiektow[indeksTablicy].PodajPozycjePionka(TabelaGlowna.tabela);                                              //Pyta gdzie postawic nowego pionka w TabelaGlowna / przypisuje wartosc do pozycjaPionka 
                TabelaGlowna.tabela = TabelaGlowna.UstawPionek(pozycjaPionka, TabelaGlowna.tabela, ListaObiektow[indeksTablicy].pionek);           //Ustawia nowy Pionek  w TabelaGlowna na pozycji 'pozycjaPionka' i zwracajac TabelaGlowna nadpisuje ją 
                PolozeniePionkow.UstawienieKolejnychPionkow(indeksTablicy, pozycjaPionka, PolozeniePionkow.tablicaUstawionychPionkow);             //Uzupełnia 'tablicaUstawionychPionkow', kolejnym z pionkow na wybranym miejscu 


                czyTablicaZapisana = TabelaGlowna.SprawdzTablice(TabelaGlowna.tabela);            // Sprawdza czy tablica jest calkowicie uzupelniona pionkami        
                indeksTablicy++;                                                                  // Zmienia indeks kolekcji "ListaObiektow", przmieszczając się miedzy obiektami 
                Console.Clear();
            }
            while (czyTablicaZapisana == false);                                   // Jeśli FALSE to znaczy, że tabela ma jeszcze wolne miejsca na ktorych moze stanac pionek 
            {
                Console.Clear();
                Console.WriteLine("\tTABLICA ZAPISANA");
                PolozeniePionkow.WyswietlanieKolejnosciPionkow();
                PolozeniePionkow.WyswietlaniePozycjiPionków(PolozeniePionkow.tablicaUstawionychPionkow);
            }
        }


    }
}