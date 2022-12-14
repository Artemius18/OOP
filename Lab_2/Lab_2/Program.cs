using System;


class Lab_2
{
    public partial class Product
    {

        //Для лабораторной 11
        public void MethFor11Lab(int a, int b) 
        {
            Console.WriteLine(a + b);
        }
        //const
        private const int Constantine = 1;
        
        //Constructors
        public Product(string name, int UPC, string producer, int price, int storTime, int amount)
        {
            this.name = Check_str(ref name);
            this.UPC = UPC;
            this.producer = Check_str(ref producer);
            this.price = price;
            this.storTime = storTime;
            this.amount = amount;

            this.id = GetHashCode();
            ++countOfUsers;
        }
        public Product()
        {
            this.name = "";
            this.UPC = 0;
            this.producer = "";
            this.price = 0;
            this.storTime = 0;
            this.amount = 0;

            this.id = GetHashCode();
            ++countOfUsers;
        }
        public Product(string name, string producer = "BSTU", int price = 50, int storTime = 100, int amount = 10)
        {
            this.name = name;
            this.producer = producer;
            this.price = price;
            this.storTime = storTime;
            this.amount = amount;

            this.id = GetHashCode();
            ++countOfUsers;
        }

        //Static_Constructor
        static Product()
        {
            countOfUsers = 0;
        }
        
        //Private constructor + ref && out
        private Product(ref int a, out int b)
        {
            ++a;
            b = a;
        }
        public void TestPrivateProduct()
        {
            int c = 1;
            int d = 2;

            Product test = new Product(ref c, out d);
        }

        //Overrides
        public override int GetHashCode()
        {
            return (int)(this.UPC - 456 * 10 / 20 + 9786 - 3);
        }
        public override string ToString()
        {
            return "Name " + this.name + ", " + "UPC " + this.UPC + ", " + "Producer " + this.producer + ", " + "Price " + this.price + ", " + "StorTime " + this.storTime + ", " + "Amount " + this.amount;
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (obj.GetType() != this.GetType()) return false;
            Product test_equals = (Product)obj;
            return (this.id == test_equals.id);
        }

        //Static inf
        public static void GetInf(Product temp)
        {
            Console.Write("Name " + temp.name + ", " + "UPC " + temp.UPC + ", " + "Producer " + temp.producer + ", " + "Price " + temp.price + ", " + "StorTime " + temp.storTime + ", " + "Amount " + temp.amount);
        } //статический  метод вывода информации о классе


        //Get_Set
        public string GetSetname
        {
            get { return name; }
            set { this.name = Check_str(ref value); }
        }

        public int GetSetUPC
        {
            get { return UPC; }
            set { this.UPC = value; }
        }

        public string GetSetproducer
        {
            get { return producer; }
            set { this.producer = value; }
        }

        public int GetSetprice
        {
            get { return price; }
            set { this.price = value; }
        }

        public int GetSetstorTime
        {
            get { return storTime; }
            set { this.storTime = value; }
        }

        public int GetSetamount
        {
            get { return amount; }
            set { this.amount = value; }
        }

        ///////////////////////////Общая сумма продуктов//////////////////////////////////
        ///

        public int GetSumProducts()
        {
            return this.amount * this.price;
        }

        /////////////////////////////Проверка на цифры////////////////////////////////////////////
        ///

        private string Check_str(ref string str)
        {
            foreach (char symbol in str)
            {
                if (48 < symbol && symbol < 57) return "";
            }

            return str;
        }
    }

    ////////////////////////////////Переменные////////////////////////////////////////////
    public partial class Product
    {
        private readonly int id;
        private string name;
        private int UPC;
        private string producer;
        private int price;
        private int storTime;
        private int amount;

        static int countOfUsers;

    }

    static void Main()
    {
        //Test Constructors
        Product first = new Product("Milk", 123456, "BSTU", 100, 5, 10);
        Product second = new Product();
        Product third = new Product("artem");



        //Test private Constructors
        first.TestPrivateProduct();

        //Test override
        first.Equals(second);

        //Test Get Set
        first.GetSetname = "nikita";

        //Test static method
        Product.GetInf(first);

        ////////////////////////////////Задания////////////////////////////////////////////
        ///
        int count = 3;
        Product[] ProductArr = new Product[count];
        ProductArr[0] = new Product("Milk", 123456, "BSTU", 100, 5, 10); //массив объектов 
        ProductArr[1] = new Product("Milk", 567890, "BMZ", 200, 6, 11);
        ProductArr[2] = new Product("honey", 456789, "Lepel", 50, 4, 5);

        string userStr = "Milk";

        for (int i = 0; i < count; i++)
        {
            if (ProductArr[i].GetSetname == userStr) Console.Write($"{ProductArr[i].ToString()}\n"); //список товаров для заданного наименования
        }
        ////////////////////////////////////////////////////////////////////////////
        Console.Write("\n\n");

        int userPrice = 100;

        for (int i = 0; i < count; i++) //список товаров для заданного наименования, цена которых не превосходит заданную

        {
            if (ProductArr[i].GetSetprice <= userPrice) Console.Write($"{ProductArr[i].ToString()}\n");
        }
        Console.Write("\n");


        var type = new { name = "Artyom" }; // Создайте и выведите анонимный тип
        Console.Write(type);
        Console.Write("\n");
        Console.Write(type.GetType());
        Console.Write("\n");
    }

}