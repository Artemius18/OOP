using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{ 


    public class Program
    {
        static void Main(string[] args)
        {
            List a = new List();
            List b = new List();

            a = 3 + a;
            a = 4 + a; //добавление в начало
            a = 6 + a;
            a = 3 + a;

            b = 3 + b;
            b = 4 + b;
            b = 6 + b;
            b = 3 + b;


            bool res = a == b;
            Console.WriteLine("Проверка на равенство: " + res); 

            var test = a * b; //объединение двух списков

            Console.WriteLine("Проверка на повторяющиеся элементы: " + a.DuplicateCheck());

            string[] strArr = { "Danila", "Nikita", "artyom" };
            //int res1 = strArr.Letters();
            Console.WriteLine("Кол-во слов с заглавной буквы: " + strArr.Letters());

            --a; // удаление первого эл-а из списка


            Console.WriteLine("Количество элементов: " + test.GetElementsAmount());
            Console.WriteLine("Разница между максимальным и минимальным: " + test.GetDifferenceFirstLastElement());
            Console.WriteLine("Cумма максимального и минимального: " + test.GetSumFirstLastElement());

            List.Developer developer = new List.Developer();
            Console.WriteLine(developer);

        }
    }

    public class Production
    {
        public Production(string Name)
        {
            this.ID = this.GetHashCode();
            this.organizationName = Name;
        }
        int ID = 100;
        string organizationName;
    }
}

