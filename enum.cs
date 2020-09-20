using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;
using System.Xml;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using Microsoft.VisualBasic.FileIO;
//Enums are strongly typed constants
//enums are added to make code readable and maintainable
namespace helloworld
{

    class Program
    {
        public static void Main()
        {
            customer[] cs = new customer[3];
            cs[0] =new customer{
                name="liki",
                gender=gender.male
            };
            cs[1] = new customer
            {
                name = "likitha",
                gender = gender.female
            };
            cs[0] = new customer
            {
                name = "likith",
                gender = gender.male
            };
            foreach(customer c in cs)
            {
                Console.WriteLine("name={0} gender={1}", c.name, getgender(c.gender));
            }
        }
        public static string getgender(gender gender)
        {
            switch (gender)
            {
                case gender.male:
                    return "Male";
                case gender.female:
                    return "female";
                default:
                    return "not correct";
            }
        }
    }
    //enum created using enum keyword and enum acts a type
    public enum gender
    {
        male,female
    }
    public class customer
    {
        public string name{ get;set;}
        //using gender as type since enum is created
        public gender gender { get; set; }
    }
   
     
}
    



