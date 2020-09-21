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
//Enums are strongly typed constants,enum is a class
//enums are added to make code readable and maintainable
//if program uses set of integral numbers ,consider replacing that with enum
//enums are strongly typed --because even if enum is integer type we cannot assign it to int (implicit cobversion is not possible)
//ex: gender gender = 3 will fail we have to type cast 

//enum is value type  
namespace helloworld

{

    class Program
    {
        public static void Main()
        {
            //enum get values is expecting type as argument , type can be anything as class , method
            //return type is array hence using int[] to conver it into int array type
            int [] ar=(int[])Enum.GetValues(typeof(gender));
            foreach(int i in ar)
            {
                Console.WriteLine(i);
            }
            string[] ars = (string[])Enum.GetNames(typeof(gender));
            foreach (string i in ars)
            {
                Console.WriteLine(i);
            }
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
            cs[2] = new customer
            {
                name = "likitha",
                gender = gender.female
            };

            foreach (customer c in cs)
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
    //enum is default integer type  and starts with 0 and use getvalues() to 
    //we can type cast enum type by inheriting like : short
    //we can set the default value to our value
    public enum gender
    {
        male=5,female=23
    }
    public class customer
    {
        public string name{ get;set;}
        //using gender as type since enum is created
        public gender gender { get; set; }
    }
   
     
}
    



