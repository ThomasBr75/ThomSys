using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomerProject
{
    public class Customer
    {
        private string _name;
        private string _deliveryAddress;
        private string _billingAddress;
        private string _mainContact;

        public Customer()
        {}


        #region Properties

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }


        public string DeliveryAddress
        {
            get
            {
                return _deliveryAddress;
            }
            set
            {
                _deliveryAddress = value;
            }
        }

        public string BillingAddress
        {
            get
            {
                return _billingAddress;
            }
            set
            {
                _billingAddress = value;
            }
        }

        public string Contact
        {
            get
            {
                return _mainContact;
            }
            set
            {
                _mainContact = value;
            }
        }





        #endregion 


    }
}
