using System.Diagnostics.CodeAnalysis;

namespace Multiples3sAnd5s
{
    internal class Challenge1_Multiple3sAnd5s
    {
        static void Main(string[] args)
        {
            /*Solve the lab using the instructions below.

           a. If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3,5,6, and 9. The sum of these multiples is 23.
            

           b. Find the sum of all multiples of 3 or 5 below 1000 and print it out to the console.*/
            var aNumberList = Enumerable.Range(1, 9).ToList();
            int sum = 0;
            foreach(var a in aNumberList)
            {
                if (a % 3 == 0 || a % 5 == 0)
                {
                    Console.WriteLine(a);
                    sum += a;
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine(sum);

            var bNumberList = Enumerable.Range(1, 1_000 - 1).ToList();
            sum = 0;
            foreach (var b in bNumberList)
            {
                if (b % 3 == 0 || b % 5 == 0)
                {
                    //Console.WriteLine(b);
                    sum += b;
                }
                //Console.WriteLine(b);
            }
            Console.WriteLine(sum);
        }
    }
}