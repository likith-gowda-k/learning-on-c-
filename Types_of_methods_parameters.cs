using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using System.Security.Cryptography.X509Certificates;
using System.Xml;
//method overloading
namespace helloworld
{

    class Program
    {
        //refernece data type
        public void print(ref int i)
        {
            i = 1000;

        }

        public void outputparam(int fn,int sn,out int sum,out int product)
        {
            sum = fn + sn;
            product = fn * sn;
        }
        public void paramsMethod(params int [] a)
        {
            foreach(int i in a)
            {
                Console.WriteLine(i);
            }
        }
            public static void Main()
            {
            int total;
            int prod;
                int j = 0;
                Program p = new Program();
                p.print(ref j);
            Console.WriteLine(j);
            p.outputparam(1, 2,out total,out prod);
            Console.WriteLine("the toatls is {0} and prod is {1}",total,prod);
            p.paramsMethod(1, 2, 3, 4);
            int[] num = new int[2];
            num[0] = 1;
            num[1] = 2;
            p.paramsMethod(num);
            }
        }
    }

