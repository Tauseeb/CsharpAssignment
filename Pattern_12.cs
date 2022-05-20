using System;
 
namespace Pattern_Task
{
    class Pattern_12
    {
        static void Main()
        {       
            int i, j, k;
            for (i = 1; i <= 5; i++)
            {
                for (j = 4; j >= i ; j--)
                {
                    Console.Write(" ");
                }
                for (k = 1; k <= i ; k++)
                {
                    Console.Write(i+" ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
