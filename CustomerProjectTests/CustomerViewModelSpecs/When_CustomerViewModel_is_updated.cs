using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NUnit.Framework;
using CustomerProject;


namespace CustomerProjectTests
{

    [TestFixture]
    class When_CustomerViewModel_is_updated
    {

        CustomerViewModel _customerViewModel;
            
        public void Arrange()
        {
            _customerViewModel = new CustomerViewModel();
        }

        public void Act()
        {
            _customerViewModel.UpdateCustomer("Syscom Media International", "London 1", "London 2", "Shane McGowan");
            
        }

        public void Asserts()
        {
            Assert.AreEqual("Syscom Media International", _customerViewModel.CustomerName);
            Assert.AreEqual("London 1", _customerViewModel.DeliveryAddress);
            Assert.AreEqual("London 2", _customerViewModel.BillingAddress);
            Assert.AreEqual("Shane McGowan", _customerViewModel.Contact);
        }

        [Test]
        public void The_Customer_model_should_be_updated()
        {
            Arrange();
            Act();
            Asserts();
        }


    }
}
