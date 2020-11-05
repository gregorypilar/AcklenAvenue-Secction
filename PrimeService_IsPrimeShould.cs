

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AcklenAvenue_Secction
{
    [TestClass]
    public class PrimeService_IsPrimeShould
    {
        [TestMethod]
        public void IsPrime_InputIs1_ReturnFalse()
        {
            var primeService = new PrimeService();
            bool result = primeService.IsPrime(1);

            Assert.IsFalse(result, "1 should not be prime");
        }


         [TestMethod]
        public void IsPrime_InputIs1_ReturnTrue()
        {
            var primeService = new PrimeService();
            bool result = primeService.IsPrime(1);

            Assert.IsTrue(result, "1 should  be prime");
        }
    }
}