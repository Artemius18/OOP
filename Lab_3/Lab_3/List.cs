using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    public class List
    {

        Production Product = new Production("Artyom"); //вложенный объект Production, который содержит Id, название организации

        public class Developer //вложенный класс Developer (разработчик – фио, id, отдел)
        {
            private string name { get; set; }
            private string department { get; set; }
            private int id { get; set; }

            public Developer()
            {
                this.name = "Artyom";
                this.department = "BSTU";
                this.id = 2;
            }

            public override string ToString()
            {
                return $"\n---Info about developer---\nName: {this.name}\nDepartment: {this.department}\nID: {this.id}\n----------------------\n";
            }
        } 

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
                if (first.items[i] != second.items[i])
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

            for (int i = 1, j = 0; j < list.items.Length - 1; i++, j++)
            {
                temp[j] = list.items[i];
            }

            list.items = temp;

            return list;
        }
        public static List operator +(int item, List list)
        {
            if (list.items == null)
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
}
