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
          public void Auszahlen_NichtausreichenderGuthaben()
         {
      Konto k = new Konto(2200);
      Assert.ThrowsException<ArgumentOutOfRangeException>(() => k.Auszahlen(3000), "Guthaben nicht ausreichend");


      }
      public void Auszahlen_ausreichenderGuthaben()
      {
      int a = 2000;
      int b = 100;
      Konto k = new Konto(a);
      k.Auszahlen(b);

      // Assert
      int expectedBalance = a - b;
      Assert.AreEqual(expectedBalance, k.Guthaben);


    }
}
