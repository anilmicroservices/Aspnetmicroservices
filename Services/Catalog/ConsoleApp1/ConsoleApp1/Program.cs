using System;

class AnagramChecker
{
    public static void Main()
    {
        List<test> list = new List<test> {
            new test { Id= 8, name = "A" }, 
            new test { Id= 2, name= "B" },
            new test { Id= 4, name= "B" },
        };
        int res = list.Where(m=>m.name=="B").Sum(s => s.Id);
        Console.WriteLine("Sum = {0}", res);
        Console.ReadLine();
    }
}
public class test
{
    public int Id;
    public string name;
}
