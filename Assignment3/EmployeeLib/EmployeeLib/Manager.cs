using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLib
{
    public  class Manager :Employee
    {

		private double _bonus;

		public double bonus
		{
			get { return _bonus; }
			set { _bonus = value; }
		}

		public Manager()
		{

		}

		public Manager(string name, bool gender, string address, Date birth, double salary,  DepartmentType department, double bonus)
        {
            this.bonus = bonus;
            this.name = name;
            this.gender = gender;
            this.address = address;
            this.birth = birth;
            this.salary = salary;
            this.designation = "MANAGER"; 
            this.department = department;
            this.id = Employee._id++;
        }

        public  void AcceptInfoMngr ()
        {
            base.AcceptInfo(); 
            Console.WriteLine("enter salary");
            salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter department");
            Enum.TryParse(Console.ReadLine(), out _department);
            this.id = Employee._id++; // here id is autorgenerated 
            Console.WriteLine("enter bonus for manager");
            this.bonus = Convert.ToDouble(Console.ReadLine());
            this.designation = "Manager"; 
        }


        public void PrintMngr()
        {
            base.PrintEmp();
            Console.WriteLine("bonus for manager- " + this.bonus); 

        }

        public override string ToString()
        {
            return base.ToString() + " " + this.bonus;
        }
    }
}
