using System;
using System.Collections.Generic;
using System.Text;

namespace Clean_Code_Naming_Class
{
    class CCN07_Method_Name
    {
        #region Should be Verb or Verb phrase
        void PostPayment() { }
        void DeletePage() { }
        void Save() { }
        #endregion
    }

    #region Use meaningful static methods instead of constructor overloading
    class User
    {
        public User() { }
        public User(string name, string email)
        {
            this.Name = name;
            this.Email = email;
            this.Country = "DE";
        }

        //Alternative
        public static User CreateWithDefaulCountry(string name, string email)
        {
            User user = new User();
            user.Name = name;
            user.Email = email;
            user.Country = "DE";
            return user;
        }

        public string Name { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }

    }

    class UserUsage
    {
        User User1 = new User("Ardalan", "Ardalan@Ardilan.de");
        User User2 = User.CreateWithDefaulCountry("Ardalan", "Ardalan@Ardilan.de");
    }
    #endregion
}
