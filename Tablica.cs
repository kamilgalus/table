using System;


namespace TabelaiPionki
{
    abstract class Tablica                    //Klasa abstakcyjna (nie tworze jej obiektów) 
    {
        protected char[] tabela = new char[5];


        public Tablica()   //Konstruktor wypełniający tablice znakami '_'
        {
            for (int i = 0; i < tabela.Length; i++)
            {
                tabela[i] = '_';
            }
        }
    

        public void WyswietlTablice(Tablica o)   //Wyswietla TabelaGłowna na ktorej będą lub są ustawione pionki 
        {
            Console.Write("\t");
            for (int i = 0; i < o.tabela.Length; i++)
            {
                Console.Write(o.tabela[i]);
            }
            Console.WriteLine();

        }



        public bool SprawdzTablice(Tablica o)  //Funkcja sprawdza czy tablica jest calkowicie obstawiona przez pionki 
        {
            int j = 0;                         //Zmienna która będzie przechowywać ilośc miejsc na których są pionki (znak '#')

            for (int i = 0; i < o.tabela.Length; i++)   //Przeszukuje tablice w poszukiwaniu pionków
            {
                if (o.tabela[i] == '#')
                {
                    j++;
                }
            }

            if (j == o.tabela.Length)   //jesli ilosc pionkow w "tabelaOryginalana" jewst równa dlugosci tabeli to znaczy, że na kazdym indeksie stoi pionek 
            {
                return true;                 //Zwraca wartość TRUE jeśli tabela jest calkowicie uzupelniona
            }
            return false;
        }
    }
}
