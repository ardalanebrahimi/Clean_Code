using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean_Code_Comments
{
    class _0_Intro
    {
        public void sample_1(Employee employee , bool HOURLY_FLAG)
        {
            // Check to see if the employee is eligible for full benefits
            if ((employee.Flags != null & HOURLY_FLAG) & (employee.Age > 65)) {
                // Do something
            }


            // VS

            if (employee.IsEligibleForFullBenefits(HOURLY_FLAG)) {
                // Do something
            }
        }
    }
}
