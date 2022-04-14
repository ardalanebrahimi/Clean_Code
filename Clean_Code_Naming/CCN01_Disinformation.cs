using System;
using System.Collections.Generic;
using System.Text;

namespace Clean_Code_Naming
{
    #region Names which vary in small ways
    class SampleControllerForEfficientHandleingOfStrings
    {
    }
    class SampleControllerForEfficientStorageOfStrings
    {
    }
    #endregion

    #region variables that may be read wrong, especially in 1 char variable
    class SampleClassVariablesMayReadWrong
    {
        //sample 1
        int I = 0;
        int l = 1;

        //sample 2
        string xl = "test1";
        string x1 = "test2";

        //sample 3
        string xO = "test3";
        string x0 = "test4";
    }
    #endregion

    /// <summary>
    /// Use reserved words and words that have specific known meaning
    /// in the Computer science world
    /// </summary>
    #region Use revered words and words
    class ResecvedWordSample
    {
        string AccountList = "Sample Account List";
    }

    class AccountFactory
    {
        /*
         * Implement anything but Factory pattern
         */
    }
    #endregion
}
