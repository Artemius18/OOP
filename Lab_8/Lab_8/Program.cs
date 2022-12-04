using System;

class Program
{
    static void Main(string[] args)
    {
        Test? test = Hello;

        test();
        void Hello() => Console.WriteLine("Hello");
    }

    delegate void Test();
}
