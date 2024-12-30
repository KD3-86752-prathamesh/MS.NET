using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeLib;

namespace HRMS
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Person Test
            //Person prson = new Person();
            //prson.AcceptInfo();
            //prson.Print() ; 
            #endregion

            #region Employee test 
            //Employee emp = new Employee();
            //Date date = new Date();
            //date.AcceptDate();
            //DepartmentType department; 
            //Enum.TryParse("HR", out department);
            //Employee emp2 = new Employee("prahtamesh" , true , "pune" , date , 1000000 , "empNO1" ,department);
            //emp.AcceptInfoEmp();
            //emp.PrintEmp();
            //Console.WriteLine(emp2);
            #endregion

            #region manager test

            //Manager mngr = new Manager();
            //mngr.AcceptInfoMngr(); 
            //mngr.PrintMngr();


            #endregion


            #region supervisor test 
            //Supervisor supervisor = new Supervisor();
            //supervisor.AcceptInfoSpvr(); 
            //supervisor.PrintSpvr();
            #endregion

            #region wageemp test 

            //WageEmp emp = new WageEmp();    
            //emp.AcceptInfoWage();   
            //emp.PrintWage();
            #endregion


            #region date class testing
            Date date  = new Date();
            date.AcceptDate(); 
            date.PrintDate();
            Console.WriteLine(Date.IsValidate(date) ? "date is valid" : "date is invalid "); 
            Date date2 = new Date(12,4,2004);
            date2.PrintDate();
            Console.WriteLine("diff betwn two dates in year is using static method   : " + Date.DiffInDate(date, date2));
           int yeardiff =  date - date2; 
            Console.WriteLine("diff betwn two date in year is usign operator overloading : " + yeardiff);
            #endregion





        }
    }
}
