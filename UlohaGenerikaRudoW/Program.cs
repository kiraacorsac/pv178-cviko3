using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UlohaGenerikaRudoW
{
    #region zadanie
    /* Implementovat genericku strukturu Account podla rozhrania IAccout
     * 1. struktura Account musi implementovat vsetky predpisane polozky z rozhrania IAccount
     * 2. struktura Account bude mat naviac vlastnost generickeho typu LastOperationDate
     * - tento typ reprezentuje datum, kedy prebehla nejaka zmena na ucte
     * - tento typ nie je presne urceny - datum vieme reprezentovat ako int, string, DateTime...
     * 3. struktura bude obsahovat 1 konstruktor s 3 parametrami
     * ---------------------------------
       Implementovat staticku triedu na pracu s uctami
     * - trieda bude obsahovat genericke metody:
     * (genericky typ musi implementovat rozhranie IAccount)
     * 1. najdenie uctu s minimalnym zostatkom v kolekcii uctov
     * 2. najdenie uctu s maximalnym zostatkom v kolekcii uctov
     * 3. scitanie zostatkov vsetkych uctov v kolekcii
     * 4. rozsirujucu metodu pre typ IAccount - vrati velkost uroku
     * 5. modifikujucu metodu (ref) ktora pripocita urok k zostatku na ucte
     */

    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            IAccount account1 = new Account<DateTime>(1000m, DateTime.Now, DateTime.Now);
            Account<DateTime> account2 = new Account<DateTime>(500m, DateTime.Now.AddDays(-1), DateTime.Now);

            AccountsDemo2(account1, account2);

            Console.WriteLine();
        }


        private static void AccountsDemo2<T>(IAccount account1, Account<T> account2) 
        {
            IAccount[] accounts = { account1, account2 };

            Console.WriteLine("Min balance: {0}; should be: 500", AccountAlgorithms.MinBalance(accounts));//kompilator je schopny odvodit parametricky typ, fungovalo by aj vyssie
            Console.WriteLine("Max balance: {0}; should be: 1000", AccountAlgorithms.MaxBalance(accounts));
            Console.WriteLine("Sum: {0}; should be: 1500", AccountAlgorithms.Sum(accounts));
        }
    }
}
