using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAndMethodOverloading
{
    class Solution
    {
        static void Swap(ref int firstInt, ref int secondInt)
        {
            GenericSwap(ref firstInt, ref secondInt);
        }

        static void Swap(ref string firstString, ref string secondString)
        {
            GenericSwap(ref firstString, ref secondString);
        }

        static void GenericSwap<T>(ref T first, ref T second)
        {
            var temp = first;
            first = second;
            second = temp;
        }

        static void AddManyToCollection<T, U>(T collection, U[] items)
            where T : IList<U>
        {
            if (items != null)
            {
                foreach (var item in items)
                {
                    collection.Add(item);
                }
            }
        }

        static U[] ToArray<T, U>(T list)
            where T : IList<U>
        {
            U[] array = new U[list.Count];

            for (int i = 0; i < list.Count; i++)
            {
                array[i] = list[i];
            }

            return array;
        }

    }
}
