using System;

namespace Loop_Task
{
    class Calculator
    {
        public static void Add ()
        {
            Console.WriteLine("Please Enter First value: ");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter Second Value: ");
            int secNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Addition of {0} and {1} is {2}", firstNum, secNum, firstNum + secNum);
        }

        public static void Subtract()
        {
            Console.WriteLine("Please Enter First value: ");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter Second Value: ");
            int secNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Substraction of{0} and {1} is {2}", firstNum, secNum, firstNum - secNum);
        }
        public static void Multiply()
        {
            Console.Write("Please Enter First value: ");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please Enter Second Value: ");
            int secNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Multipliaction of {0} and {1} is {2}", firstNum, secNum, firstNum * secNum);
        }
        public static void Divide()
        {
            Console.WriteLine("Please Enter First value: ");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter Second Value: ");
            int secNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Division of {0} and {1} is {2}", firstNum, secNum, firstNum / secNum);
        }


        static void Main()
        {
            Console.WriteLine("*************************************Calculator*************************************");
            Console.WriteLine();
            Console.WriteLine("\t\t\t\t1.   Add");
            Console.WriteLine("\t\t\t\t2.   Subtract");
            Console.WriteLine("\t\t\t\t3.   Multiply");
            Console.WriteLine("\t\t\t\t4.   Divide");
            Console.Write("\nChoose one of the options to start: ");
            int option = Convert.ToInt32(Console.ReadLine());

           
            switch (option)
            {
                case 1:
                    Add ();
                      break;
                case 2:
                    Subtract();
                    break;
                case 3:
                    Multiply();
                    break;
                case 4:
                    Divide();
                    break;
                default:
                    Console.WriteLine("Invalid Choice ");
                    break;
                                  
            }
            Console.ReadLine();

            }                  
        }
    }

