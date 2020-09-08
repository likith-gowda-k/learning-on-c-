//In method overriding a base class reference variable pointing to a child class object,will invoke the overridden method in the child class


public class BaseClass
{
public virtual void print()
{
Console.WriteLine("Base class print method");
}
}
public class DerivedClass : BaseClass
{
public override void print()
{
Console.WriteLine("Child Class Print Method");
}
} public class program
{
public static void Main()
{
BaseClass B = new DerivedClass();
B.print()
}
}

//In method hiding a base class reference variable pointing to a child class object,will invoke the hidden method method in the base class
public class BaseClass
{
public virtual void print()
{
Console.WriteLine("Base class print method");
}
}
public class DerivedClass : BaseClass
{
public new void print()
{
Console.WriteLine("Child Class Print Method");
}
} public class program
{
public static void Main()
{
BaseClass B = new DerivedClass();
B.print()
}
}
