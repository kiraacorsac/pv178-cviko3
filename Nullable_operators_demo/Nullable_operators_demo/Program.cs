using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable_operators_demo
{

    class FoxStorage
    {
        public List<string> Foxes { get; set; } = null; //null je implicitne, nie je treba pisat

        public int CrashyFoxesCount => Foxes.Count();

        public int? FoxesCount => Foxes?.Count();

        public int SureFoxesCount => (Foxes ?? new List<string>()).Count();

        public string CrashyFirstFox => Foxes[0];

        public string FirstFox => Foxes?[0];


    }

    class Program
    {
        static void Main(string[] args)
        {
            var demoFoxStorage = new FoxStorage();

            //demoFoxStorage.Foxes = new List<string> { "Vulpes corsac", "Vulpes vulpes" };

            Console.WriteLine(demoFoxStorage.CrashyFoxesCount.ToString() ?? "Got null");

        }
    }
}
