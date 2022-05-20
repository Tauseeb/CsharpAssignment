using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Task
{
    class Pattern_16
    {
        static void Main()
        {
            int i, j;
            for (i = 5; i >= 1; i--)
            {
                for (j = 5; j >= i; j--)
                {
                    Console.Write(" " + j);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
 