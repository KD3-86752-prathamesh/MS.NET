using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLib
{
    public  class Supervisor : Employee
    {

        private int _subbordinates;

        public int subbordinates
        {
            get { return _subbordinates; }
            set { _subbordinates = value; }
        }


        public Supervisor() {

            }

        public Supervisor(string name, bool gender, string address, Date birth, double salary, DepartmentType department, int subbordinates)
        {
            this.name = name; 
            this.gender = gender;
            this.address = address; 
            this.birth = birth;
            this.salary = salary;
            this.designation = "SUPERVISOR"; 
            this.department = department;
            this.subbordinates=subbordinates;
            this.id = _id++; 
        }

        public  void AcceptInfoSpvr()
        {
            base.AcceptInfo();
            Console.WriteLine("enter salary");
            salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter department");
            Enum.TryParse(Console.ReadLine(), out _department);
            this.id = Employee._id++; // here id is autorgenerated 
            this.designation = "SUPERVISOR";
            Console.WriteLine("enter subbordinates");
            this.subbordinates = Convert.ToInt32(Console.ReadLine()); 
        }

        public void PrintSpvr()
        {
            base.PrintEmp();
            Console.WriteLine("subbordinates- " + this.subbordinates); 

        }

        public override string ToString()
        {
            return base.ToString() + " " + this.subbordinates;
        }
    }
}
