using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Task
{
    class Factorial
    {
        static void Main(string []args)
        {
            int number,i, fact = 1;
            Console.WriteLine("Please Enter Any Number To Find Factorial: ");
            number = Convert.ToInt32(Console.ReadLine());
            for(i=1;i<= number;i++)
            {
                fact = fact * i;
            }
            Console.WriteLine(fact);
            Console.ReadLine();
        }
    }
}
