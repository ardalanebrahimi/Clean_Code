using System;
using System.Collections.Generic;
using System.Text;

namespace Clean_Code_Naming
{
    class CCN04_Encoding
    {
        #region Avoid using Hungarian notation
        /*
         * it is outdated! not needed anymore!
         */
        string strName;
        string strDescription;
        int intAge;
        long lAccountNum;
        #endregion


    }
    #region Do not use Unnecessary and obvious prefixed and postfixed
    class PersonSampleClass
    {
        string var_name;
        string var_tel;
        string var_email;

        public string PersonName { get; set; }
        public int PersonAge { get; set; }
        public string PersonBirthdate { get; set; }
    }
    #endregion

    #region Be careful with Interface and Implementation names
    interface IAddress { } 
    class Address: IAddress { }
    class Company: Address { }
    class Person: Address { }
    class AddressPlus : Address { }
    class AddressWithExtraProperties : Address { }
    class AddressExtended : Address { }
    class AddressWithLatAndLong : Address { }
    
    //Now what if you decide to change "Address" to "ContactInfo"...
    #endregion
}
