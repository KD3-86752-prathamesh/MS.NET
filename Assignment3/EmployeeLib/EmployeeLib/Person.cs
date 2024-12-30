using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLib
{
    public class Person
    {
		private string _name;

		private bool _gender;

		private string _address;

		protected Date birth {  get; set; }

		
		public Person()
		{

		}

	public Person (string name , bool gender , string address , Date birth)
		{
			this.name = name;
			this.address = address;
			this.birth = birth;
			this.gender = gender; 
		}


		public void AcceptInfo()
		{
            Console.WriteLine("enter name");
			this.name = Console.ReadLine();
            Console.WriteLine("enter address"	);
			this.address = Console.ReadLine();
            Console.WriteLine("enter gender");
			this.gender = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("enter birthdate ");
			Date birthDate = new Date();
			birthDate.AcceptDate();
			this.birth = birthDate; 
		}


		public void Print()
		{
				 
			Console.WriteLine( "name- " +this.name + " address- " + this.address + " gender- " + this.gender + " birthdate- " +birth );
		}

        public override string ToString()
        {
            return "name- " + this.name + " address- " + this.address + " gender- " + this.gender + " birthdate- " + birth;
        }


        public string address
		{
			get { return _address; }
			set { _address = value; }
		}


		public bool gender
		{
			get { return _gender; }
			set { _gender = value; }
		}


		public string name
		{
			get { return _name; }
			set { _name = value; }
		}


	}
}
