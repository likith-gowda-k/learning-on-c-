using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Security.Cryptography.X509Certificates;
using System.Xml;
//Explicit Interface Implementation , when two interfaces have same method we use explicit implementation
namespace helloworld
{
    interface ICustomer
    {
        void print();
    }
    interface IStudent
    {
        void print();
    }
    class customer : ICustomer,IStudent 
    {
        //defining default explicit implementation we define method normally
        public void print()
        {
            throw new NotImplementedException();
        }

        //explicit implementation doesn't have access modifier 
        void ICustomer.print()
        {
            Console.WriteLine("Interface");
        }
    }
    class Program
    {
        public static void Main()
        {
            customer c = new customer();
            //to call explicit interface we typecast first
            ((ICustomer)c).print();
            //to call default implemenation
            c.print();

        }
    }
}

