using System;


namespace Lab_6
{
    // Квитанция, Накладная, Документ, Чек, Дата, Организация.
    //Собрать Бухгалтерию.
    //Найти суммарную стоимость продукции заданного наименования по всем накладным, количество чеков. Вывести две документы за указанный период времени.
    class Program
    {
        static void Main(string[] args)
        {
            try 
            { 
                try
                {
                    //var a = 0;
                    //a = 2 / a;
                    Client client = new Client("Артем", "Пшенко");
                    Organization org = new Organization("Какая-то организация");
                    Organization org_exc = new Organization("");
                    Organization org_e = new Organization("12345678901234567890123457890");
                    Waybill waybill = new Waybill("Накладная на машину", new DateTime(2012, 05, 12), client, new Organization("Какая-то организация"), 7800);
                    Receipt receipt = new Receipt("Квитанция об оплате", new DateTime(2020, 05, 12), client, new Organization("Netflix"), 49);
                    Receipt receipt2 = new Receipt("Квитанция об оплате", new DateTime(2020, 05, 12), client, new Organization("Netflix"), 49);
                    Check check = new Check("Чек", new DateTime(2020, 10, 15), client, new Organization("McDonalds"), 5);

                    Waybill waybill2 = new Waybill("Накладная на машину", new DateTime(2012, 05, 12), client, org, 7800);
                    Waybill waybill3 = new Waybill("Накладная на машину", new DateTime(2012, 05, 12), client, org, 7800);
                    Waybill waybill4 = new Waybill("Накладная на машину", new DateTime(2012, 05, 12), client, new Organization("Какая-то организация"), 7800);
                    Waybill waybill5 = new Waybill("Накладная на машину", new DateTime(2012, 05, 12), client, new Organization("Какая-то организация"), 7800);


                    Bookkeeping bkkeeping = new Bookkeeping();
                    BookkeepingController controll = new BookkeepingController();
                    bkkeeping.AddReceipt(receipt);
                    bkkeeping.AddReceipt(receipt2);
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

                    bkkeeping.GetDocuments(new DateTime(2020, 01, 01), new DateTime(2021, 01, 01));
                    Console.WriteLine();
                    Console.WriteLine("Количество чеков: {0}", controll.Count(bkkeeping));



                }
                catch (EmptyException e)
                {
                    Console.WriteLine(e);
                    throw;

                }
                
                catch (LongException e)
                {
                    Console.WriteLine(e);
                    throw;

                }
                catch (PriceException e)
                {
                    Console.WriteLine(e);
                    throw;
                }
                catch (IndexException e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }

            catch (EmptyException e)
            {
                Console.WriteLine(e);

                Console.WriteLine();

                Console.WriteLine(e.TargetSite);

                Console.WriteLine();

                Console.WriteLine(e.StackTrace);

            }
            catch (LongException e)
            {
                Console.WriteLine(e);

            }
            catch (PriceException e)
            {
                Console.WriteLine(e);
            }
            catch (IndexException e)
            {
                Console.WriteLine(e);

            }
            catch
            {
                Console.WriteLine("Универсальный обработчик");

            }

            finally
            {
                Console.WriteLine("\n--------------------finally-------------------- \n:)");
            }
            Console.ReadKey();


        }
    }

    class Gen<T, G>
    {
        G ob;
        T bo;
        public Gen(G o) { ob = (int)0; }
        public T GetOb() { return bo; }
    }
}