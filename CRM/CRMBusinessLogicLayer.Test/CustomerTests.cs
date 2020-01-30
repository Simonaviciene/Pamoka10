using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CRMBusinessLogicLayer;

namespace CRMBusinessLogicLayer.Test
{
    [TestClass]
    public class CustomerTests
    {
        [TestMethod]
        public void CustomerFullNameShouldBeLastNameAndFirstName()
        {
            //Assign
            Customer klientas = new Customer();
            klientas.FirstName = "Jonas";
            klientas.LastName = "Jonaitis";

            //Act
            string pilnasVardas = klientas.FullName;

            //Assert
            Assert.AreEqual("Jonaitis, Jonas", pilnasVardas);

        }
        [TestMethod]
        public void CustomerFullNameShouldBeLastNameWhenFirstNameIsEmpty()
        {
            //Assign
            Customer klientas = new Customer();
            klientas.FirstName = "Jonas";
            klientas.LastName = "";

            //Act
            string pilnasVardas = klientas.FullName;

            //Assert
            Assert.AreEqual("Jonas", pilnasVardas);

        }
        [TestMethod]
        public void ValidateValid()
        {
            //Assign
            Customer customer = new Customer
            {
                LastName = "Bagins",
                EmailAddress = "gsfvj@hsdf.ne"
            };
            bool expected = true;



            //Act
            bool actual = customer.Validate();

            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
