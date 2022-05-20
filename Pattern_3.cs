using System;

namespace Pattern_Task
{
    class Pattern_3
    {
        static void  Main(string [] args)
        {
           
           int i, j;
            for (i = 1; i <= 5; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(" " + "*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
 

//int i, j, k;
//            for (i = 1; i <= 5; i++)
//            {
//                for(j=5-1;j>= i;j--)
//                {
//                    Console.Write(" ");
//                }
//                for(k=1;k<= i;k++)
//                {
//                    Console.Write("*"+" ");
//                }
//                Console.WriteLine();
//            }