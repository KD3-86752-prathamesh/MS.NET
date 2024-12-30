using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLib
{
    public  class WageEmp : Employee
    {
        private int _hours;

        private int _rate;

        public WageEmp ()
        {

        }
        
        public WageEmp(string name, bool gender, string address, Date birth, double salary, DepartmentType department, int hours , int rate)
        {
          this.name = name;
            this.gender = gender;
            this.address = address; 
            this.birth = birth;
            this.salary = salary;
            this.department = department;
            this.hours = hours;
            this.rate = rate;
            this.designation = "Wage";
            this.id = _id++; 
        }


        public void AcceptInfoWage ()
        {
            base.AcceptInfo();
            Console.WriteLine("enter salary");
            salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter department");
            Enum.TryParse(Console.ReadLine(), out _department);
            this.id = Employee._id++; // here id is autorgenerated 
            this.designation = "WAGE";
            Console.WriteLine("enter hour for wage employee ");
            this.hours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter rate per hour ");
            this.rate = Convert.ToInt32 (Console.ReadLine());   
        }


        public void PrintWage()
        {
            base.PrintEmp(); 
            Console.WriteLine("hours- " + this.hours + " rate- "  + this.rate);
        }

        public override string ToString()
        {
            return base.ToString() + " " + "hours- " + this.hours + " rate- " + this.rate;
        }


        public int rate
        {
            get { return _rate; }
            set { _rate = value; }
        }


        public int hours
        {
            get { return _hours; }
            set { _hours = value; }
        }


        

        

    }
}
