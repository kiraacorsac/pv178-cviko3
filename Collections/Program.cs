using System;

namespace Collections
{
    /// <summary>
    /// Ukol:
    /// 
    /// I. implementace tridy CustomerManager
    /// 
    /// II. overeni zda program po spusteni vypisuje
    /// nize uvedena testovaci data
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Test();
        }

        static void Test()
        {
            var manager = new CustomerManager();
            var firstCustomer = new Customer("Tomas Pouzar");
            var secondCustomer = new Customer("Franta Konyvka");
            var thirdCustomer = new Customer("Anna Odstrcilova");

            manager.CreateCustomer(firstCustomer);
            manager.CreateCustomer(secondCustomer);
            manager.CreateCustomer(thirdCustomer);

            manager.StoreOrders(new[]
            {
                new Order(3, "Zlate polomacene"),
                new Order(1, "Bohemia bramburky"),
            },
            firstCustomer);

            manager.StoreOrders(new[]
            {
                new Order(10, "Krusovice Cerne 0.5l"),
                new Order(9000, "Sparatko"),
            },
            secondCustomer);

            manager.StoreOrders(new[]
            {
                new Order(1, "Sparatko")
            }, 
            secondCustomer);

            manager.StoreOrders(new[]
            {
                new Order(2, "Tic Tac"),
                new Order(1, "Mentos freshmint"),
            },
            thirdCustomer);

            manager.WriteOutAllData();

            Console.WriteLine();

            foreach(var order in manager.GetAllOrders())
            {
                Console.WriteLine($"Tovar: {order.GoodsDescription}; Pocet: {order.Amount}");
            }

            Console.WriteLine();

            foreach(var order in manager.GetUniqueOrderDescriptions(secondCustomer))
            {
                Console.WriteLine($"Tovar: {order}");
            }
            

            Console.ReadKey();
        }
    }
}
