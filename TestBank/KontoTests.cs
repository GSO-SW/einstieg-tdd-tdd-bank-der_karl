using Bank;

namespace BankTests
{
    [TestClass]
    public class KontoTests
    {
        [TestMethod]
        public void Geld_hinzufügen()
        {
            int guthaben = 10;
            int betrag = 7;
            int expectedResult = 17;

            int result = guthaben + betrag;
       

            Assert.AreEqual(expectedResult, result);

        }
    }
}