using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice28_12_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region this is demo of the  how we  can use the perticular methods implemented from the diff diff interfaces in the same class 
            //IX maths = new Maths();
            //Console.WriteLine(maths.add(23, 24));
            //IY obj2 = new Maths();
            //Console.WriteLine(obj2  .mul(23 , 2 ));
            #endregion

            Console.WriteLine("welcome to the editor choose the spellchecker you want ");
            Console.WriteLine("1.english  2.hibru 3. hindi ");
            Console.WriteLine("enter you choice ");
            int choice = Convert.ToInt32(Console.ReadLine());
             Editor editor = new Editor(new CheckerFactory().GetChecker(choice));
            editor.checker.IsSpellcheck("chutiya");
            Console.ReadLine(); 
        }
    }


    internal class Editor
    {
        public  Ispellcheck checker;
        public Editor(Ispellcheck checker)
        {

            if (checker == null)
            {
                this.checker = new EnglishSpellChecker();
            }
            else
            {
                this.checker = checker;
            }

        }
    }


    internal class CheckerFactory
    {
    public Ispellcheck GetChecker(int choice)
        {
            if(choice == 1)
            {
                return new EnglishSpellChecker();
            }
            else if (choice == 2)
            {
                return new HibruSpellChecker(); 
            }
            else if (choice == 3 )
            {
                return new HindiSpellChecker(); 
            }
            else
            {
                return null;
            }

        }
    }

    internal interface Ispellcheck
    {
        void   IsSpellcheck(string word );
    }

    internal class EnglishSpellChecker : Ispellcheck
    {
        public void IsSpellcheck(string word)
        {
            Console.WriteLine("english spell checking is done ");
        }
    }

    internal class HindiSpellChecker : Ispellcheck
    {
        public void IsSpellcheck(string word)
        {
            Console.WriteLine("hindi spell checking is done ");
        }
    }


    internal class HibruSpellChecker : Ispellcheck
    {
        public void IsSpellcheck(string word)
        {
            Console.WriteLine("hibru spell checking is done ");
        }
    }












    internal interface IX
    {
        int add (int a , int b);
        int sub (int a , int b);    
    }

    internal interface IY
    {
        int mul (int a , int b);    
        int div (int a , int b);    
    }

    internal class Maths : IX, IY
    {
        public int add(int a, int b)
        {
            return a+b; 
        }

        public int div(int a, int b)
        {
            return a /b; 
        }

        public int mul(int a, int b)
        {
            return a * b ;
        }

        public int sub(int a, int b)
        {
            return a - b; 
        }
    }

}
