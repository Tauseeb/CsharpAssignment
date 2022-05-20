using System;

namespace Loop_Task
{
    class HCF
    {
        static void Main()
        {
            //int num, num1;

            Console.WriteLine("Enter First Number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            while (num!=num1)
            {
                if(num>num1)
                {
                    num = num - num1;
                }
                else
                {
                    num1 = num1 - num;
                }
            }
            Console.WriteLine("HCF: "+num);
            Console.ReadLine();
        }
    }
}
