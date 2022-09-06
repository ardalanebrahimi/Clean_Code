using System;
using System.Collections.Generic;
using System.Text;

namespace Clean_Code_Functions
{
    class Class1
    {
        public void ZeroParamFunction() { }

        //Monadic
        public void OneParamFunction(
            string param) 
        { }

        // Dyadic
        public void TwoParamFunction(
            string param,
            object objParam)
        { }

        // Triads
        public void ThreeParamFunction(
            string param,
            int intParam,
            object objParam)
        { }

    }
}
