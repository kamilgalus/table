using System;


namespace TablicaiPionki
{
    class Pionek : Tablica             //Klasa którą posługuję się do stworzenia jednego obiektu z którgo tablicy będę korzystał i 5 obiektów(zawartych w tabliocy) z których będę korzystał jako pionków
    {
        public char pionek = '#';



        public Pionek()
        {
            for (int i = 0; i < tabela.Length; i++)      //Konstruktor wypełniający tablice znakami "#"
            {
                tabela[i] = '#';
            }

        }



        public int PodajPozycjePionka()
        {
            int liczba = 0;          // Zmienna ktora będzie przechowywać liczbę odpowiadającą indeksowi tabeli na ktorej stanie pionek
            do
            {
                try
                {

                    Console.WriteLine("Podaj pozycje na której chcesz ustawić pionek [1-5]: ");
                    liczba = int.Parse(Console.ReadLine());
                }
                catch (System.FormatException ex)                //Zgłoszenie wyjątku w razie nie wpisania cyfry 
                {
                    Console.WriteLine("Nie wprowadziles cyfry", ex);
                }
                if (liczba >= 1 && liczba <= 5)                  //jeśli liczba mieści się w przedziale to ją zwróć, jeśli nie to (warunek while jest spełniony) powtarza czynnosc 
                {
                    return liczba;
                }


            }
            while (liczba >= 0);

            return liczba;

        }



        public char[] UstawPionek(int i, char[] tabela, char pion)   //Funkcja ustawiajaca pionek w podanym przez uzytkowniak miejscu w tabeli 
        {
            i = i - 1;
            tabela[i] = pion;
            return tabela;
        }
    }
}
