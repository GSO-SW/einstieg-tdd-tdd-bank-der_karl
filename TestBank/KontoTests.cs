using Bank;

namespace BankTests
{
    [TestClass]
    public class KontoTests
    {
        [TestMethod]
        public void Einzahlen_GuthabenSteigt()
        {
            // arrange
            int guthaben = 10;
            int betrag = 7;
            Konto k = new Konto(guthaben);


            // act
            k.Einzahlen(betrag);

            // assert

            Assert.AreEqual(17, k.Guthaben);

        }
    }
}