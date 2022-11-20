using System;
using System.Collections.Generic;
using System.IO;


namespace Lab_7
{
    interface IFunction<T>
    {
        void Add(T element);
        void Remove(int pos);
        void Show();
    }

    public class CollectionType<T> : IFunction<T>
    {
        public T element;
        public List<T> collection;
        public CollectionType()
        {
            collection = new List<T>();
            element = default(T);
        }
        public CollectionType(T el)
        {
            collection = new List<T>();
            element = el;
        }
        public void Add(T el)
        {
            if (el.Equals(0))
            {
                throw new Exception("You cannot add element with a value of 0");
            }
            collection.Add(el);
        }
        public void Show()
        {
            if (collection.Count == 0)
            {
                throw new Exception("Empty collection");
            }
            for (int i = 0; i < collection.Count; i++)
            {
                Console.WriteLine((i + 1) + " element of list: " + collection[i]);
            }
        }
        public void Remove(int pos)
        {
            collection.RemoveAt(pos);
        }
        

    }
    public class Document
    {
        private readonly int id;
        private string title;
        private DateTime dateOfSignature; //дата подписи
        private string client;
        private string organization;
        private int price;
        public Document(string title, DateTime dateOfSignature, string client, string organization, int price)
        {
            id = (int)title.GetHashCode() + (int)dateOfSignature.GetHashCode();
            this.title = title;
            this.dateOfSignature = dateOfSignature;
            this.client = client;
            this.organization = organization;
            this.price = price;
        }
        public string Client
        {
            get => client;
            set => client = value;

        }

        public string Organization
        {
            get => organization;
            set => organization = value;
        }
        public string Title
        {
            get => title;
            set => title = value;
        }
        public DateTime DateOfSignature
        {
            get => dateOfSignature;
            set => dateOfSignature = value;
        }
        public override string ToString()
        {
            return "-------------------------------------------------------\nTitle: " + Title + "\nDateOfSignature: " + DateOfSignature.ToString("MM/dd/yyyy") + "\nClient:  " + Client + "\nOrganization: " + organization + "\n-------------------------------------------------------\n";

        }
    }
    class Program
    {
        static void Main(string[] args)
        {


            try
            {
                string path = @"D:\BSTU\2course\OOP\Lab_7\Lab_7\test.txt";
            
                CollectionType<int> list = new CollectionType<int>();
                CollectionType<short> list1 = new CollectionType<short>(2);
                CollectionType<Document> tom = new CollectionType<Document>();

                Document a = new Document("Накладная на машину", new DateTime(2012, 05, 12), "Каролина Мергель", "Пока не придумала", 7800);
                Document b = new Document("Квитанция об оплате", new DateTime(2020, 05, 12), "Каролина Мергель", "Netflix", 49);
                Document c = new Document("Check", new DateTime(2020 / 10 / 10), "Каролина Мергель", "В мире пультов", 20);
                tom.Add(a);
                tom.Add(b);
                tom.Add(c);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                Console.WriteLine("Yaaay");
                Console.ReadKey();
            }

        }
    }
}
