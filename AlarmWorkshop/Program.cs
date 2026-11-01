using System;

internal class Program
{
    private static void Main()
    {
        Alarmgeraet sirene = new Sirene();
        Alarmgeraet warnlampe = new Warnlampe();

        sirene.Selbsttest();
        Testalarm(sirene);

        warnlampe.Selbsttest();
        Testalarm(warnlampe);
    }

    private static void Testalarm(Alarmgeraet geraet)
    {
        geraet.Warnen();
    }
}

abstract class Alarmgeraet
{
    public abstract void Warnen();

    public virtual void Selbsttest()
    {
        Console.WriteLine("Selbsttest: Gerät bereit.");
    }
}

class Sirene : Alarmgeraet
{
    public override void Warnen()
    {
        Console.WriteLine("Sirene: Tatü tata!");
    }
}

class Warnlampe : Alarmgeraet
{
    public override void Warnen()
    {
        Console.WriteLine("Warnlampe: Rotes Licht blinkt!");
    }

    public override void Selbsttest()
    {
        Console.WriteLine("Selbsttest: Lampe leuchtet kurz.");
    }
}
