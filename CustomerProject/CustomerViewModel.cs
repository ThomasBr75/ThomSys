using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.ComponentModel;
using System.Windows.Input;


namespace CustomerProject
{
    public class CustomerViewModel 
    {
        Customer _customer;

        public CustomerViewModel()
        {
            _customer = new Customer();
        }

        #region Properties

        public string CustomerName
        {
            get
            {
                return _customer.Name;
            }
            set
            {
                _customer.Name = value;
            }
        }

        public string DeliveryAddress
        {
            get
            {
                return _customer.DeliveryAddress;
            }
            set
            {
                _customer.DeliveryAddress = value;
            }
        }

        public string BillingAddress
        {
            get
            {
                return _customer.BillingAddress;
            }
            set
            {
                _customer.BillingAddress = value;
            }
        }

        public string Contact
        {
            get
            {
                return _customer.Contact;
            }
            set
            {
                _customer.Contact = value;
            }
        }

        #endregion  


        public void UpdateCustomer(string name, string deliveryAddress, string billingAddress, string contact)
        {
            _customer.Name = name;
            _customer.DeliveryAddress = deliveryAddress;
            _customer.BillingAddress = billingAddress;
            _customer.Contact = contact;
            
        }



    }
}
