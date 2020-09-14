using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using System.Security.Cryptography.X509Certificates;
using System.Xml;

namespace helloworld
{

    class Student
    {
        private int _id;
        private string _Name;
        public int _passMark = 35;

        public void SetName(String Name)
        {
            if (string.IsNullOrEmpty(Name))
                throw new Exception("Name Cannot be Null");
            this._Name = Name;
        }
        public string GetName()
        {
            if (string.IsNullOrEmpty(this._Name))
                return "No Name";
            else
                return this._Name;

        }

        public void SetId(int Id)
        {
            if (Id <= 0)
                throw new Exception("Id cannot be negative");
            this._id = Id;
        }
        public int GetId()
        {
            return this._id;

        }
    }
    class Program
    { 
        public static void Main()
            {
            Student s = new Student();
            s.SetName("likith");
            Console.WriteLine(s.GetName());
            }
       
        }
    }

