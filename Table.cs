using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Task
{
    class Table
    {
        static void Main(string[] args)
        {
            int tab = 2;
            for(int i=1;i<=10;i++)
            {
                Console.WriteLine("{0} * {1} = {2}",tab,i,tab*i);
            }
            Console.ReadLine();
        }
    }
}
