using System;
using System.Collections.Generic;
using System.Text;

namespace Beispiel_4
{
    internal class Festplatte
    {
        private Notebook notebook;

        public Festplatte(Notebook notebook)
        {
            this.notebook = notebook;
            this.notebook.AddFestplatte(this);
        }
    }
}
