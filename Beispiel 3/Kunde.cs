using Beispiel_3;
using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Text;

namespace Beispiel_3
{
    internal class Kunde
    {
        List<Buch> buecher = new List<Buch>();
        public void Leiht(Buch buch)
        {
            if(!buch.IstAusgeliehen)
            {
                buecher.Add(buch);
                buch.IstAusgeliehen = true;
            }
        }
        public void Retourniert(Buch buch)
        {
            if (buecher.Contains(buch))
            {
                buecher.Remove(buch);
                buch.IstAusgeliehen = false;
            }
        }
    }
}
