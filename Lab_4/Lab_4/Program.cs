﻿using System;


namespace Lab_04
{
    // Квитанция, Накладная, Документ, Чек, Дата, Организация.
    class Program
    {
        static void Main(string[] args)
        {
            Client first_client = new Client("Пшенко", " Артем");

            Waybill first_waybill = new Waybill("Накладная на машину", new DateTime(2022, 10, 10), first_client, new Organization("BMW"), 7800);
            Receipt first_receipt = new Receipt("Квитанция об оплате", new DateTime(2022, 10, 10), first_client, new Organization("Netflix"), 49);
            Check first_check = new Check("Чек", new DateTime(2022, 10, 10), first_client, new Organization("McDonalds"), 5);
            first_waybill.Info();

            Console.WriteLine();

        }
    }
}