using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment_2
{





    internal class Program
    {

# region this are the four static methods which will get the ref of the local variable list 
        public static void CreateArray(ref Student[] list)
        {
            Console.WriteLine("enter the size of array ");
            int size = Convert.ToInt32(Console.ReadLine());
            list = new Student[size];
        }

        public static void AcceptInfo(ref Student[] list)
        {
            int size = list.Length;
            for (int i = 0; i < size; i++)
            {
                Student st = new Student();
                st.AcceptDetails();
                list[i] = st;
            }

        }

        public static void PrintArray(ref Student[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine(list[i].GetDetails());
                Console.WriteLine();
                Console.WriteLine();
            }
        }

        public static void ReverseArray(ref Student[] list)
        {
            Student[] Reversed = new Student[list.Length];
            int count = 0;
            for (int i = list.Length - 1; i > -1; i--)
            {
                Reversed[count++] = list[i];
            }

            for (int j = 0; j < list.Length; j++)
            {
                list[j] = Reversed[j];
            }
        }
#endregion



        static void Main(string[] args)
        {
            Student[] StudentList = null;

            CreateArray(ref  StudentList); // to pass the reference of the local vairable created inside the main method 
                                          // we need to pass it with  the ref key word means we are passing the reference of hte 
                                           // studentlist 
            Console.WriteLine("array created"); 
            AcceptInfo(ref StudentList);
            Console.WriteLine("info accepted");
            PrintArray(ref StudentList); 
             
            ReverseArray(ref StudentList);
            Console.WriteLine("Array reversed ");
            PrintArray(ref StudentList); 
            
        }
    }


    #region student struct 
    struct Student
    {
        public string name { get; set; }
        public bool gender { get; set; }
        public int age { get; set; }
        public int std { get; set; }
        public char div { get; set; }
        public double marks { get; set; }

        // by default access specifier of the data members are priate in struct and class 
        // by default access specifieer of the member functions in the struct is  private 

        public void AcceptDetails()
        {
            Console.WriteLine("enter name of student");
            this.name = Console.ReadLine();
            Console.WriteLine("enter gender of student boolean value true for male ");
            this.gender = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("enter age of student ");
            this.age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter std of student ");
            this.std = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter div of the student ");
            this.div = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("enter marks of the student");
            this.marks = Convert.ToInt32(Console.ReadLine());
        }

        public Student(string name, bool gender, int age, int std, char div, double marks)
        {
            this.name = name;
            this.gender = gender;
            this.age = age;
            this.std = std;
            this.div = div;
            this.marks = marks;
        }


        // default constructor are not available in this version of c#


        public string GetDetails()
        {
            return "name: " + name + " gender:  " + gender.ToString() + " age: " + age.ToString() + " std: " + std.ToString() + " div: " + div.ToString() + " marks: " + marks.ToString();
        }



    }

    #endregion




}
