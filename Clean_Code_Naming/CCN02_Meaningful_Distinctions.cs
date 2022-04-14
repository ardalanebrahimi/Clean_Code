using System;
using System.Collections.Generic;
using System.Text;

namespace Clean_Code_Naming
{
    class CCN02_Meaningful_Distinctions
    {
        /*
         * Do not use the number-series for variable, property name
         */
        #region numer-series varables
        //sample 1
        int a1 = 1;
        int a2 = 2;
        int a3 = 3;

        //sample 2
        string Name1;
        string Name2;

        //sample 3
        string Tel1;
        string Tel2;
        string Tel3;
        #endregion

    }

    /*
     * Do not use Noise words,
     * generic words that do not add much accurate value to description
     */
    #region noise word
    class AccountData 
    {
    }
    class AccountInfo 
    {
    }
    class TheAccount
    {
    }
    #endregion
}
