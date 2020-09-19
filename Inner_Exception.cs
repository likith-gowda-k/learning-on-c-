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
//Exception handling-- Inner Exception returns the exception instance that caused the current exception 
//to retain the orginal exception pass it as a parameter to the constructor, of current exception
//use gettype() method to get inner exception and always check whether they are not null
namespace helloworld
{

    class Program
    {

         

        public static void Main()
        {
            StreamReader sr = null;
            try {
                try
                {
                    sr = new StreamReader(@"C:\samplefiles\data.txt");
                    Console.WriteLine(sr.ReadToEnd());
                    sr.Close();

                }
                catch (Exception e)
                {
                    //message prints useful information
                    Console.WriteLine(e.Message);

                    //stack trace prints the line which caused the error
                    Console.WriteLine(e.StackTrace);
                    //here get type provides the information which caused the exception
                    if (File.Exists(@"C:\samplefiles\data.txt"))
                        Console.WriteLine(e.GetType().Name);
                    else
                    {
                        //throw keyword is used when we want to throw exception explicitly
                        //when we want to retain original exception append it to the constructor
                        throw new Exception("the file is not present", e);
                    }

                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.GetType().Name);
                if (ex.InnerException!=null)
                Console.WriteLine(ex.InnerException.GetType().Name);
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
    



