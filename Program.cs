using System;
using System.Collections.Generic;


namespace TabelaiPionki
{
    class Program
    {
        static void Main()
        {
            Pionek TabelaGlowna = new Pionek();                       //Tworzenie obiektu z którego tabeli będę korzystał ( jedna tabela na której pracuję )     
            Wyswietlacz PolozeniePionkow = new Wyswietlacz();         //Tworzenie obiektu Wyswietlacza     
            int pozycjaPionka;                                        //Zmienna do przechowywania indeksu na ktorym użytkownik chce ustawić pionek 
            bool czyTablicaZapisana;                                  //Zmienna potwierdzająca uzupełnioną tablice
            int indeksTablicy = 0;                                    //Zmienna która iteruje kolekcje obiektow 


            
            do
            {
                Pionek[] TablicaPionkow = new Pionek[5];        //Tablica zawierająca obiekty klasy Pionek            
                TabelaGlowna.WyswietlTablice(TabelaGlowna);     //Wyswietla tabele  ktora jest wypelniona znakimi '_'                            
                TablicaPionkow[indeksTablicy] = new Pionek();   //Tworzenie nowego pionka 

                pozycjaPionka = TablicaPionkow[indeksTablicy].PodajPozycjePionka(TabelaGlowna);                 //Pyta gdzie postawic nowego pionka w TabelaGlowna / przypisuje wartosc do pozycjaPionka 
                TabelaGlowna.UstawPionek(pozycjaPionka, TabelaGlowna, TablicaPionkow[indeksTablicy]);           //Ustawia nowy Pionek  w TabelaGlowna na pozycji 'pozycjaPionka'                
                PolozeniePionkow.UstawienieKolejnychPionkow(indeksTablicy, pozycjaPionka, PolozeniePionkow);    //Uzupełnia 'tablicaUstawionychPionkow', kolejnym z pionkow na wybranym miejscu 


                czyTablicaZapisana = TabelaGlowna.SprawdzTablice(TabelaGlowna);            //Sprawdza czy tablica jest calkowicie uzupelniona pionkami        
                indeksTablicy++;                                                           //Zmienia indeks tablicy "TablicaPionkow", przmieszczając się miedzy obiektami 
                Console.Clear();
            }
            while (czyTablicaZapisana == false);                                   //Jeśli FALSE to znaczy, że tabela ma jeszcze wolne miejsca na ktorych moze stanac pionek 
            {
                Console.Clear();
                Console.WriteLine("\tTABLICA ZAPISANA");
                PolozeniePionkow.WyswietlanieKolejnosciPionkow();
                PolozeniePionkow.WyswietlaniePozycjiPionków(PolozeniePionkow);
            }
        }


    }
}