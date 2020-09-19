using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;
using System.Xml;
using System.Collections.Generic;
//Delegates are type safe function pointers 
//when we want to send function as argument we use delegates
namespace helloworld
{

    class Program
    {

        public static void Main()
        {
            List<emp> emplist = new List<emp>();
            emplist.Add(new emp { id = 10, name = "liki", exp = 5, salary = 5000 });
            emplist.Add(new emp { id = 11, name = "like", exp = 2, salary = 5000 });
            emplist.Add(new emp { id = 12, name = "likm", exp = 4, salary = 5000 });
            emplist.Add(new emp { id = 14, name = "likt", exp = 6, salary = 5000 });

            ispromote i = new ispromote(promoted);
            emp.Promote(emplist, i);


        }
        public static bool promoted(emp es)
        {
            if (es.exp >= 5)
                return true;
            else
                return false;
        }
    }

         delegate bool ispromote(emp employer);
        class emp
        {
            public int id { get; set; }
            public string name { get; set; }
            public int salary { get; set; }
            public int exp { get; set; }


            public static void Promote(List<emp> employee, ispromote employees)
            {
                foreach (emp e in employee)
                {
                    if (employees(e))
                    {
                        Console.WriteLine(e.name);
                    }
                }
            }
        }
}
    



