using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace ImmutableCollections_Advanced
{
    //Make collection that will provide undo/redo capabilitis ussing immutable collection
    public class VersionedCollection : IEnumerable<string>
    {
        public void Add(string item)
        {
            throw new NotImplementedException();
        }

        public void Remove(string item)
        {
            throw new NotImplementedException();
        }

        public void Undo()
        {
            throw new NotImplementedException();
        }

        public IEnumerator<string> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
       
    }

    public static class ManagerDemo
    {
        public static void Main()
        {
            var collection = new VersionedCollection();

            while (true)
            {
                var line = Console.ReadLine();
                var op = line.Split( new []{' '}, 2);

                if (op.FirstOrDefault() == "undo")
                {
                    collection.Undo();
                }
                if (op.FirstOrDefault() == "a" && op.LastOrDefault()!=null)
                {
                    collection.Add(op.LastOrDefault());
                }
                if (op.FirstOrDefault() == "r" && op.LastOrDefault() != null)
                {
                    collection.Remove(op.LastOrDefault());
                }
                if (op.FirstOrDefault() == "e")
                {
                    break;
                }
                Console.WriteLine($"collection: {ToString(collection)}");
            }
        }

        private static string ToString(IEnumerable<string> enumerable) =>
            string.Join(", ", enumerable);
    }
}