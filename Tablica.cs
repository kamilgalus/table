using System;


namespace TablicaiPionki
{
    abstract class Tablica                    // Klasa abstakcyjna (nie tworze jej obiektów) 
    {
        public char[] tabela = new char[5];



        public void NadajWartoscTablicy(char[] tabela)
        {
            for (int i = 0; i < tabela.Length; i++)
            {
                tabela[i] = '_';
            }
        }



        public void WyswietlTablice(char[] tabela)
        {
            Console.Write("\t");
            for (int i = 0; i < tabela.Length; i++)
            {
                Console.Write(tabela[i]);
            }
            Console.WriteLine();

        }



        public bool SprawdzTablice(char[] tabelaOryginalna, char[] tabelaUzupeliona)
        {
            int j = 0;                        //zmienna która będzie przechowywać ilośc miejsc na których są pionki 

            for (int i = 0; i < tabelaOryginalna.Length; i++)
            {
                if (tabelaOryginalna[i] == tabelaUzupeliona[i])
                {
                    j++;
                }
            }

            if (j == tabelaOryginalna.Length)   //jesli ilosc pionkow w "tabelaOryginalana" jest taka sama jak w "tablaUzupelniona to znaczy, że wszedzie są ustaione pionki 
            {
                return true;                 //Zwraca wartość TRUE jeśli tabela jest calkowicie uzupelniona
            }
            return false;
        }
    }
}
