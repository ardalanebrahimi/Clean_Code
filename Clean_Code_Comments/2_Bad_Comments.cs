using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Clean_Code_Comments
{
    partial class _2_Bad_Comments
    {
        #region Redundant comments

        // Utility method that returns when this.closed is true. Throws an exception
        // if the timeout is reached.
        public async void WaitForClose(long timeoutMillis)
        {
            if (!closed)
            {
                Monitor.Wait(timeoutMillis);
                if (!closed)
                {
                    throw new Exception("MockResponseSender could not be closed");
                }
            }
        }

        // MyProperty data
        public int MyProperty { get; set; }

        #endregion

        #region Mandated comments

        /**
         * @param title The title of the CD
         * @param author The author of the CD
         * @param tracks The number of tracks on the CD
         * @param durationInMinutes The duration of the CD in minutes
         */
        public void AddCD(String title,
                          String author,
                          int tracks,
                          int durationInMinutes)
        {
            // ...
        }

        #endregion

        #region Noise comments

        /**
         * Default constructor.
         */
        protected _2_Bad_Comments()
        {
        }
        private void startSending()
        {
            try { this.doSending(); }
            catch (SocketException e)
            {
                // normal. someone stopped the request.
            }
            catch (Exception e)
            {
                try { this.response.Add(ErrorResponder.makeExceptionString(e)); response.closeAll(); }
                catch (Exception e1)
                {
                    //Give me a break!
                }
            }
        }

        /** The name. */
        private String name;

        /** The version. */
        private String version;

        /** The licenseName. */
        private String licenseName;

        /** The version. */
        private String info;

        #endregion

        #region Don’t Use a Comment When You Can Use a Function or a Variable

        public void SampleMethod()
        {
            // does the module from the global list <mod> depend on the
            // subsystem we are part of?
            if (smodule.getDependSubsystems().Contains(subSysMod.getSubSystem())) ;
        }

        public void SampleMethod_Refactord()
        {
            IList<string> moduleDependees = smodule.getDependSubsystems();
            String ourSubSystem = subSysMod.getSubSystem();

            if (moduleDependees.Contains(ourSubSystem)) ;
        }

        #endregion

        #region Closing Brace Comments

        public class WordCount
        {
            public static void main(String[] args)
            {
                String line;
                int lineCount = 0;
                int charCount = 0;
                int wordCount = 0; 
                try
                {
                    while ((line = Console.ReadLine()) != null) {
                        lineCount++;
                        charCount += line.Length;
                        String[] words = line.Split("\\W");
                        wordCount += words.Length;
                    } //while
                    Console.WriteLine("wordCount = " + wordCount);
                    Console.WriteLine("lineCount = " + lineCount);
                    Console.WriteLine("charCount = " + charCount);
                } // try
                catch (IOException e)
                {
                    Console.WriteLine("Error:" + e.Message);
                } //catch
            } //main
        }

        #endregion

        #region Commented-Out Code

        public void SampleMethos()
        {
            InputStreamResponse response = new InputStreamResponse();
            // InputStream resultsStream = formatter.getResultStream();
            // StreamReader reader = new StreamReader(resultsStream);
            // response.setContent(reader.read(formatter.getByteCount()));
            response.setBody(formatter.getResultStream(), formatter.getByteCount());
        }

        #endregion

        #region Nonlocal Information

        /**
         * Port on which fitnesse would run. Defaults to 8082.
         *
         * @param fitnessePort
         */
        public void setFitnessePort(int fitnessePort)
        {
            this.fitnessePort = fitnessePort;
        }

        #endregion

        #region Too Much Information

        /* RFC 2045 - Multipurpose Internet Mail Extensions (MIME)
         * Part One: Format of Internet Message Bodies
         * section 6.8. Base64 Content-Transfer-Encoding
         * The encoding process represents 24-bit groups of input bits as output
         * strings of 4 encoded characters. Proceeding from left to right, a
         * 24-bit input group is formed by concatenating 3 8-bit input groups.
         * These 24 bits are then treated as 4 concatenated 6-bit groups, each
         * of which is translated into a single digit in the base64 alphabet.
         * When encoding a bit stream via the base64 encoding, the bit stream
         * must be presumed to be ordered with the most-significant-bit first.
         * That is, the first bit in the stream will be the high-order bit in
         * the first 8-bit byte, and the eighth bit will be the low-order bit in
         * the first 8-bit byte, and so on. */

        #endregion 

        #region Inobvious connection

        public void SampleMethod2(int width, int height)
        {
            /*
             * start with an array that is big enough to hold all the pixels
             * (plus filter bytes), and an extra 200 bytes for header info
             */
            var pngBytes = new byte[((width + 1) * height * 3) + 200];
        }

        #endregion

        #region 



        #endregion

    }
}
