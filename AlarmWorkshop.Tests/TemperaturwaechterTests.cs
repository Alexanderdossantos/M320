using AlarmWorkshop;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlarmWorkshop.Tests
{
    [TestClass]
    public class TemperaturwaechterTests
    {
        [TestMethod]
        public void Anfangszustand()
        {
            TestAlarmgeber geraet = new TestAlarmgeber();

            Temperaturwaechter waechter =
                new Temperaturwaechter(new IAlarmgeber[] { geraet });

            Assert.IsFalse(waechter.AlarmAktiv);
            Assert.AreEqual(0, geraet.AnzahlWarnungen);
        }

        [TestMethod]
        public void Pruefen_20Grad()
        {
            TestAlarmgeber geraet = new TestAlarmgeber();

            Temperaturwaechter waechter =
                new Temperaturwaechter(new IAlarmgeber[] { geraet });

            waechter.Pruefen(20);

            Assert.IsFalse(waechter.AlarmAktiv);
            Assert.AreEqual(0, geraet.AnzahlWarnungen);
        }

        [TestMethod]
        public void Pruefen_49Grad()
        {
            TestAlarmgeber geraet = new TestAlarmgeber();

            Temperaturwaechter waechter =
                new Temperaturwaechter(new IAlarmgeber[] { geraet });

            waechter.Pruefen(49);

            Assert.IsFalse(waechter.AlarmAktiv);
            Assert.AreEqual(0, geraet.AnzahlWarnungen);
        }

        [TestMethod]
        public void Pruefen_GenauAnDerGrenze_Warnt()
        {
            TestAlarmgeber geraet = new TestAlarmgeber();

            Temperaturwaechter waechter =
                new Temperaturwaechter(new IAlarmgeber[] { geraet });

            waechter.Pruefen(50);

            Assert.IsTrue(waechter.AlarmAktiv);
            Assert.AreEqual(1, geraet.AnzahlWarnungen);
        }

        [TestMethod]
        public void Pruefen_51Grad()
        {
            TestAlarmgeber geraet = new TestAlarmgeber();

            Temperaturwaechter waechter =
                new Temperaturwaechter(new IAlarmgeber[] { geraet });

            waechter.Pruefen(51);

            Assert.IsTrue(waechter.AlarmAktiv);
            Assert.AreEqual(1, geraet.AnzahlWarnungen);
        }

        [TestMethod]
        public void ZweiGeraeteWerdenGewarnt()
        {
            TestAlarmgeber geraet1 = new TestAlarmgeber();
            TestAlarmgeber geraet2 = new TestAlarmgeber();

            Temperaturwaechter waechter =
                new Temperaturwaechter(
                    new IAlarmgeber[] { geraet1, geraet2 });

            waechter.Pruefen(50);

            Assert.IsTrue(waechter.AlarmAktiv);
            Assert.AreEqual(1, geraet1.AnzahlWarnungen);
            Assert.AreEqual(1, geraet2.AnzahlWarnungen);
        }

        [TestMethod]
        public void WiederAbgekuehlt()
        {
            TestAlarmgeber geraet = new TestAlarmgeber();

            Temperaturwaechter waechter =
                new Temperaturwaechter(
                    new IAlarmgeber[] { geraet });

            waechter.Pruefen(60);
            waechter.Pruefen(20);

            Assert.IsFalse(waechter.AlarmAktiv);
            Assert.AreEqual(1, geraet.AnzahlWarnungen);
        }

        [TestMethod]
        public void WiederholtHoch()
        {
            TestAlarmgeber geraet = new TestAlarmgeber();

            Temperaturwaechter waechter =
                new Temperaturwaechter(
                    new IAlarmgeber[] { geraet });

            waechter.Pruefen(60);
            waechter.Pruefen(60);

            Assert.IsTrue(waechter.AlarmAktiv);
            Assert.AreEqual(2, geraet.AnzahlWarnungen);
        }

        [TestMethod]
        public void LeeresArray()
        {
            Temperaturwaechter waechter =
                new Temperaturwaechter(
                    new IAlarmgeber[] { });

            waechter.Pruefen(50);

            Assert.IsTrue(waechter.AlarmAktiv);
        }
    }
}