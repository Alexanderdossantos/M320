using System;
using System.Collections.Generic;
using System.Text;

namespace Wassserfass
{
    public class Wasserfass
    {
        public int MinimalPegel => 0;
        public int MaximalPegel => Kapazitaet;

        public int Fuellstand { get; private set; }
        public int Kapazitaet { get; }

        public Wasserfass(int kapazitaet)
        {
            Kapazitaet = kapazitaet;
            Fuellstand = 0;
        }

        public ReturnCode Befuellen(int menge)
        {
            if (Fuellstand + menge > Kapazitaet)
            {
                return ReturnCode.Ueberfuellt;
            }

            Fuellstand += menge;
            return ReturnCode.Ok;
        }

        public ReturnCode Entnehmen(int menge)
        {
            if (Fuellstand - menge < MinimalPegel)
            {
                return ReturnCode.ZuWenigWasser;
            }

            Fuellstand -= menge;
            return ReturnCode.Ok;
        }

        public ReturnCode Entleeren()
        {
            Fuellstand = 0;
            return ReturnCode.Ok;
        }
    }
}