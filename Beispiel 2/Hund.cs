using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Beispiel_2
{
    internal class Hund
    {
        private List<Laus> lauese;
        public void addLaus(Laus laus)
        {
            this.lauese .Add(laus);
        }
    }
}
