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

namespace helloworld

{
    //late binding-- we do late binding only when we don't have knowledge of class for which instance need to be created
   
    class Program
    {
        public static void Main()
        {
            Assembly executingAssembly = Assembly.GetExecutingAssembly();

            Type customtype = executingAssembly.GetType("helloworld.customer");

            object customInstance = Activator.CreateInstance(customtype);

            MethodInfo getFullName = customtype.GetMethod("GetFullName");

            string[] parameters = new string[2];
            parameters[0] = "likith";
            parameters[1] = "gowda";

            string fullName = (string) getFullName.Invoke(customInstance, parameters);
        }
    } 
    public class customer 
    {
        public string GetFullName(string fn , string ln)
        {
            return fn + ln;
        }
    }
     
}
    



