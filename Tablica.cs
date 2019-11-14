using System;


namespace TabelaiPionki
{
    abstract class Tablica                    // Klasa abstakcyjna (nie tworze jej obiektów) 
    {
        public char[] tabela = new char[5];


        public Tablica()   //Konstruktor wypełniający tablice znakami '_'
        {
            for (int i = 0; i < tabela.Length; i++)
            {
                tabela[i] = '_';
            }
        }
    

        public void WyswietlTablice(char[] tabela)   //Wyswietla TabelaGłowna na ktorej będą lub są ustawione pionki 
        {
            Console.Write("\t");
            for (int i = 0; i < tabela.Length; i++)
            {
                Console.Write(tabela[i]);
            }
            Console.WriteLine();

        }



        public bool SprawdzTablice(char[] tabelaOryginalna)  //Funkcja sprawdza czy tablica jest calkowicie obstawiona przez pionki 
        {
            int j = 0;                        //zmienna która będzie przechowywać ilośc miejsc na których są pionki (znak '#')

            for (int i = 0; i < tabelaOryginalna.Length; i++)   //Przeszukuje tablice w poszukiwaniu pionków
            {
                if (tabelaOryginalna[i] == '#')
                {
                    j++;
                }
            }

            if (j == tabelaOryginalna.Length)   //jesli ilosc pionkow w "tabelaOryginalana" jewst równa dlugosci tabeli to znaczy, że na kazdym indeksie stoi pionek 
            {
                return true;                 //Zwraca wartość TRUE jeśli tabela jest calkowicie uzupelniona
            }
            return false;
        }
    }
}
