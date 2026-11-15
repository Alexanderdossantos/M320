using Wassserfass;

namespace WassserfassTests
{
    [TestClass]
    public class WasserfassTests
    {
        [TestMethod]
        public void Befuellen_Normalfall()
        {
            Wasserfass fass = new Wasserfass(100);

            fass.Befuellen(50);

            Assert.AreEqual(50, fass.Fuellstand);
        }

        [TestMethod]
        public void Befuellen_BisKapazitaet()
        {
            Wasserfass fass = new Wasserfass(100);

            fass.Befuellen(100);

            Assert.AreEqual(100, fass.Fuellstand);
        }

        [TestMethod]
        public void Befuellen_UeberKapazitaet()
        {
            Wasserfass fass = new Wasserfass(100);

            ReturnCode rc = fass.Befuellen(150);

            Assert.AreEqual(ReturnCode.Ueberfuellt, rc);
            Assert.AreEqual(0, fass.Fuellstand);
        }

        [TestMethod]
        public void Entnehmen_Normalfall()
        {
            Wasserfass fass = new Wasserfass(100);
            fass.Befuellen(80);

            fass.Entnehmen(30);

            Assert.AreEqual(50, fass.Fuellstand);
        }

        [TestMethod]
        public void Entnehmen_BisNull()
        {
            Wasserfass fass = new Wasserfass(100);
            fass.Befuellen(80);

            fass.Entnehmen(80);

            Assert.AreEqual(0, fass.Fuellstand);
        }

        [TestMethod]
        public void Entnehmen_UnterNull()
        {
            Wasserfass fass = new Wasserfass(100);
            fass.Befuellen(30);

            ReturnCode rc = fass.Entnehmen(50);

            Assert.AreEqual(ReturnCode.ZuWenigWasser, rc);
            Assert.AreEqual(30, fass.Fuellstand);
        }

        [TestMethod]
        public void Entleeren()
        {
            Wasserfass fass = new Wasserfass(100);
            fass.Befuellen(70);

            fass.Entleeren();

            Assert.AreEqual(0, fass.Fuellstand);
        }
    }
}