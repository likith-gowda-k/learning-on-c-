using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;
using System.Xml;
using System.Collections.Generic;
//MultiCastDelegate- is a delegate which can have referneces to more than one funcion
//multicast delegate it invokes in same order as pointed
//it is implementated in making observer design patterns
namespace helloworld
{
    public delegate void sampledele();
    public delegate int sampledele2();
    public delegate void sampledele3(out int result);
    class Program
    {

      
        public static void Main()
        {
            //invoking delegates with +
            sampledele s1, s2, s3,s4;
            s1 = new sampledele(method1);
            s2 = new sampledele(method2);
            s3 = new sampledele(method3);
            //asserting s1 s2 s3 to s4 to form common delegate
            s4 = s1 + s2 + s3;
            s4();

            //invoking delegate with +=
            sampledele s = new sampledele(method1);
            s += method2;
            s += method3;
            s();

            //we can remove delegate by using -+
            s -= method3;
            s();

            //delegate method with return type
            sampledele2 se = new sampledele2(method4);
            se += method5;
            int res = se();
            Console.WriteLine(res);
            //note that the method returns only the last method being called

            //delegate with output parameters in request
            sampledele3 seo = new sampledele3(method6);
            seo += method7;
            int result = -1;
            seo(out result);
            //result will conatin last output parameter

        }
        public static void method1()
        {
            Console.WriteLine("method1");
        }
        public static void method2()
        {
            Console.WriteLine("method2");
        }
        public static void method3()
        {
            Console.WriteLine("method3");
        }
        public static int method4()
        {
            return 1;
        }
        public static int method5()
        {
            return 2;
        }
        public static void method6(out int num)
        {
            num = 4;
        }
        public static void method7(out int num)
        {
            num = 5;
        }


    }

     
}
    



