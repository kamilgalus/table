using System;
using System.Collections.Generic;
using System.Text;

namespace TablicObiektowa
{
    class Pionek
    {        
        private int miejscePionka;

        public void UstawMiejsce(int miejsce)
        {
            miejscePionka=miejsce;
        }

        public int PokazMiejsce()
        {
            return miejscePionka;
        }

        
    }
}
