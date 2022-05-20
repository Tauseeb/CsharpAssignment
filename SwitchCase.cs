using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Task
{
    class Sample
    {
        //int fnum, snum;
        
        public int UserChoice()
        {
            Console.Write("Please Enter Your Choice: \n");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("1- For Addition: ");
            Console.WriteLine("2- For Substraction: ");
            Console.WriteLine("3- For Multiplication: ");
            Console.WriteLine("4- For Division: ");
            Console.WriteLine("5- For Modulation: ");
            Console.WriteLine("---------------------------------------------------");

            int choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }
        public void Addition()
        {
            Console.WriteLine("Please Enter First value: ");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter Second Value: ");
            int secNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Addition of "+ firstNum + " and "+ secNum + " is "+ Convert.ToInt32( (firstNum + secNum)));
        }

        public void Substraction()
        {
            Console.WriteLine("Please Enter First value: ");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter Second Value: ");
            int secNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Substraction of{firstNum - secNum}");
        }
        public static void Multipliaction()
        {
            Console.Write("Please Enter First value: ");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please Enter Second Value: ");
            int secNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Multipliaction of {firstNum * secNum}");
        }
        public static void Division()
        {
            Console.WriteLine("Please Enter First value: ");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter Second Value: ");
            int secNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Division of {0} and {1} is {2}", firstNum, secNum, firstNum / secNum);
        }
        public static void Modulation()
        {
            Console.WriteLine("Please Enter First value: ");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter Second Value: ");
            int secNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Modulation of {0} and {1} is {2}", firstNum, secNum, firstNum % secNum);
        }

        static void Main(string[] args)
        {         
            Sample obj = new Sample();
             int ch;

             ch = obj.UserChoice();
            
            switch (ch)
            {
                case 1:
                    obj.Addition();
                    break;
                case 2:
                    obj.Substraction();
                    break;
                case 3:                  
                    Sample.Multipliaction();      //Call Of Static Method
                    break;
                case 4:                    
                    Sample.Division();            //Call Of Static Method
                    break;
                case 5:
                    Sample.Modulation();          //Call Of Static Method
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
            Console.ReadKey();
        }
    }
}

 

