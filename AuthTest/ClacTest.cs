using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuthTest
{
    [TestClass]
    public class ClacTest
    {
        [TestMethod]
        public void Sum_ShouldCalcAndReturnSameValue()
        {
            //Aca se setean las variables (Arrange)
            int a = 5;
            int b = 6;
            int resultExpected = 11; //resultado que estoy esperando

            //Aca se utiliza el metodo que queremos evaluar (Act)
            int resultActual = AuthTesting.Calcs.Sum(a, b);

            //Validar (Assert)
            Assert.AreEqual(resultExpected, resultActual);
        }

        [DataRow (5,6,11)] //envio los parametros del metodo, se pueden agregar varios DataRow 
        [TestMethod]
        public void Sum_ShouldCalcAndReturnSameValueParameterized(int a, int b, int resultExpected)
        {
           

            //Aca se utiliza el metodo que queremos evaluar (Act)
            int resultActual = AuthTesting.Calcs.Sum(a, b);

            //Validar (Assert)
            Assert.AreEqual(resultExpected, resultActual);
        }
    }
}
