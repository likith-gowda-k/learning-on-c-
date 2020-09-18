using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;
using System.Xml;
//InterfaceImplementation using 
namespace helloworld
{
    interface IA
    {
        void Aprint();
    }
    class a : IA
    {
        public void Aprint()
        {
            Console.WriteLine("A");
        }

    }
        interface IB
        {
            void Bprint();
        }
        class b : IB
        {
            public void Bprint()
            {
                Console.WriteLine("B");
            }
        }

        class ab :IA,IB
        {
            a a = new a();
            b b = new b();
            public void Aprint()
            {
                a.Aprint();
            }
            public void Bprint()
            {
                b.Bprint();
            }

        }

        class Program
    {
      
        public static void Main()
        {

                ab ab = new ab();
                ab.Aprint();
                ab.Bprint();
        }
    }
}

