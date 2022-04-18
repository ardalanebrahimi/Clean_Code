using System;
using System.Collections.Generic;
using System.Text;

namespace Clean_Code_Functions
{
    public class UserValidator
    {
        private Cryptographer cryptographer;

        public bool CheckPassword(String userName, String password)
        {
            User user = UserGateway.findByName(userName);
            if (user != null)
            {
                String codedPhrase = user.getPhraseEncodedByPassword();
                String phrase = cryptographer.decrypt(codedPhrase, password);
                if ("Valid Password".Equals(phrase))
                {
                    Session.initialize(); //side effect: call Session.initialize() 
                    return true;
                }
            }
            return false;
        }
    }
}
