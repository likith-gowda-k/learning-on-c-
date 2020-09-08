using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

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
        public void printname()
        {
            Console.WriteLine("the name is{0}", this.fn + this.ln);
        }
    }
    public class Fulltime : employee
    {
        public float monthlySalary;

        public Fulltime(string firstname, string lastname,float monthlySalary): base (firstname,lastname)
        {
            this.monthlySalary = monthlySalary;
        }

        public void printsalary()
        {
          
            Console.WriteLine("the name is{0}", this.fn + this.ln + this.monthlySalary);
        }
    }
    class Program
    {
        public static void Main()
        {
            Fulltime f = new Fulltime("liki","gow",50000);
            f.printsalary();
        }
    }
}
