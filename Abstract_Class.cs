using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Security.Cryptography.X509Certificates;
using System.Xml;
//Abstract class ,use abstract keyword and these classes are incomplete becuase it cannot have implementation
//these classes cannot be instanciated
//Abstract class cannot be sealed(sealed means cannot be used as base class)
namespace helloworld
{
    public abstract class cutomer
    {
        //abstract methods shouldn't have body declration  
        public abstract void print();
       
    }
    class Program : cutomer
    {
        // to provide implemenation for abstract class we need to use override keyword
        public override void print()
        {
            Console.WriteLine("this is abstract CLass");

        }
        public static void Main()
        {
            //child refernce variable can hold parent object 
            cutomer c = new Program();
            c.print();

        }
    }
}

