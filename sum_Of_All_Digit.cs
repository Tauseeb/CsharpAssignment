using System;

namespace Practice_Task
{
    class SumOfAllDigit
    {
        static void Main()
        {
            int num, sum = 0;
            Console.WriteLine("Please Enter The Number To Sum Of All Digit: ");
            num = Convert.ToInt32(Console.ReadLine());

            while (num != 0)
            {
                sum = sum + num % 10;
                num = num / 10;
            }
            Console.WriteLine("Sum Of All Digit is= {0}", sum);
            Console.ReadLine();
        }
    }
}
