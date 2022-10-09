using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{ //добавить вложенный объект Production, вложенный класс Developer (разработчик – фио, id, отдел)
    public static class StatisticOperation
    {
        public static int GetSumFirstLastElement(Program.List first)
        {
            return first.items.Max() + first.items.Min();
        }

        public static int GetDifferenceFirstLastElement(Program.List first)
        {
            return first.items.Max() - first.items.Min();
        }

        public static int GetAlementsAmount(Program.List first)
        {
            return first.items.Length;
        }

        public static bool DuplicateCheck(this Program.List first)
        {
            for (int i = 0; i < first.items.Length; i++)
            {
                for (int j = 0; j < first.items.Length; j++)
                {
                    if (i == j) continue;

                    if (first.items[i] == first.items[j]) return true;
                }
            }

            return false;
        }

        public static int Letters(this string[] first)
        {
            int count = 0;
            for (int i = 0; i < first.Length; i++)
            {
                char str = first[i][0];
                if ((str >= 'A' && str <= 'Z') || (str >= 'А' && str <= 'Я'))
                    count++;
            }
            return count;
        }
    }

    public class Program
    {
        public class List
        {
            public static List operator *(List first, List second)
            {
                List temp = new List();

                temp.items = new int[first.items.Length + second.items.Length];

                for (int i = 0; i < first.items.Length; i++)
                {
                    temp.items[i] = first.items[i];
                }

                for (int i = first.items.Length, j = 0; j < second.items.Length; i++, j++)
                {
                    temp.items[i] = second.items[j];
                }

                return temp;
            }

            public static bool operator !=(List first, List second)
            {
                if (first.items.Length != second.items.Length) return true;

                for (int i = 0; i < first.items.Length; i++)
                {
                    if(first.items[i] != second.items[i])
                    {
                        return true;
                    }
                }

                return false;
            }

            public static bool operator ==(List first, List second)
            {
                return !(first != second);
            }

            public static List operator --(List list)
            {
                int[] temp = new int[list.items.Length - 1];

                for (int i = 1, j = 0; j < list.items.Length-1; i++, j++)
                {
                    temp[j] = list.items[i];
                }

                list.items = temp;

                return list;
            }
            public static List operator +(int item, List list)
            {
                if(list.items == null)
                {
                    list.items = new int[1] { item };
                    return list;
                }

                int[] temp = new int[list.items.Length + 1];

                temp[0] = item;

                for (int i = 1, j = 0; j < list.items.Length; i++, j++)
                {
                    temp[i] = list.items[j];
                }

                list.items = temp;

                return list;
            }

            public int[] items = null;
        }

        static void Main(string[] args)
        {
            List a = new List();
            List b = new List();

            a = 3 + a;
            a = 4 + a;
            a = 6 + a;
            a = 3 + a;

            b = 3 + b;
            b = 4 + b;
            b = 6 + b;
            b = -1 + b;

            bool res = a == b;

            var test = a * b;

            a.DuplicateCheck();

            string[] strArr = { "danila", "nikita", "artyom" };

            int res1 = strArr.Letters();

            --a;

            

        }
    }
}
