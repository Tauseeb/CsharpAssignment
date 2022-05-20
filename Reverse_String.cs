using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Task
{
    class Reverse_String
    {
        static void Main(string[] args)
        {
            string value, rev;
            Console.WriteLine("Enter Any String Value: ");
            value = Console.ReadLine();
            rev = "";
            Console.WriteLine("String Value is: " + value);
            int len;
            len = value.Length - 1;
            for (len = value.Length - 1; len >= 0; len--)
            {
                rev = rev + value[len];
            }
            Console.WriteLine("Reverse String Value is: " + rev);
            Console.ReadKey();
        }
    }
}



//int i, num;
//int[] arr = new int[5];
//Console.WriteLine("Enter the Elements: ");
//for(i=0;i<5;i++)
//{
//    arr[i] = Convert.ToInt32(Console.ReadLine());
//}
//Console.WriteLine("After Element: ");
//Array.Sort(arr);
//foreach (int item in arr)
//{
//    Console.WriteLine(item);
//}
//Console.WriteLine("Reverse Elements: ");
//Array.Reverse(arr);
//foreach (int item in arr)
//{
//    Console.WriteLine(item);
//}
//Console.WriteLine("Second Largest Number is: "+arr[1]);