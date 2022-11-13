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
            Client client = new Client("Пшенко ", "Артем");

            Waybill waybill = new Waybill("Накладная на машину", new DateTime(2022, 10, 11), client, new Organization("BMW"), 7800);
            Receipt receipt = new Receipt("Квитанция об оплате", new DateTime(2022, 10, 11), client, new Organization("Netflix"), 49);

            Check check = new Check("Чек", new DateTime(2020, 10, 15), client, new Organization("McDonalds"), 5);

            Waybill waybill2 = new Waybill("Накладная на машину", new DateTime(2022, 11, 11), client, new Organization("BMW"), 7800);
            Waybill waybill3 = new Waybill("Накладная на машину", new DateTime(2022, 11, 11), client, new Organization("BMW"), 7800);
            Waybill waybill4 = new Waybill("Накладная на машину", new DateTime(2021, 12, 26), client, new Organization("BMW"), 7800);
            Waybill waybill5 = new Waybill("Накладная на машину", new DateTime(2022, 11, 11), client, new Organization("BMW"), 7800);


            Bookkeeping bkkeeping = new Bookkeeping();
           
            bkkeeping.AddReceipt(receipt);
            bkkeeping.AddWaybill(waybill);
            bkkeeping.AddCheck(check);

            bkkeeping.AddWaybill(waybill2);
            bkkeeping.AddWaybill(waybill3);
            bkkeeping.AddWaybill(waybill4);
            bkkeeping.AddWaybill(waybill5);

            bkkeeping.ShowList();
            Console.WriteLine();

            Console.WriteLine("Суммарная стоимость продукции заданного наименования по всем накладным = {0}", bkkeeping.GetWaybillPrice("Накладная на машину"));
            Console.WriteLine();

            bkkeeping.GetDocuments(new DateTime(2021, 11, 10), new DateTime(2022, 11, 10));
            Console.WriteLine();
           

            Console.ReadKey();
        }
    }
}

        