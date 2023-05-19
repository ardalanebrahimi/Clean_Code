using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Clean_Code_Formating
{
    class _05_Indentation
    {
        public class FitNesseServer: SocketServer 
        { 
            private FitNesseContext context; 
            
            public FitNesseServer(FitNesseContext context) 
            { 
                this.context = context;
            }
            
            public void serve(Socket s) 
            {
                serve(s, 10000); 
            }
            
            public void serve(Socket s, long requestTimeout) 
            {
                try 
                { 
                    FitNesseExpediter sender = new FitNesseExpediter(s, context);
                    sender.setRequestParsingTimeLimit(requestTimeout);
                    sender.start();
                }
                catch (Exception e) 
                { 
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}

