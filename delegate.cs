using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;
using System.Xml;
//Delegates are type safe function pointers 
namespace helloworld
{
    //delegates are similar to method except delegate keyword
    public delegate void delegatefunc(string name);
  
        class Program
    {
      
        public static void Main()
        {
            //functiomn to which delegate should point should be sent as part of argument
            delegatefunc dl = new delegatefunc(name);
            dl("likith");
        }
        public static void name(string name)
        {
            Console.WriteLine(name);
        }
    }
}

