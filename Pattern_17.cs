using System;
 
namespace Pattern_Task
{
    class Pattern_17
    {
        static void Main()
        {
            int i, j, k = 1;
            for(i=1;i<=5;i++)
            {
                for(j=1;j<= i;j++)
                {
                    Console.Write(" "+ k++);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
