using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLib
{

 public 	enum DepartmentType
	{
		PRODUCTIONS,
		TESTING,
		DEVELOPEMENT,
		HR
	}




    public  class Employee : Person
    {

		public static int _id = 1;

		public int id; 

		private double _salary;

		private string _designation;

		protected DepartmentType _department;

		public DepartmentType department
		{
			get { return _department; }
			set { _department = value;  }
		}
		public string designation
		{
			get { return _designation; }
			set { _designation = value; }
		}


		public double  salary
		{
			get { return _salary; }
			set { _salary = value; }
		}


		public 	Employee() { }

		
		public Employee(string name , bool gender , string address , Date birth ,  double salary , string designation , DepartmentType department )
		{
			this.name = name;
			this.gender = gender; 
			this.address = address;
			this.birth = birth; 
			this.salary = salary;  
			this.designation = designation;
			this.department = department;
			this.id = Employee._id++; 
		} 


		public void AcceptInfoEmp ()
		{
			base.AcceptInfo ();
				
            Console.WriteLine("enter designation");
			designation =  Console.ReadLine();
            Console.WriteLine("enter salary");
			salary = Convert.ToDouble( Console.ReadLine());
            Console.WriteLine("enter department");
			Enum.TryParse(Console.ReadLine(), out _department);
			this.id = Employee._id++; // here id is autorgenerated   
		}

		public void PrintEmp ()
		{
			base.Print(); 
			Console.WriteLine(  "Employee : " + "id- " + this.id + " salary- " + this.salary + " designation- " + this.designation + " department- " + this.department); 
		}


        public override string ToString()
        {
			return base.ToString() + "Employee : " + "id- " + this.id + " salary- " + this.salary + " designation- " + this.designation + " department- " + this.department; 
        }

    }
}
