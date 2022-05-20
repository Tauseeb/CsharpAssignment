using System;
 
namespace Pattern_Task
{
    class Pattern_11
    {
        static void Main()
        {
       
        int i, j, k;
            for (i = 0; i <= 5; i++)
            {
                for (j = 1; j <= 5 - i; j++)
                {
                    Console.Write(" ");
                }
                for (k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
