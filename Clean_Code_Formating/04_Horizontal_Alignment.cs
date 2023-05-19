using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Clean_Code_Formating
{
    class _04_Horizontal_Alignment
    {
        public class Example
        {
            private Socket socket;
            private InputStream input;
            private InputStreamConfiguration inputConfig;
            protected long requestProgress;

            public void Expediter(Socket s, InputStream input)
            {
                this.socket = s;
                this.input = input;
                this.requestProgress = 10;
            }
        }
    }
}
