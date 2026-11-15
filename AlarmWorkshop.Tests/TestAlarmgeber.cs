using AlarmWorkshop;

namespace AlarmWorkshop.Tests
{
    class TestAlarmgeber : IAlarmgeber
    {
        public int AnzahlWarnungen { get; private set; }

        public void Warnen()
        {
            AnzahlWarnungen++;
        }
    }
}