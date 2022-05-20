using System;

namespace Pattern_Task
{
    class Pattern_1
    {
        static void Main(string[] args)
        {
            int i,j;
            for(i=1;i<=5;i++)
            {
                for(j=1;j<= i;j++)
                {
                    Console.Write(" "+j);
                }
                Console.WriteLine();
            }
            Console.ReadLine(); 
        }
    }
}
