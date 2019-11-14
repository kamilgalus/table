using System;


namespace TabelaiPionki
{
    class Pionek : Tablica             //Klasa którą posługuję się do stworzenia jednego obiektu z którgo tablicy będę korzystał i 5 obiektów(zawartych w tabliocy) z których będę korzystał jako pionków
    {
        public char pionek = '#';

       
        public int PodajPozycjePionka(char[] tablica)  // Funkcja pyta gdzie postawić pionek/sprawdza możliowśc i zwraca miejsce wybrane przez użtykownika 
        {
            int pozycjaPionka = 0;       // Zmienna ktora bedzie zwracana jako miejsce w TabelaGlowna
           
            do
            {
                try
                {
                    Console.WriteLine("Podaj pozycje na której chcesz ustawić pionek [1-5]: ");
                    pozycjaPionka = int.Parse(Console.ReadLine());
                }
                catch(System.FormatException ex)
                {
                    Console.WriteLine("Nie wprowadziles cyfry", ex);               
                }

                if (pozycjaPionka >= 1 && pozycjaPionka <= 5)                  //jeśli liczba mieści się w przedziale to ją zwróć, jeśli nie to (warunek while jest spełniony) powtarza czynnosc 
                {
                    if (tablica[pozycjaPionka - 1] == '#')                     //Sprawdzenie czy na danym miesjcu w tabeli stoi pionek 
                    {
                        Console.WriteLine("To miejsce jest już zajęte!");  
                    }
                    else
                    return pozycjaPionka;
                }
            }
            while (pozycjaPionka >= 0);
            
            return pozycjaPionka;
        }



        public char[] UstawPionek(int pozycja, char[] tabela, char pion)   //Funkcja ustawiajaca pionek w podanym przez uzytkowniak miejscu w tabeli 
        {
            pozycja = (pozycja - 1);                                         //ponieważ indeksowanie tablicy zaczyna się od 0
            tabela[pozycja] = pion;
            return tabela;
        }
    }
}
