//access modifiers private,protected,internal,protected internal,public 
//by adding region we can coolapse or elobrate the methods,properties
/*private members are avaliable within type ,public are avialable anywhere
 * protected are available within type and to type that are derived from containing type
 * Anywhere within containing assembly
 * anywhere with in containing assembly and from with in a derived class in any another assembly
 * In .net when we execute a program assembly is created ,it is of two types exceutable and dll
 */
 namespace Assembly_2 
{
    public class Assembly_2Class1 : Assembly_1Class1
    { 
        public void print()
        {
            //creating reference will allow to use class of one project in another
            //when we use protected internal we cannot access with exsisting class (assembly class 1)
            Assembly_2Class1 ass = new Assembly_2Class1();
            ass.id = 101;

        }
    }
}
using System;


namespace Assembly_1
{
    public class Assembly_1Class1
    {
        protected internal int id = 101;
    }
}
