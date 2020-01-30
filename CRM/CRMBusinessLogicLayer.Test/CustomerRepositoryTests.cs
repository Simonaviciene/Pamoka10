using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CRMBusinessLogicLayer;

namespace CRMBusinessLogicLayer.Test
{
    [TestClass]
    public class CustomerRepositoryTests
    {
        [TestMethod]
        public void RetriveValid()
        {
            //Arrange
            CustomerRepository customerRepository = new CustomerRepository();
            Customer expected = new Customer(1);

            expected.EmailAddress = "mano@gmail.com";
            expected.FirstName = "Jonas";
            expected.LastName = "Baggins";

            //Act
            Customer actual = customerRepository.Retrieve(1);

            //Assert
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);

        }
    }
}
