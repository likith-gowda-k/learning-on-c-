using System;

//Boxing -- converting value type to object type --here integer is structure of value to tyep where as object is reference type 
//becxause of boxing performance is degraded
namespace project_Github
{
    class Program
    {
        static void Main(string[] args)
        {
            bool equal = calci.isEqual<string>("A", "B");

            if (equal)
            {
                Console.WriteLine("equal");
            }
            else
            {
                Console.WriteLine("not");
            }
        }

    }
    public class calci
    {
        //using object as argument because it can take any input string or int ,
        //Note:every data type is unherited from System.object class
        public static bool isEqual(object a ,object b)
        {
            return a == b;
        }
   
    //generics we can avoid problems of boxing
    //here is T is type which will be assigned @ compile time


    public static bool isEqual<T>(T a,T b)
    {
            return a.Equals(b);
    }
    }
}
