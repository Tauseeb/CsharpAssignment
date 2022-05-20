using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Task
{
    class Swapping
    {
        static void Main(string [] args)
        {
            Console.WriteLine("Enter First Number: ");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number: ");
            int secondNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Before Swapping Value is: {0} And {1} ",firstNum,secondNum);
            //firstNum = 6;
            //secondNum = 5;
            firstNum = firstNum + secondNum;//First=6+5=11
            secondNum = firstNum - secondNum;//SeconNum=11-5=6
            firstNum = firstNum - secondNum;//First=11-6=5

            Console.WriteLine("After Swapping Value is: {0} and {1}",firstNum,secondNum);
            
            Console.ReadKey();
        }
    }
}
