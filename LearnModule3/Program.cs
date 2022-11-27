using System;

class MainClass
{
    public static void Main(string[] args)
    {
        //const string MyName = "Maks";

        //Console.WriteLine(MyName);

        //Console.WriteLine("\t Привет Мир");
        //Console.WriteLine("\t Мне 27 лет");
        //Console.WriteLine("\t My name is \n {0}", MyName);
        //Console.WriteLine("\u0040");
        //Console.WriteLine("\u0023");
        //Console.ReadKey();

        var num = 1;
        AddTen(ref num);
        Console.WriteLine(num);

    }

    static void AddTen(ref int num) 
    {
        num = num + 10;
    }
}
