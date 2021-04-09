using System;

namespace BuildingExponentMethodPractice
{
    class Program
    {
        static void Main(string[] arg)
        {
            Console.WriteLine(GetPow(4,3));
        }

        static int GetPow( int baseNum, int powNum)
        {
            int results = 1;

            for (int i = 0; i < powNum; i++)
            {
                results = results * baseNum;
            }

            return results;
        }
    }
}
