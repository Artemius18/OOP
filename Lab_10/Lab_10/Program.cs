namespace Lab_10
{
    class Program
    {
        static void Main(string[] args)
        {

            //последовательность месяцев с длиной строки равной n
            int n = 4;
            Console.WriteLine($"Месяцы с длиной n = {n}");
            string[] Monthes = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };           
            var selectedMonthes = from m in Monthes
                                  where m.Length == n
                                  select m;
            foreach (string item in selectedMonthes) Console.WriteLine(item);
            Console.WriteLine();


            //Только летние и зимние месяцы
            Console.WriteLine("Только летние и зимние месяцы");
            Monthes = Array.ConvertAll(Monthes, d => d.ToLower());
            var wintSum = from t in Monthes
                          where t == "january" || t == "february" || t == "june" || t == "july" || t == "august" || t == "december"
                          select t;
            foreach (string item in wintSum) Console.WriteLine(item);
            Console.WriteLine();

            //В алфавитном порядке
            Console.WriteLine("В алфавитном порядке");
            var alphavite = from t in Monthes
                          orderby t
                          select t;
            foreach (string item in alphavite) Console.WriteLine(item);
            Console.WriteLine();


            Console.WriteLine("Содержат u и длина больше 4");
            var сontU = from t in Monthes
                            where t.Length>4 && t.Contains("u")   
                            select t;
            foreach (string item in сontU) Console.WriteLine(item);
            Console.WriteLine();


            List<Product> products = new List<Product>() { new Product("chocolate", 222211, "India", 5, new DateTime(2020, 5, 8), 19),
                                                           new Product("pillow", 2332211, "USA", 99, new DateTime(2019, 6, 1), 12),
                                                           new Product("rat", 111345, "Russia", 79, new DateTime(2020, 7, 16), 33),
                                                           new Product("coffee", 667721, "UK", 105, new DateTime(2019, 8, 15), 12),
                                                           new Product("tea", 2332211, "Belarus", 8, new DateTime(2018, 9, 22), 88),
                                                           new Product("table", 111223, "Belarus", 15, new DateTime(2015, 10, 18), 7),
                                                           new Product("computer", 2299922, "China", 19, new DateTime(2017, 11, 15), 38),
                                                           new Product("cup", 2111122, "Turkmenistan", 159, new DateTime(2018, 1, 30), 16),
                                                           new Product("phone", 22, "China", 9, new DateTime(2017, 2, 18), 7),
                                                           new Product("glass", 3232322, "Belarus", 4, new DateTime(2018, 6, 18), 10) };

            //список товаров для заданного наименования
            Console.WriteLine("Список товаров для заданного наименования: ");
            string name = "Belarus";
            var list1 = from prod in products 
                        where prod.Manufacturer == name 
                        select prod;
            foreach (var prod in list1) prod.Info();
            Console.WriteLine();


            //список товаров для заданного наименования, цена которых не превосходит заданную
            Console.WriteLine("Список товаров для заданного наименования, цена которых не превосходит заданную: ");
            string name2 = "Belarus";
            var list2 = from prod in products
                        where prod.Manufacturer == name2 && prod.Price<10
                        select prod;
            foreach (var prod in list2) prod.Info();
            Console.WriteLine();

            //Количество наименований цена которых больше 100
            Console.WriteLine("Количество наименований цена которых больше 100: " + (from prod in products where prod.Price > 100 select prod).Count());
            Console.WriteLine();

            //Максимальная стоимость продукта
            Console.WriteLine($"Максимальная стоимость продукта: {(from prod in products select prod.Price).Max()}");

            //упорядоченный набор товаров по производителю, а потом по количеству.
                        var sortProd = products.OrderBy(p => p.Manufacturer).ThenBy(p => p.Price).Select(p => p);

            foreach (var prod in sortProd) Console.WriteLine(prod.Manufacturer+ " - " + prod.Name);

            Console.WriteLine("\n---------------------------------------------------\n");




            Person2[] people =
                            {
                                new Person2("Tom", "Microsoft"), new Person2("Sam", "Google"),
                                new Person2("Bob", "JetBrains"), new Person2("Mike", "Microsoft"),
                            };
            Company[] companies =
                            {
                                new Company("Microsoft", "C#"),
                                new Company("Google", "Go"),
                                new Company("Oracle", "Java")
                            };
            var employees = from p in people
                            join c in companies on p.Company equals c.Title
                            select new { Name = p.Name, Company = c.Title, Language = c.Language };

            foreach (var emp in employees)
                Console.WriteLine($"{emp.Name} - {emp.Company} ({emp.Language})");

            
    }
    }

    record class Person2(string Name, string Company);
    record class Company(string Title, string Language);
}