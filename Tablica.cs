using System;
using System.Collections.Generic;
using System.Text;

namespace TablicObiektowa
{
    class Tablica
    {
        private char[] tablicaGlowna = new char[5];      
        private Pionek[] tablicaPionkow = new Pionek[5];
        public Tablica()
        {
            for (int i = 0; i < tablicaGlowna.Length; i++)
            {
                tablicaGlowna[i] = '_';              
            }

            for (int i = 0; i < tablicaPionkow.Length; i++)
            {
                tablicaPionkow[i] = new Pionek();
            }
        }

        public void WyswietlTablice()
        {
            Console.Write("\t\t");
            for (int i = 0; i < tablicaGlowna.Length; i++)
            {
                Console.Write(tablicaGlowna[i]);
            }
        }



        public void WstawPionek(int miejsceP)
        {
            tablicaGlowna[miejsceP - 1] = '#';
        }


        public bool KontrolaMiejsca(int miejsceP, int nrPionka)
        {
            if (tablicaGlowna[miejsceP - 1] == '#')
            {
                return true;

            }
            else
            {
                tablicaPionkow[nrPionka].UstawMiejsce(miejsceP);
                return false;
            }
        }


        public int GdziePostawicPionek(int nrPionka)
        {
            int miejsceP = 0;
            do
            {
                do
                {
                    try
                    {

                        Console.WriteLine("\nPodaj pozycje na której chcesz ustawić {0} pionek [1-5]: ", nrPionka + 1);
                        miejsceP = int.Parse(Console.ReadLine());
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine("Nie wprowadziles cyfry", ex);
                    }
                }
                while (miejsceP <= 0 || miejsceP >= 6);

                


                if (KontrolaMiejsca(miejsceP, nrPionka))
                {
                    Console.WriteLine("To miejsce jest już zajęte");
                }
                else
                {
                    return miejsceP;
                }
            }
            while (miejsceP >= 0 || KontrolaMiejsca(miejsceP, nrPionka) == true);


            return miejsceP;
        }



        public bool CzyZapisanaTablica()
        {
            int iloscZapisanychPol = 0;

            for (int i = 0; i < tablicaGlowna.Length; i++)
            {               
                if(tablicaGlowna[i]=='#')
                {
                    iloscZapisanychPol++;
                }
            }

            if (iloscZapisanychPol == tablicaGlowna.Length)
            {
                Console.WriteLine("\t   Tablica ZAPISANA");
                return true;              
            }
            else
                return false;

        }


        public void PokazMiejscaPionkow()
        {
            Console.WriteLine();
            for (int i = 0; i < tablicaPionkow.Length; i++)
            {
                Console.WriteLine("Pionek nr.{0} znajduje się na {1} miejscu.",i+1, tablicaPionkow[i].PokazMiejsce()); 
            }
        }

      

    }
}
