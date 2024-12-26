using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Assignment1
{
    class Maths
    {
        public  int add(int a, int b)
        {
            return a + b;

        }

       public   int subtract(int a, int b)
        {
            return a - b;
        }

        public int multiply(int a, int b)
        {
            return (a * b); 
        }

        public int divide(int a, int b)
        {
            return (a / b);
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Maths maths = new Maths();


            int choice; 
            do
            {
                Console.WriteLine("welcome to sunbeam claculator...");
                Console.WriteLine("0.exit\n1.add \n 2.sub \n 3.mul \n 4.div");
                Console.WriteLine("enter your choice"); 
                 choice = int.Parse(Console.ReadLine());
                int num1 = 0;
                int num2 = 0; 
                if (choice != 0) {
                    Console.WriteLine("enter num1 ");
                     num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("enter num2");
                     num2 = int.Parse(Console.ReadLine());
                } 

                switch (choice)
                {

                    case 1:
                        Console.WriteLine(maths.add(num1, num2));
                        break;

                    case 2:
                        Console.WriteLine(maths.subtract(num1, num2));
                        break;


                    case 3:
                        Console.WriteLine(maths.multiply(num1, num2));
                        break;

                    case 4:
                        Console.WriteLine(maths.divide(num2, num1));
                        break;

                    

                    default:

                        Console.WriteLine("wrong choice :(((("); 
                        break;
                }



            }
            while (choice != 0);
        }
    }
}
