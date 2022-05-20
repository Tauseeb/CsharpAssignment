using System;

namespace Pattern_Task
{
    class Pattern_5
    {
        static void Main()
        {  
            for (char i = 'A'; i <= 'E'; i++)
            {
                for (char j = 'A'; j <= i; j++)
                {
                    Console.Write(" " + i);
                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}
       