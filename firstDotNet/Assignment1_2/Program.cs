using System.ComponentModel;

namespace Assignment1_2
{
    internal class Program
    {
        static int add (int num1 , int num2)
        {
            return num1 + num2;
        }

        static int sub(int num1, int num2)
        {
            return num1 - num2;  
        }

        static int mul(int num1, int num2)
        { return num1 * num2; }

        static int div(int num1, int num2)
        {
            return num1 / num2;
        }



        static void Main(string[] args)
        {
            Console.WriteLine("welcome to the sunbeam calculator");
            
            
           int choice ;
            choice = int.Parse(args[0]);
           
            int num1 ;
            num1 = int.Parse(args[1]); 
            
            int num2  ;
            num2 = int.Parse(args[2]);

            int Result = 0; 

            switch (choice)
            {

                case 1: 
                 Result =    add(num1, num2);
                    break;
                case 2:
                    Result = sub(num1, num2);
                    break;
                case 3:
                    Result = mul(num1, num2);
                    break; 
                case 4:
                    Result = div(num1, num2); 
                    break;

                default: Console.WriteLine("you entered wrong choice"); 
                    break;
            }

            Console.WriteLine("Result of the calculation is : "+  Result);

            Console.ReadLine(); 
        }
    }
}
