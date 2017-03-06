using System;

namespace MethodOverloading_02
{
    class Program
    {
        static void Main(string[] args)
        {
             TestSimpleOverloadedMethods();
        }

        private static void TestSimpleOverloadedMethods()
        {
            Console.WriteLine("Output of simple overloaded methods \n");

            var logger = new Logger(DateTime.Now);

            // volani pretizene metody
            logger.WriteLoggedTime();

            // volani pretizene metody s volitelnym parametrem
            logger.WriteLoggedTime("Log with date");

            Console.ReadKey();
        }

        // ukol na pretezovani metod spojen s generiky
    }
}
