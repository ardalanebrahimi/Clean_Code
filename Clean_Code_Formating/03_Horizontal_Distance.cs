using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Clean_Code_Formating
{
    class _03_Horizontal_Distance
    {
        public class Example
        {
            private int variable;
            private int deductor;
            private void setScore(int id, int score)
            {
                throw new NotImplementedException();
            }

            public void Sample(
                String name,
                int id,
                string content,
                int currentScore)
            {
                System.Console.WriteLine(
                    "Name:" + name +
                    "Id:" + id++ +
                    "Content:" + content);
                int score = currentScore*2 - 4*variable*deductor;
                this.setScore(id, score);
            }

        }
    }
}
