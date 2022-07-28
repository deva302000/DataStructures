using System;
using System.Collections;
namespace ArrayListManipulation;
class Program 
{
    public static void Main(string[] args)
    {
        ArrayList value=new ArrayList();
        value.Add(11);
        value.Add("Ravi");
        value.Add('A');
        value.Add(103.333);
        value.Add(11);

        foreach(object i in value)
        {
            Console.WriteLine(i);
        }
        value.Insert(2,444);
        Console.WriteLine("After Insert");
        foreach(object i in value)
        {
            Console.WriteLine(i);
        }
        value.Remove(2);
        Console.WriteLine("After remove");
        foreach(object i in value)
        {
            Console.WriteLine(i);
        }
    }
}