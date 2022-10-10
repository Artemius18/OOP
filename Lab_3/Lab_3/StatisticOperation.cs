using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    public static class StatisticOperation
    {
        public static int GetSumFirstLastElement(this List first)
        {
            return first.items.Max() + first.items.Min();
        }

        public static int GetDifferenceFirstLastElement(this List first)
        {
            return first.items.Max() - first.items.Min();
        }

        public static int GetElementsAmount(this List first)
        {
            return first.items.Length;
        }

        public static bool DuplicateCheck(this List first)
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
}
