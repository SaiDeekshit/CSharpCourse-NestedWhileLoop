using System;

namespace NestedWhileLoop
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //intializing first variable
            int a = 0;
            //first loop with first variable
            while (a < 2)
            {
                Console.WriteLine("Value of a: {0}", a);
                //intializing Second variable
                int b = 1;

                a++;
                //Second loop with Second variable
                while (b < 2)
                {
                    Console.WriteLine("Value of b: {0}", b);
                    b++;
                }
            }
        }
    }
}
