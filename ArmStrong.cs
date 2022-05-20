using System;
 
namespace Loop_Task
{
    class ArmStrong
    {
        static void Main()
        {
            int rem, arm = 0, comp;
            Console.WriteLine("Please Enter Any Number To Check Value is ArmStrong or Not: ");
            int num = Convert.ToInt32(Console.ReadLine());
            
            comp = num;     // num value assigned to comp variable
            while (num!=0)
            {
                rem = num % 10;
                arm = arm + rem * rem * rem;
                num = num / 10;
            }
            if(comp==arm)
            {
                Console.WriteLine("is an ArmStrong Number: ");
            }
            else
            {
                Console.WriteLine("is Not ArmStrong Number: ");
            }

            Console.ReadLine();
        }
    }
}
