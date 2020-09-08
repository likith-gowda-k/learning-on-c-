using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
//polymorphism allows us to invoke derived class method through a base class during run time
namespace helloworld
{
    public class employee
    {
        public string fn;
         public string ln;

        public employee(string firstname,string lastname)
        {
            this.fn = firstname;
            this.ln = lastname;
        }
        public virtual void printname()
            //adding virtual keyword to base class
        {
            Console.WriteLine("the name is{0} no designation", this.fn + this.ln);
        }
    }
    public class Fulltime : employee
    {
        string desig;
        public Fulltime(string firstname, string lastname, string desg):base (firstname,lastname)
        {
            this.desig = desg;
        }

        public override void printname()
            //adding override keyword to child class
        {
            Console.WriteLine("the name is {0} and designation {1}", this.fn + this.ln,this.desig);
           
        }

    }
    public class Parttime : employee
    {
        string desig;
        public Parttime(string firstname, string lastname, string desg) : base(firstname, lastname)
        {
            this.desig = desg;
        }

        public override void printname()
        //adding override keyword to child class
        {
            Console.WriteLine("the name is {0} and designation {1}", this.fn + this.ln, this.desig);

        }

    }
    class Program
    {
        public static void Main() 
        {
            employee[] em = new employee[3];
            em[0] = new employee("likith","gowda");
            em[1] = new Fulltime("jay", "anth", "softwareEngineer");
            em[2] = new Parttime("abhi", "shek", "manager");

            foreach(employee e in em)
            {
                e.printname();
            }
            


        }
    }
}
