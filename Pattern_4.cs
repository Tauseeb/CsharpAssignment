using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Task
{
    class Pattern_4
    {
        static void Main()
        {
            int i, j;
            for(i=1;i<=5;i++)
            {
                for(j=1;j<= i;j++)
                {
                    Console.Write(" "+i);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
