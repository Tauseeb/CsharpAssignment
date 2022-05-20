using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Task
{
    class Count_Char_String
    {
        static void Main(string []args)
        {
            string str = "google";
             
            Console.WriteLine("YOUR STRING IS: "+str);
            Console.WriteLine();
            Console.WriteLine("Please Enter Any Charector To In This String: ");
            char firstChar =Convert .ToChar( Console.ReadLine());
            Console.WriteLine("Please Enter Again Any Charector To In This String: ");
            char secondChar = Convert.ToChar(Console.ReadLine());         
            Console.WriteLine("Your Final Result is: ");
            Console.WriteLine();
            int count = 0;
            foreach (char item in str)
            {
                if (item == firstChar)
                {
                    count++;
                }
            }
            Console.WriteLine(firstChar+ " has occured "+count + " Times");

            int count1 = 0;
            foreach (char item in str)
            {
                if (item == secondChar)
                {
                    count1++;
                }
            }
            Console.WriteLine(secondChar+ " has occured "+ count1 + " Times");

             Console.ReadLine();
        }
    }
}

//string str = "google";
//Console.WriteLine(str);
//int count = str.Split('g').Length - 1;
//Console.WriteLine(count);
