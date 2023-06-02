using System.Diagnostics.CodeAnalysis;

namespace collatz
{
    internal class Program
    {
        public static int maxIter = 1000;
        public static int repeatCount = 1000000000;

        public static int trueCount = 0;
        public static int falseCount = 0;

        public static int highestIter;

        // 0: no messages except the final result
        // 1: log the return value only
        // 2. log the iter count and the return value
        // 3: log the final number, iter count, and the return value
        // 4: log the final number, sub iteration count, and return value
        // 5: log everything
        public static int logging = 0; 

        static void Main()
        {
            for (int i = 0; i < repeatCount; i++)
            {
                bool result = Calculate(i);

                if (logging > 0) 
                {
                    Console.WriteLine(result);
                }

                if (result)
                {
                    trueCount++;
                }
                else
                {
                    falseCount++;
                }
            }

            Console.WriteLine($"{repeatCount} iterations complete. {trueCount} iterations reached 1, {falseCount} hit maxIter.");
            Console.WriteLine($"Success rate of {trueCount / (double)repeatCount * 100d}%.");
            Console.WriteLine($"Highest successful iteration count was {highestIter}");
        }

        public static bool Calculate(int num, int iter = 0)
        {
            if (num % 2  == 0)
            {
                num /= 2;
            }
            else
            {
                num *= 3;
                num += 1;
            }

            iter++;

            if (logging >= 4)
            {
                Console.WriteLine(num);
            }

            if (num == 1)
            {
                if (logging >= 3)
                {
                    Console.WriteLine($"{num} took {iter} iterations");
                }
                if (logging == 2)
                {
                    Console.WriteLine(num);
                }

                if (iter > highestIter)
                {
                    highestIter = iter;
                }
                return true;
            }
            else if (iter >= maxIter && maxIter != 0)
            {
                if (logging >= 3)
                {
                    Console.WriteLine($"{num} took {iter} iterations");
                }
                if (logging == 2)
                {
                    Console.WriteLine(num);
                }
                return false;
            }
            else
            {
                return Calculate(num, iter);
            }
        }
    }
}