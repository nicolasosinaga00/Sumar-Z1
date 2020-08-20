using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sumar.Controllers;

namespace UnitTestSumar
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAdd1()
        {
            //Arrange
            SumaController sumaController = new SumaController();
            int a = 2;
            int b = 3;
            int esperado = 5;

            //Act
            int resultado = sumaController.Add(a, b);

            //Assert
            Assert.AreEqual(esperado, resultado);

        }
    }
}
