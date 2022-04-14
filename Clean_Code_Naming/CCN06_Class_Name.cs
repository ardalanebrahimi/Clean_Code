using System;
using System.Collections.Generic;
using System.Text;

namespace Clean_Code_Naming_Class
{
    class CCN06_Class_Name
    {
    }

    #region Should be Noun or Noun phrase
    class Customer { }
    class Account { }
    class Address { }
    #endregion

    #region Should not include a verb
    class SaveCustomer { }
    #endregion

    #region Avoid disinformative words like Manager, Processor, Data, or Info
    class CustomerManager { }
    class CustomerProcessor { }
    class CustomerProvider { }
    class CustomerHandler { }
    class CustomerFactory { }


    class CustomerData{ }
    class CustomerInfo{ }
    class CustomerElement{ }
    class CustomerItem { }
    #endregion
}
