using System;


namespace Lab_5
{
    public abstract partial class Document
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
    
}