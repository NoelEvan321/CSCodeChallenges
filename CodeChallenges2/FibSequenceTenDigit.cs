using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges2
{
    internal class FibSequenceTenDigit
    {
        static void Main(string[] args)
        {

            bool exit = false;
            List<long> fibSeq = new List<long>() { 1, 2 };
            long startNbr = 1;
            long fibNbr = startNbr;
            int digitNumber = fibNbr.ToString().Length;
            int i = 0;//so that when we hit 10 digits we account for the index of the 10 digit number.

            do
            {

                if (digitNumber < 10)
                {
                    fibNbr = fibSeq[fibSeq.Count - 1] + fibSeq[fibSeq.Count - 2];
                    fibSeq.Add(fibNbr);
                    digitNumber = fibNbr.ToString().Length;
                    i += 1;
                    Console.WriteLine(i);
                }
                else
                {
                    exit = true;
                }
            } while (!exit);
            Console.WriteLine(i);
        }
    }
}
