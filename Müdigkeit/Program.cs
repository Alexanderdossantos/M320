namespace Müdigkeit
{
    public class Person
    {
        private string name;
        private int wutLevel;

        public Person(string name)
        {
            this.name = name;
            wutLevel = 0;
        }

        public void Aergern()
        {
            wutLevel += 20;

            if (wutLevel > 100)
            {
                wutLevel = 100;
            }
        }

        public void Beruhigen()
        {
            wutLevel -= 20;

            if (wutLevel < 0)
            {
                wutLevel = 0;
            }
        }

        public bool IstWuetend()
        {
            return wutLevel >= 50;
        }

        public void Schreien()
        {
            if (IstWuetend())
            {
                Console.WriteLine($"{name}: ICH BIN ÜBERHAUPT NICHT WÜTEND!!! 😡");
            }
            else
            {
                Console.WriteLine($"{name} ist noch ziemlich entspannt.");
            }
        }

        public void StatusAnzeigen()
        {
            Console.WriteLine($"{name} hat ein Wut-Level von {wutLevel}/100.");
        }
    }