using Bank;


namespace UebungKontoTests
{
    [TestClass]
    public class UebungKontoTests
    {
        [TestMethod]
        public void Guthaben_einzahlen()
        {
            //Arrange
            int guthaben = 0;
            int betrag = 5;
            Konto k = new Konto(guthaben);

            //Act
            k.Einzahlen(betrag);

            //Assert
            Assert.AreEqual(k.Guthaben, betrag);

        }

        [TestMethod]
        public void Guthaben_Auszahlen()
        {
            //Arrange
            int guthaben = 10;
            int betrag = 5;
            Konto k = new Konto(guthaben);

            //Act
            k.Auszahlen(betrag);

            //Assert
            Assert.AreEqual(k.Guthaben, betrag); 
        }

        [TestMethod]
        public void Konto_Erstellen()
        {
            //Arrange
            int guthaben = 100;

            //Act
            Konto k = new Konto(guthaben);

            //Assert
            Assert.AreEqual(k.Guthaben, guthaben);

        }

        [TestMethod]
        public void Konto_Darf_Nicht_Negativ_Sein()
        {
            //Arrange
            int guthaben = 0;
            int betrag = -1;

            //Act
            Konto k = new Konto(guthaben);

            //Assert
            Assert.AreNotEqual(k.Guthaben, betrag);

        }

        [TestMethod]
        public void Alles_Auszahlen()
        {
            //Arrang
            int guthaben = 100;
            int ergebnis = 0;
            Konto k = new Konto(guthaben);

            //Act
            k.Alles_Auszahlen(guthaben);

            //Assert
            Assert.AreEqual(k.Guthaben, ergebnis);
        }
    }
}