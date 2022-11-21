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

    public class CollectionType<T> : IFunction<T> //where T : Document
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


        public void ToFile(string path)
        {
            string[] text = new string[collection.Count];
            for (int i = 0; i < collection.Count; i++)
            {
                text[i] = collection[i].ToString();
            }
            File.WriteAllLines(path, text);
            Console.WriteLine("Data has been saved to txt file");
        }

        public void FromFile(string path)
        {
            Console.WriteLine(File.ReadAllText(path));
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
                string path = @"D:\BSTU\2course\1term\OOP\Lab_7\Lab_7\save.txt";
            
                CollectionType<int> list = new CollectionType<int>();
                CollectionType<short> list1 = new CollectionType<short>(2);
                CollectionType<Document> artyom = new CollectionType<Document>();

                Document a = new Document("Накладная на машину", new DateTime(2012, 05, 12), "Пшенко Артем", "Какая-то организация", 7800);
                Document b = new Document("Квитанция об оплате", new DateTime(2020, 05, 12), "Пшенко Артем", "Netflix", 49);
                Document c = new Document("Check", new DateTime(2020 / 10 / 10), "Пшенко Артем", "В мире пультов", 20);
                artyom.Add(a);
                artyom.Add(b);
                artyom.Add(c);

                artyom.ToFile(path);
                //artyom.FromFile(path);

                artyom.Show();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                Console.WriteLine(":)");
                Console.ReadKey();
            }

        }
    }
}
