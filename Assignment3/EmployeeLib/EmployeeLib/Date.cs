using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLib
{
    public  class Date
    {
		private  int _Day;

		private int _month;

		private int _year;

		public int year
		{
			get { return _year; }
			set { _year = value; }
		}


		public int month
		{
			get { return _month; }
			set { _month = value; }
		}


		public int day
		{
			get { return _Day; }
			set { _Day = value; }
		}



		public 	Date() { 
		
		}

		public Date(int day, int month, int year)
		{
			this.day = day;
			this.month = month; 
			this.year = year;

		}

		public void AcceptDate()
		{
            Console.WriteLine("enter day ");
			this.day    = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter month"	);
			this.month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter year");
			this.year = Convert.ToInt32(Console.ReadLine());
		}

		public void PrintDate()
		{
            Console.WriteLine("Date : " + day +"/" +month +"/" + year);
		}


		public override string   ToString()
		{
			return "Date : " + day + "/" + month + "/" + year; 

        }

		public static int DiffInDate (Date date1, Date date2)
		{
			
			return Math.Abs(date1.year - date2.year);

		}


		// here we are performing operator overloading , for this purporse syntax is, it should be static and you have to mentions return type
		// then you have to write the keyword operator , here we have som limition that which operators we can overload, so look after it. 
		public static int operator -(Date date1, Date date2)
		{
			return Math.Abs(date1.year - date2.year); 
		}


		public static bool IsValidate (Date date)
		{
			bool daypass = false;
			bool monthpass = false; 
			bool yearpass = false;
			if (date.day <= 31 && date.day >=1 )
			{
				daypass = true; 
			}
			if ( date.month <= 12 && date.month >= 1 )
			{
				monthpass = true;
			}
			if ( date.year <= 2025 && date.year>= 1900)
			{
				yearpass = true;
			}

			return daypass && monthpass && yearpass;
		}

	}
}
