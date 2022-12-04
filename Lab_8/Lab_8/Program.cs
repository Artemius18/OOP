using System;


namespace Lab_9
{
    class Program
    {
        public delegate void Del();

        static void Main(string[] args)
        {
            Del del = null;
            del();
            void Hello() => Console.WriteLine("Hello");
        }
       


    }

}
