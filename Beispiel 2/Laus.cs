using System;
using System.Collections.Generic;
using System.Text;

namespace Beispiel_2
{
    internal class Laus
    {
        private Hund hund;
        public Laus(Hund hund)
        {
            this.hund = hund;
            this.hund.addLaus(this);
        }
    }
}
