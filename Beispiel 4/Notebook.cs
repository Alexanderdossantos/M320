using System;
using System.Collections.Generic;
using System.Text;

namespace Beispiel_4
{
    internal class Notebook
    {
        private List<Festplatte> festplatten = new List<Festplatte>();

        public void AddFestplatte(Festplatte festplatte)
        {
            if (festplatten.Count < 3)
            {
                festplatten.Add(festplatte);
            }
        }
    }
}
