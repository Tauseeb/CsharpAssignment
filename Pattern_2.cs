using System;

namespace Pattern_Task
{
    class Pattern_2
    {
        static void Main()
        {
            for (char i = 'A'; i <= 'E'; i++)
            {
                for (char j = 'A'; j <= i; j++)
                {
                    Console.Write(" " + j);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}




//for (char i = 'A'; i <= 'E'; i++)
//{
//    for (char j = 'A'; j <= i; j++)
//    {
//        Console.Write(" " + j);
//    }
//    Console.WriteLine();
//}