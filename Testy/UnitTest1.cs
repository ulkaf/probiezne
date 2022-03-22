using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testy
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAdd()
        {
            projekt_wspolbiezne.Calculator x = new projekt_wspolbiezne.Calculator();

            double y = x.Addition(2, 2);

            Assert.AreEqual(y, 4);

        }

        [TestMethod]
        public void TestSub()
        {
            projekt_wspolbiezne.Calculator x = new projekt_wspolbiezne.Calculator();
            double y = x.Subtraction(2, 2);
            Assert.AreEqual(y, 0);

        }


        [TestMethod]
        public void TestMultiply()
        {
            projekt_wspolbiezne.Calculator x = new projekt_wspolbiezne.Calculator();

            double y = x.Multiplication(2, 2);
            Assert.AreEqual(y, 4);

        }

        [TestMethod]
        public void TestDiv()
        {
            projekt_wspolbiezne.Calculator x = new projekt_wspolbiezne.Calculator();
            double y = x.Division(2, 2);
            Assert.AreEqual(y, 1);
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void DivideException()
        {
            projekt_wspolbiezne.Calculator x = new projekt_wspolbiezne.Calculator();
            x.Division(2, 0);
        }
    }
}