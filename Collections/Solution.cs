using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    /// <summary>
    /// Trida spravuje seznam zakazniku,
    /// ke kazdemu zakazniku navic uchovava
    /// objednavky
    /// </summary>
    public class CustomerManagerSolved
    {

        IDictionary<Customer, ICollection<Order>> orderDictionary;
        // todo: 
        // deklarace (a inicializace) vhodne kolekce
        // pro ulozeni zakazniku s jejich objednavkami
        public CustomerManagerSolved()
        {
            orderDictionary = new Dictionary<Customer, ICollection<Order>>();
        }

        // ...

        /// <summary>
        /// todo: 
        /// prida zakaznika do kolekce, nezapomente
        /// zkontrolovat duplicitu
        /// </summary>
        /// <param name="customer">
        /// zakaznik
        /// </param>
        public void CreateCustomer(Customer customer)
        {
            if (!orderDictionary.ContainsKey(customer))
            {
                orderDictionary.Add(customer, new List<Order>() { });
            }
        }


        /// <summary>
        /// todo: 
        /// prida objednavky pro daneho zakaznika
        /// </summary>
        /// <param name="orders">
        /// objednavky
        /// </param>
        /// <param name="customer">
        /// zakaznik ke kteremu se maji pridat objednavky
        /// </param>
        public void StoreOrders(Order[] orders, Customer customer)
        {
            foreach (var o in orders)
            {
                orderDictionary[customer].Add(o);
            }
        }


        /// <summary>
        /// todo: 
        /// vypise vsechna ulozena data, pro vypis
        /// muzete zvolit libovolny format
        /// </summary>
        public void WriteOutAllData()
        {
            foreach (var k in orderDictionary)
            {
                Console.WriteLine(k.Key + ": ");
                foreach (var v in k.Value)
                {
                    Console.WriteLine("   " + v.Amount.ToString() + ": " + v.GoodsDescription);
                }
            }
        }

        /// <summary>
        /// todo:
        /// vrati vsetky objednavky ktore su v systeme
        /// </summary>
        /// <returns></returns>

        public IEnumerable<Order> GetAllOrders()
        {
            foreach (var orderList in orderDictionary.Values)
            {
                foreach (var order in orderList)
                {
                    yield return order;
                }
            }
        }

        /// <summary>
        /// vrati nazvy vsetkych produktov ktore si zakaznik objednal, bez duplicit
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        public ISet<string> GetUniqueOrderDescriptions(Customer customer)
        {
            var orders = orderDictionary[customer];
            var uniqueOrders = new HashSet<string>();
            foreach (var o in orders)
            {
                uniqueOrders.Add(o.GoodsDescription);
            }

            return uniqueOrders;
        }

    }

}
