namespace CodeChallenges2
{
    internal class Collatz
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Collatz...The Longest Collatz");
            //create a list of var from 13 to 1000
            //var rangedNbrs = Enumerable.Range(13, 16-13).ToList(); to prove ranged is working the way I want it to.
            var rangedNbrs = Enumerable.Range(13, 1_000-13).ToList();
            //dictionary to store starting number in above range as key and eventual count as value
            Dictionary<int, int> countDict = new Dictionary<int, int>();
            //foreach to address the starting number
            foreach(var n in rangedNbrs)
            {
                int newNbr = n;
                int count = 0;
                bool exit = false;

                do
                {
                    if (newNbr % 2 == 0 && newNbr > 1)
                    {
                        newNbr = newNbr / 2;
                        count+=1;
                        //Console.WriteLine($"Divided by 2. Number is {newNbr}. Count is {count}");
                    }
                    else if (newNbr % 2 == 1 && newNbr > 1)
                    {
                        newNbr = (3 * newNbr) + 1;
                        count+=1;
                        //Console.WriteLine($"3n+1. Number is {newNbr}. Count is {count}");
                    }
                    else if(newNbr == 1)
                    {
                        count+=1;
                        countDict.Add(n, count);
                        //Console.WriteLine($"{newNbr} and count is {count}" );
                        exit = true;
                    }
                }while(!exit);
                //Console.WriteLine(n);
                continue;
            }
            //print countDict.Max to console + key.

        }
    }
}