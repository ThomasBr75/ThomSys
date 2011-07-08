using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NUnit.Framework;
using CustomerProject;


namespace CustomerProjectTests
{

    [TestFixture]
    public class When_Customer_is_initialized
    {
        Customer _customer;

        [TestFixtureSetUp]
        public void BeforeAll()
        {
            _customer = new Customer();

        }


        [Test]
        public void An_object_should_be_created()
        {
            Assert.IsNotNull(_customer);
        }
        
    }
}
