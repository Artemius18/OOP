using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    internal class Programmer
    {
        public delegate void List(string message);
        public event List DeleteEvent;
        public event List MutateEvent;
        public List<string> list;


        public Programmer(List<string> list)
        {
            this.list = list;
        }
        public void Delete()
        {
            list.RemoveAt(0);
            DeleteEvent?.Invoke("Произошло удаление первого элемента");
        }

        public void Mutate()
        {
            Random rand = new Random(); 
            list = list.OrderBy(x => rand.Next()).ToList();
            MutateEvent?.Invoke("Произошло мутирование...");

        }
        public void Show()
        {
            foreach (string str in list)
            {
                Console.Write(str + " ");
            }
            Console.WriteLine();
        }
    }
}
