using NUnit.Framework;
using WebAppTest.Controllers;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        
        [Test]
        public void Test_Soma()
        {
            var result = Calculo.Soma(1, 6);
            Assert.AreEqual(result, 7);
            Assert.AreEqual(Calculo.Soma(1, -6), -5);
        }

        [Test]
        public void Test_Multiplicacao()
        {
            Assert.AreEqual(Calculo.Multiplicacao(5, 5), 25);
        }

        [Test]
        public void Test_Subtracao()
        {
            Assert.AreEqual(Calculo.Subtracao(8, 5), 3);
        }

    }
}