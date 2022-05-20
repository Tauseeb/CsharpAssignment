using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Task
{
    class AreaOfSquare
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Value Of Square: ");
            int value = Convert.ToInt32(Console.ReadLine());

            int area = value * value;
            Console.WriteLine("Area Of Square with values: "+value+" is "+area);
            Console.ReadLine();
        }
    }
}
