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
    public class CustomerManager
    {2

       
        // todo: 
        // deklarace (a inicializace) vhodne kolekce
        // pro ulozeni zakazniku s jejich objednavkami
        public CustomerManager()
        {
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

        }


        /// <summary>
        /// todo: 
        /// vypise vsechna ulozena data, pro vypis
        /// muzete zvolit libovolny format
        /// </summary>
        public void WriteOutAllData()
        {

        }

        /// <summary>
        /// todo:
        /// vrati vsetky objednavky ktore su v systeme
        /// </summary>
        /// <returns></returns>

        public IEnumerable<Order> GetAllOrders()
        {

        }

        /// <summary>
        /// vrati nazvy vsetkych produktov ktore si zakaznik objednal, bez duplicit
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        public ISet<string> GetUniqueOrderDescriptions(Customer customer)
        {

        }

    }

}
