using System;
 

namespace Loop_Task
{
    class PrimeOrNot
    {
        static void Main()
        {
            int counter = 0;
            Console.WriteLine("Please Enter Any Number To Check Number is Prime or Not: ");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                if (number%i==0)
                {
                    counter++;
                }
            }
            if(counter==2)
            {
                Console.WriteLine("Your Number is Prime: ");
            }
            else
            {
                Console.WriteLine("Your Number is Not Prime: ");
            }
            Console.ReadLine();

        }
    }
}
