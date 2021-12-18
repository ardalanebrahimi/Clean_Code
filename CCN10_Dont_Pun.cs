using System;
using System.Collections.Generic;
using System.Text;

namespace Clean_Code_Naming
{
    class ClassA
    {
        void Add(ClassA obj)
        {
            //Add New record of type ClassA in Database
        }
    }
    class ClassB
    {
        int Indexor;
        void Add()
        {
            //Increment the Indexor poperty by one
            Indexor++;
        }
    }
    class ClassC
    {
        ClassC Add()
        {
            //Crete a new instance of ClassC
            return new ClassC();
        }
    }
}
