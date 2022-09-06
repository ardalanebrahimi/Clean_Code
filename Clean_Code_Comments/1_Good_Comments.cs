using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Clean_Code_Comments
{
    class _1_Good_Comments
    {
        #region Copyrights/Legal
        
        //  Created by Ardalan Ebrahimi on 01/01/2022.
        //  Copyright © 2022 Company. All rights reserved.

        #endregion

        #region  Informative comments

        // format matched hh:mm:ss EEE, MMM dd, yyyy
        Pattern timeMatcher = Pattern.compile("\\d*:\\d*:\\d* \\w*, \\w* \\d*, \\d*");

        #endregion

        #region Explanation of intent

        public void Method_x(ThreadStart widgetBuilderThread )
        {
            // This is our best attempt to get a race condition
            // by creating large number of threads.
            for (int i = 0; i < 2500; i++)
            {
                Thread thread = new Thread(widgetBuilderThread);
                thread.Start();
            }
        }

        #endregion

        #region Warning of consequences

        public static SimpleDateFormat MakeLogFormat()
        {
            // SimpleDateFormat is not thread safe
            // so we need to create each instance independently
            return new SimpleDateFormat("dd/MMM/yyyy:HH:mm:ss Z");
        }

        #endregion
    }
}
