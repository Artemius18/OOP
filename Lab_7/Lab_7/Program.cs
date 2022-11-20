using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7
{
    interface IFunction<T>
    {
        void Add(T element);
        void Remove(int pos);
        void Show();
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
