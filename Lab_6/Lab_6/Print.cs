using System;

namespace Lab_6
{
    public static class Printer
    {
        public static void IAmPrinting(Document document)
        {
            Console.WriteLine("--------------------------------------\n" + document.GetType());
            Console.WriteLine(document.ToString());
        }
    }
}