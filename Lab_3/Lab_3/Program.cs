using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Program
    {
        class List
        {
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

            a = 3 + a;
            a = 4 + a;
            a = 6 + a;
            a = -1 + a;

            --a;
        }
    }
}
