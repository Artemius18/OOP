using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;


namespace Lab_9
{
    public class Game<T> : IEnumerable<T> //where T : Player
    {
        public BlockingCollection<T> players = new BlockingCollection<T>();


        public Dictionary<int, T> dict = new Dictionary<int, T>();

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        IEnumerator<T> GetEnumerator()
        {
            foreach (T foo in players)
            {
                yield return foo;
                
            }
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return ((IEnumerable<T>)players).GetEnumerator();
        }

        public void Show()
        {
            foreach (var item in players)
            {
                Console.WriteLine(item);
            }
        }
        public void ShowDict()
        {
            foreach (KeyValuePair<int, T> element in dict)
                Console.WriteLine("Ключ: {0}\t\tЗначение: {1}", element.Key, element.Value);
        }
        public void Remove(int numb)
        {
            for (int i = 0; numb > 0; i++)
            {
                if (dict.ContainsKey(i))
                {
                    dict.Remove(i);
                    numb--;
                }
            }
        }
    }

    //Создайте класс по варианту
    public class Player
    {
        public string Name;

        public Player(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }

    class Program
    {
        //Создайте произвольный метод и зарегистрируйте его на событие CollectionChange
        public static void Ch(object sender, NotifyCollectionChangedEventArgs e)
        {
            Console.WriteLine("Collection changed with action " + e.Action);
        }

        static void Main(string[] args)
        {
            //--1--Game
            Player frst = new Player("First");
            Player scnd = new Player("Second");
            Player thrd = new Player("Third");
            Player frth = new Player("Fourth");
            Player ffth = new Player("Fifth");


            //соберите объекты класса в коллекцию
            Game<Player> idkgame = new Game<Player>();
            idkgame.players.Add(frst);
            idkgame.players.Add(scnd);
            idkgame.players.Add(thrd);

            //продемонстрируйте работу с ней 
            //Вывод
            idkgame.Show();
            //Добавление
            Console.WriteLine("Attempt to add: " + idkgame.players.TryAdd(frth)); 
            Console.WriteLine("\n------after attempt to add----");
            idkgame.Show();
            idkgame.players.CompleteAdding(); //Помечает экземпляры BlockingCollection<T> как не допускающие добавления дополнительных элементов
            //Удаление
            idkgame.players.Take(); 
            Console.WriteLine("\n---------after frst elem-------");
            idkgame.Show();
            //Поиск
            bool result = idkgame.players.Contains(scnd);
            Console.WriteLine("Is elem in collection: " + result);
            

            Console.WriteLine("\n------------------------------");


           
            

            //Создайте вторую коллекцию и заполните данными из первой
            Game<Player> NotAgame = new Game<Player>();
            NotAgame.dict.Add(1, frst);
            NotAgame.dict.Add(2, scnd);
            NotAgame.dict.Add(3, thrd);
            NotAgame.dict.Add(5, ffth);
            NotAgame.dict.Add(4, frth);


            //Выведите вторую коллекцию на консоль
            NotAgame.ShowDict();

            //Найдите во второй коллекции заданное значение
            Console.WriteLine("if contains key '2':" + NotAgame.dict.ContainsKey(2));
            Console.WriteLine("if contains key '6':" + NotAgame.dict.ContainsKey(6));



            //Создайте объект наблюдаемой коллекции ObservableCollection<T>
            ObservableCollection<int> obs = new ObservableCollection<int>();
            obs.CollectionChanged += Ch;
            obs.Add(5);
            obs.Remove(5);

            Console.ReadKey();
        }
    }
}