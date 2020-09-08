using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using System.Security.Cryptography.X509Certificates;
//method overloading
namespace helloworld
{
  
    class Program
    {
        public void print(string fname )
        {
            Console.WriteLine(fname);
        }
        public void print(string fanme,string lname)
        {
            Console.WriteLine("The name is {0}", fanme + lname);
        }
        public static void Main() 
        {
            Program p = new Program();
            p.print("likith");
            p.print("likith", "GOwda");
        }
    }
}
