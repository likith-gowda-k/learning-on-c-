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
//Exception handling-- it is unforseen error while program is running
//exception is oj=bject that is derived from exception class. all exceptions are inherited from system.exception class
//always keep more specific exception at top and genral exception at bottom
namespace helloworld
{

    class Program
    {

         

        public static void Main()
        {
            StreamReader sr = null;
            try
            {
                 sr = new StreamReader(@"C:\samplefiles\data.txt");
                Console.WriteLine(sr.ReadToEnd());
                sr.Close();

            }
            catch(Exception e)
            {
                //message prints useful information
                Console.WriteLine(e.Message);

                //stack trace prints the line which caused the error
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                if(sr!=null)
                    sr.Close();
                Console.WriteLine("this is finally");
               
            }


        }
    }
        

     
}
    



