using AuthTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuthTest
{
    [TestClass]
    public class CollectionSampleTest
    {
        [TestMethod]
        //nombreDelMetodo_EscenarioAProbar
        public void GetCustomers_ShouldGetSameCustomer()
        {
            Customer[] customers = new Customer[2] { new Customer { FirstName="Maty", LastName= "Molina"},
                                                    new Customer { FirstName="Nombre1",LastName="Apellido1"} };

            int index = 1;
            Customer customerExpected = customers[1];

            Customer customerActual = AuthTesting.CollectionSample.GetCustomer(customers, index);


            Assert.IsInstanceOfType(customerActual, typeof(Customer)); //evaluo que el resultado es del tipo esperado
            Assert.AreEqual(customerExpected, customerActual); //comparo resultados
        }


        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]//Evaluo la excepcion que voy a obtener
        public void GetCustomers_ShouldThrowIndexOutofRangeException()
        {
            Customer[] customers = new Customer[2] { new Customer { FirstName="Maty", LastName= "Molina"},
                                                    new Customer { FirstName="Nombre1",LastName="Apellido1"} };

            int index = 3;

            AuthTesting.CollectionSample.GetCustomer(customers, index);
        }
    }
}
