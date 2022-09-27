using System;
using System.Text;


namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //задание 1
            //a
            bool b1 = true;
            byte by1 = 18;//от 0 до 255, 1 байт
            sbyte sb1 = -20; //-128 до 127, 1 байт
            short sh1 = -1; //-32768 до 32767, 2 байт
            ushort height = 190;//0 до 65535, 2 байт
            int i1 = 50;//4 байт
            uint i2 = 10U;
            char letter = 'a';
            long l1 = -100L;//8
            ulong l2 = 100UL;
            float f = -3.49f;//4 байта
            double d1 = -5.45;//8
            decimal dec1 = 4.23455645M;//16
            string str = "guitar";
            object obj = 22;//4 для 32-платформы. 8 для 64


            Console.WriteLine($"bool = {b1}, byte = {by1}, sbyte = {sb1}, short = {sh1}, ushort = {height}\nint = {i1}" +
                $"uint = {i2}, char = {letter}, long = {l1}, ulong = {l2}, float = {f}\n" +
                $"double = {d1}, decimal = {dec1}, string = {str}, object = {obj}\n");

            Console.Write("Вы любите играть на гитаре?\n");
            string answer = Console.ReadLine();
            Console.WriteLine($"Ваш ответ: {answer}\n");

            //b 
            //явное приведение
            double DoubleNum = 1.23;
            int DoubleToIntNum = (int)DoubleNum;

            int n = Convert.ToInt32("23");

            bool b = true;
            double d = Convert.ToDouble(b);

            string str2 = "H";
            char ch2 = Convert.ToChar(str2);

            byte bit3 = 100;
            int i5 = Convert.ToInt32(bit3);

            //неявное
            short sh = 10;
            int i4 = 5 + sh;

            int num = 2147483647;
            long bigNum = num;

            long l3 = 40000L;
            float f2 = l3;


            //с
            //упаковка и распаковка
            int i6 = 123;
            object o = i6; //выполнена операция i6 упаковки целочисленной переменной, которая присвоена объекту o
            int i7 = (int)o; // распаковка объекта o

            //d
            //работа с неявно типизированнной переменной
            var v1 = 2;

            //e
            int? x = null; //упрощенная форма использования структуры System.Nullable<T>

            ////f
            //var t = "Hello world!"; 
            // t = 4.5; //сохраняется строгая типизация, поэтому мы не можем изменить тип данных



            //2 задание 
            //a) сравнение

            string str5 = "Hello";
            string str6 = " world";

            Console.WriteLine();
            int result = string.Compare(str5, str6); //сравнение по алфавиту
            if (result < 0)
            {
                Console.WriteLine($"Строка {str5} перед строкой {str6}");
            }
            else if (result > 0)
            {
                Console.WriteLine($"Строка {str5} стоит после строки {str6}");
            }
            else
            {
                Console.WriteLine($"Строки {str5} и {str6} идентичны");
            }

            // 2b

            string phrase = str5 + str6;  //конкантенация          
            Console.WriteLine($"Конкантенация строк: {phrase}");

            string copy = phrase; //копирование
            Console.WriteLine($"Копирование: {copy}");

            phrase = phrase.Substring(0, 6); //подстрока
            Console.WriteLine($"Выделение подстроки: {phrase}\n");

            string text = "Я люблю играть на гитаре"; //разделение
            string[] words = text.Split(new char[] { ' ' });
            foreach (string s in words)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("\n");


            string msg = "Хороший день"; //вставка подстрок
            string substring = "замечательный ";

            msg = msg.Insert(8, substring);
            Console.WriteLine(msg);

            string txtday = "Хороший день"; //удаление            
            int ind = txtday.Length - 4;
            txtday = txtday.Remove(ind);
            Console.WriteLine(txtday);

            string name = "Артем"; //интерполяция
            int age = 18;
            Console.WriteLine($"Имя: {name}  Возраст: {age}");

            // 2c
            string Empty = "";
            string Null = null;

            if (String.IsNullOrWhiteSpace(Empty) || String.IsNullOrEmpty(Null))
            {
                Console.WriteLine("\nОбе строки равны null или пустые!");
            }
            else
            {
                Console.WriteLine("\nОдна из строк не null или не пустая!");
            }

            // 2d
            StringBuilder Quote = new StringBuilder(" - это просто музыка "); // создал строку
            Quote.Insert(0, "Рок"); // вставка в начало 
            Quote.Remove(9, 15); //удаление "просто музыка"
            Quote.Append(" состояние души"); //вставка в конце 
            Console.WriteLine("\n" + Quote + "\n");


            //Задание 3
            //a
            Console.WriteLine("Двумерный массив: ");
            int[,] numbers = { { 1, 2, 3 }, { 4, 5, 6 } };
            int rows = numbers.GetUpperBound(0) + 1;    // количество строк
            int columns = numbers.Length / rows;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{numbers[i, j]} \t");
                }
                Console.WriteLine();
            }


            //b
            Console.WriteLine("\nМассив строк: ");
            string[] arr_string = { "hello", ",", "world", "!!!" };
            for (int i = 0; i < arr_string.Length; i++)
            {
                Console.Write($"{arr_string[i]} ");
            }
            Console.WriteLine($"\nРазмер массива строк: {arr_string.Length}");

            Console.Write($"Введите позицию в массиве, которую хотите заменить ");
            int l = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Введите значение, на которое хотите заменить ");
            string str_copy = Console.ReadLine();
            arr_string[l] = str_copy;

            Console.WriteLine("\nНовый массив строк: ");
            for (int i = 0; i < arr_string.Length; i++)
            {
                Console.Write($"{arr_string[i]} ");
            }

            //c
            //с
            Console.WriteLine();
            Console.WriteLine($"\nСтупенчатый массив");
            int q = 0;
            // Объявляем ступенчатый массив
            int[][] myArr = new int[4][];
            myArr[0] = new int[4];
            myArr[1] = new int[6];
            myArr[2] = new int[3];
            myArr[3] = new int[4];

            // Инициализируем ступенчатый массив
            for (; q < 4; q++)
            {
                myArr[0][q] = q;
                Console.Write("{0}\t", myArr[0][q]);
            }

            Console.WriteLine();
            for (q = 0; q < 6; q++)
            {
                myArr[1][q] = q;
                Console.Write("{0}\t", myArr[1][q]);
            }

            Console.WriteLine();
            for (q = 0; q < 3; q++)
            {
                myArr[2][q] = q;
                Console.Write("{0}\t", myArr[2][q]);
            }

            Console.WriteLine();
            for (q = 0; q < 4; q++)
            {
                myArr[3][q] = q;
                Console.Write("{0}\t", myArr[3][q]);
            }

            //d
            var vals = new[] { 1, 2, 3, 4, 5 };
            var vals2 = "String";

            //Задание 4
            //a
            (int, string, char, string, ulong) information = (18, "Artyom", ' ', "Minsk", 190UL);

            //b
            Console.WriteLine($"\n\nКортеж: { information.Item1}, {information.Item2}, {information.Item3}, {information.Item4}, {information.Item5}");
            Console.WriteLine($"\n\nКортеж: { information.Item2}, {information.Item3}, {information.Item5}");

            //c
            (var a, var o6) = ("123", 456);
            Console.WriteLine($"{a} {o6}");

            //d
            var First = (a: 10, b: "20");
            var Second = (a: 10, b: "20");
            if (First == Second)
            {
                Console.WriteLine("\nКортежи равны");
            }
            else
            {
                Console.WriteLine("\nКортежи не равны");
            }


            //Задание 5
            (int, int, int, char) tupleFunc(int[] arr, string str9)
            {
                int min, max, sum = 0;
                min = arr[0];
                max = arr[0];
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] < min)
                    {
                        min = arr[j];
                    }
                    else if (arr[j] > max)
                    {
                        max = arr[j];
                    }
                    sum += arr[j];
                }
                return (min, max, sum, str9[0]);
            }
            int[] exampleArr = new int[5] { 27, 50, 22, 100, 3 };
            string exampleString = "Guitar";
            (int, int, int, char) exampleTuple = tupleFunc(exampleArr, exampleString);
            Console.WriteLine("Работа функции: " + exampleTuple.Item1 + " " + exampleTuple.Item2 + " " + exampleTuple.Item3 + " " + exampleTuple.Item4);

            //Задание 6
            void FirstFunc()
            {
                try
                {
                    checked
                    {
                        int h = int.MaxValue;
                        h++;
                    }
                }
                catch (OverflowException e)
                {
                    Console.WriteLine(e);
                }
            }

            void SecondFunc()
            {
                try
                {
                    unchecked // Не вызывает OverflowException
                    {
                        int s = int.MaxValue;
                        s++;
                    }
                }
                catch (OverflowException)
                {
                    Console.WriteLine("2) Произошло переполнение!");
                }
            }

            FirstFunc();
            SecondFunc();

        }
    }
}
