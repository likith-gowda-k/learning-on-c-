using System.IO;
using System;
using System.Collections.Generic;

//Attributes allow you add declrative information which can be retrived using reflection 
//predefined attributes obselete(mark type and type members outdated),web method(to expose method as xml web service method),serillizable
//An attributes is a class that inherits from system.attribute baseclass
class Program
{
    static void Main()
    {
        int ans = calci.Add(new List<int>(){10,20});
        Console.WriteLine(ans);
    }
}
public class calci
{
    //here we add obselete attribute to make sure its outdated
    [Obsolete]
    public static int Add(int a ,int b)
    {
        return a+b;
    }
    
    public static int Add(List<int> num)
    {
        int res =  0;
        foreach(int n in num)
        {
            res= res+n;
        }
        return res;
    }
}
