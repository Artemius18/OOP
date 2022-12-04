using Lab_8;
using Lab09;
using System;


namespace Lab_9
{
    class Program
    {
       
        static void Main(string[] args)
        {

            
            List<string> FirstList = new List<string>() { "какой-то", "набор", "слов", "без", "смысла" };
            Programmer programmer = new Programmer(FirstList);

            List<string> SecList = new List<string>() { "второй", "набор", "слов", "без", "смысла" };
            Programmer prmmer = new Programmer(SecList);


            programmer.Show();

            programmer.DeleteEvent += (string message) => Console.WriteLine(message);

            programmer.MutateEvent += (string message) => Console.WriteLine(message);


            programmer.Delete();
            programmer.Show();

            programmer.Mutate();
            programmer.Show();

            programmer.Mutate();
            programmer.Show();

            Console.WriteLine("\n---------------------------------------\n");

            string str = "Работа со строками, и как бы да, но нет, когда всегда...";

            Console.WriteLine("\nИсходная строка: " + str);
            Func<string, string> A = null;

            A = StringRe.Remove;
            Console.WriteLine("\nБез знаков препинания: {0}", A(str));

            A = StringRe.AddToString;
            Console.WriteLine("\nДобавление строки: {0}", A(str));

            A = StringRe.ToUpper;
            Console.WriteLine("\nЗаглавные буквы: {0}", str = A(str));

            A = StringRe.ToLower;
            Console.WriteLine("\nПрописные: {0}", A(str));

            A = StringRe.RemoveSpace;
            Console.WriteLine("\nБез пробелов: {0}", A(str));

            

            //Predicate
            Predicate<string> test = (string someStr) => someStr.Length > 0;

            Console.WriteLine(test(str));
          
            Console.ReadKey();
        }
            delegate bool Predicate<in T>(T obj);


    }

}
