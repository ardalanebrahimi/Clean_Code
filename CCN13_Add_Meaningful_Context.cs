using System;
using System.Collections.Generic;
using System.Text;

namespace Clean_Code_Naming_Context
{
    //Put names in a meaningful context to clarify the meaning
    public class Order
    {
        public string State { get; set; }
    }

    public class Address
    {
        public string State { get; set; }
    }

    public class Student
    {
        public string State { get; set; }
    }

    public class SampleUsage
    {
        public SampleUsage()
        {
            Order order = new Order();
            order.State = "Draft";

            Address address = new Address();
            address.State = "Tehran";

            Student student = new Student();
            student.State = "Graduated";
        }
    }
}
