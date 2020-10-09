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
using System.Reflection;
//Reflection is the ability of inspecting an assemblies metadata at runtime  
//when class is complied it changes to intermediate lang  called assembly .assembly consist of meta data and intermediate lang
//Reflection uses :
/*When we drag and drop a button on a win forms or asp.net application.the properties window uses reflection to show all properties ,so it is extensively used by ide or UI designers
 * Late binding , we can use reflection to dynamically create an instance of a type,about which we don't have any information at compilaation
 * when we have two alternate implementation of an interface.and allowed to choose one using config file,with reflection you can simply read  the name
 * whose implementation we want and instanciate an instance of that class
 */
namespace helloworld

{
    //Reflection is inherited from type class
    class Program
    {
        public static void Main()
        {
            Type T = Type.GetType("helloworld.customer");
            //PropertyInfo array is the return type of getProperties
            PropertyInfo[] properties = T.GetProperties();
            foreach(PropertyInfo p in properties)
            {
                Console.WriteLine(p.Name);
            }
        }
    } 
    public class customer
    {
        public void write()
        {

        }
    }
     
}
    



