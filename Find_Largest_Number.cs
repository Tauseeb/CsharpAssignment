using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Task
{
    class Find_Largest_Number
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter First Number: ");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter Second Number: ");
            int secondNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter Third Number: ");
            int thirdNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter Fourth Number: ");
            int fourthNum = Convert.ToInt32(Console.ReadLine());

            if (firstNum > secondNum)
            {
                if (firstNum > thirdNum)
                {
                    if (firstNum > fourthNum)
                    {
                        Console.WriteLine("The Largest Number is: " + firstNum);
                    }
                }
            }
            else if (secondNum > thirdNum)
            {
                if (secondNum > fourthNum)
                {
                    Console.WriteLine("The Largest Number is: " + secondNum);
                }
                else
                {
                    Console.WriteLine("The Largest Number is: " + fourthNum);
                }
            }
            else if (thirdNum > fourthNum)
            {
                Console.WriteLine("The Largest Number is: " + thirdNum);
            }
            else
            {
                Console.WriteLine("The Largest Number is: " + fourthNum);
            }




            Console.ReadKey();
        }
    }
}
//int check1, check2, larg;
//check1 = (firstNum > secondNum ? firstNum : secondNum);
//check2 = (thirdNum>fourthNum ? thirdNum: fourthNum);
//larg = (check1 > check2 ? check1 : check2);
//Console.WriteLine("Largest Number: "+larg);

