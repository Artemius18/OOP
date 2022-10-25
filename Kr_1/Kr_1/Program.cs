using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kr_1
{
    

 interface IA
        { void method();
    
    class B : IA
    {
        void IA.method();
        {System.Console.WriteLine("OK"};
    }
class Program1

{

    static void Main(string[] args)
    {
        B a = new B();
        a.method();

        Console.ReadKey();
    }
}




//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Вариант_6
//{

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //Task 1
//            Console.WriteLine(ushort.MaxValue); // A) usort max

//            string[] week = new string[7] { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" }; //B) week days
//            for (int i = 0; i < week.Length; ++i)
//            {
//                Console.WriteLine(week[i]);
//            }
//            Console.WriteLine("\n");

//            Card cards = new Card();
//            Console.WriteLine(cards.balance += 12);
//            Console.WriteLine(cards.balance -= 5);

//            ClassWithHistory classWithHistory = new ClassWithHistory();

//            classWithHistory.History(classWithHistory);

//        }
//    }


//    public interface ICheck //интерфейс
//    {
//        bool Check();
//    }

//     public class Card : ICheck
//    {
//        public int number { get; }
//        public int mounth
//        {
//            get
//            {
//                return mounth; //только для чтения
//            }
//            set
//            {
//                if (value > 12 || value < 1)
//                {
//                    throw new Exception("Ошибка"); 
//                }
//                else mounth = value;
//            }
//        }
//        public int year { get; set; } //автоматическое
//        public int balance;

//        public static Card operator +(Card card, int sum) //пополнение суммы
//        {

//            card.balance += sum;
//            return card;
//        }

//        public static Card operator -(Card card, int sum) //снятие суммы
//        {
//            card.balance -= sum;
//            return card;
//        }

//        bool ICheck.Check() //интерфейс 
//        {
//            if (balance > 0) return true;
//            else return false;
//        }
//    }

//    class ClassWithHistory : Card
//    {
//        public string[] CardHistory = new string[0];

//        public static ClassWithHistory operator +(ClassWithHistory card, int sum)
//        {
//            card.CardHistory[card.CardHistory.Length] = $"+ {sum}";
//            card.balance += sum;
//            return card;
//        }

//        public static ClassWithHistory operator -(ClassWithHistory card, int sum)
//        {
//            card.CardHistory[card.CardHistory.Length] = $"- {sum}";
//            card.balance -= sum;
//            return card;
//        }

//        public void History(ClassWithHistory card)
//        {
//            foreach (string item in card.CardHistory)
//            {
//                Console.WriteLine(item);
//            }
//        }

//    }

// }




