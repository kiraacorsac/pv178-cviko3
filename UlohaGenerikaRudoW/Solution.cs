using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UlohaGenerikaRudoW
{
    class Solution
    {
        /// <summary>
        /// Metoda na najdenie uctu s najmensim zostatkom v kolekcii uctov
        /// </summary>
        /// <typeparam name="TAccount">typ uctu ulozeny v kolekcii</typeparam>
        /// <param name="accounts">zoznam uctov</param>
        /// <returns>minimalny zostatok</returns>
        public static TAccount MinBalance<TAccount>(IEnumerable<TAccount> accounts)
            where TAccount : IAccount
        {
            TAccount min = accounts.ElementAt(0);

            foreach (TAccount account in accounts)
            {
                if (account.Balance < min.Balance)
                {
                    min = account;
                }
            }

            return min;
        }

        /// <summary>
        /// Metoda na najdenie uctu s najvacsim zostatkom v kolekcii uctov
        /// </summary>
        /// <typeparam name="TAccount">typ uctu ulozeny v kolekcii</typeparam>
        /// <param name="accounts">zoznam uctov</param>
        /// <returns>maximalny zostatok</returns>
        public static TAccount MaxBalance<TAccount>(IEnumerable<TAccount> accounts)
            where TAccount : IAccount
        {
            TAccount max = accounts.ElementAt(0);

            foreach (TAccount account in accounts)
            {
                if (account.Balance > max.Balance)
                {
                    max = account;
                }
            }

            return max;
        }

        /// <summary>
        /// Metoda na scitanie zostatkov uctov v klekcii
        /// </summary>
        /// <typeparam name="TAccount">typ uctu</typeparam>
        /// <param name="accounts">zoznam uctov</param>
        /// <returns>suma vsetkych zostatkov na uctoch v kolekcii</returns>
        public static decimal Sum<TAccount>(IEnumerable<TAccount> accounts)
            where TAccount : IAccount
        {
            decimal sum = 0m;

            foreach (TAccount account in accounts)
            {
                sum += account.Balance;
            }

            return sum;
        }
    }
}
