using System;

namespace Pattern_Task
{
    class Pattern_13
    {
        static void Main()
        {
            int i, j, k;

            for (i=0;i<5;i++)
            {
                for(j=4;j>= i;j--)
                {
                    Console.Write(" ");
                }
                for(k=0;k<= i;k++)
                {
                    Console.Write((char)(i+65)+" ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
