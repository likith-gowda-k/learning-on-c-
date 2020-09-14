using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using System.Security.Cryptography.X509Certificates;
using System.Xml;
//abstraction Using properties
namespace helloworld
{

    class Student
    {
        private int _id;
        private string _Name;
        public int _passMark = 35;

        //since pass mark is only get we use read only property
        public int Passmark
        {
            get
            {
                return this._passMark;
            }
        }

        //PS:no () for properties
        public string Name
        {
            set
            {
                if(string.IsNullOrEmpty(value))
                    throw new Exception("Name Cannot be Null");
                this._Name = value;
            }
            get
            {
                if (string.IsNullOrEmpty(this._Name))
                    return "No Name";
                else
                    return this._Name;
            }
        }

        public int Id
        {
            set
            {

                if (value <= 0)
                    throw new Exception("Id cannot be negative");
                this._id = value;
            }
            get
            {
                return this._id;
            }
        }
      
    }
    class Program
    { 
        public static void Main()
            {
            Student s = new Student();
            //assinging values should be done explicitly with== and not like method
            s.Name="likith";
            s.Id = 100;
            Console.WriteLine(s.Name);
            Console.WriteLine(s.Id);
        }
       
        }
    }

