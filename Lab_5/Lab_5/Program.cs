using System;
using System.Linq;


namespace Lab06
{
    // Квитанция, Накладная, Документ, Чек, Дата, Организация.
    //Собрать Бухгалтерию.
    //Найти суммарную стоимость продукции заданного наименования по всем накладным, количество чеков. Вывести две документы за указанный период времени.
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client("Каролина", "Мергель");

            Waybill waybill = new Waybill("Накладная на машину", new DateTime(2012, 05, 12), client, new Organization("Пока не придумала"), 7800);
            Receipt receipt = new Receipt("Квитанция об оплате", new DateTime(2020, 05, 12), client, new Organization("Netflix"), 49);
            Check check = new Check("Чек", new DateTime(2020, 10, 15), client, new Organization("McDonalds"), 5);

           
        }
    }
}