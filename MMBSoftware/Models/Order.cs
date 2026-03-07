using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMBSoftware.Models
{
    public class Order
    {
        private int _id;
        private DateTime _registrationDate;
        private int _productId;
        private int _customerId;
        private string _customerName;
        private string _productName;
        private int _productQuantity;
        private int _productTotalPrice;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public DateTime RegistrationDate
        {
            get { return _registrationDate; }
            set { _registrationDate = value; }
        }

        public int Product_Id
        {
            get { return _productId; }
            set { _productId = value; }
        }

        public int Customer_Id
        {
            get { return _customerId; }
            set { _customerId = value; }
        }

        public string Customer_Name
        {
            get { return _customerName; }
            set { _customerName = value; }
        }

        public string Product_Name
        {
            get { return _productName; }
            set { _productName = value; }
        }

        public int ProductQuantity
        {
            get { return _productQuantity; }
            set { _productQuantity = value; }
        }

        public int ProductTotalPrice
        {
            get { return _productTotalPrice; }
            set { _productTotalPrice = value; }

        }
    }
}