using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Security.Cryptography.X509Certificates;
using System.Xml;
//Interface is similar to class but doesn't have implemention
//interface cannot have feilds and access modifier
//we cannot create instance for interface
namespace helloworld
{
    interface ICustomer
    {
        void print();
    }
    class customer : ICustomer
    {
        public void print()
        {
            Console.WriteLine("Interface");
        }
    }
    class Program
    {
        public static void Main()
        {
            customer c = new customer();
            c.print();

        }
    }
}

