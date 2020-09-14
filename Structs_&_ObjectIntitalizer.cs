using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Security.Cryptography.X509Certificates;
using System.Xml;
//structs
namespace helloworld
{
    //structs are similar to class can have object,constructors etc
    public struct Student
    {
        private int _id;
        private string _name;

     public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        public Student (string name,int id)
        {
            this._name = name;
            this._id = id;
        }
        public void print()
        {
            Console.WriteLine("name is {0}",this._name);
        }
    }
    class Program
    { 
        public static void Main()
            {
            Student s = new Student();
            s.Name="likith";
            s.Id = 100;
            s.print();

            //object Initializer 
            Student s2 = new Student
            {
                Id = 200,
                Name = "gowda"
            };
            s2.print();
        
        }
       
        }
    }

