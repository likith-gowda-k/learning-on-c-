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
//exception is a class
//Exception handling-- custom exception are the exceptions which are explicitly created 
namespace helloworld
{

    class Program
    {

         

        public static void Main()
        {

            throw new customException("this is custom exception"); 
        }
    }
    //we use serialization when we have to transfer data from one doamin to another 
    [Serializable]
    public class customException : Exception
    {
        //implementing base constructor from exception class
        public customException() : base()
            {
            }
        //creatring parameter constructor for calling constructor with message ,inheriting from exception class
        public customException(string message) : base(message)
        {

        }
        public customException(string message, Exception innerException) : base(message,innerException)
        {

        }
        //to communicate between application boundries we use serializable
        public customException(SerializationInfo info,StreamingContext context):base(info,context)
        {

        }

    }
     
}
    



