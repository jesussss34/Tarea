using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using AppNegocio;

namespace AppTest
{
    [TestClass]
    public class CalcularTest
    {
        [TestMethod]
        public void TestCalcularY()
        {
            double x = 2;
            double y = 0;
            double resultadoEsperado = 14;

            Negocio negocio = new Negocio();
            y = negocio.CalcularY(x);

            Assert.AreEqual(resultadoEsperado, y);

        }
    }
}
