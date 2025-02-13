using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueueAssignments
{
    internal class ImplementaCustomHashMap
    {
        private const int Size = 100;
        private LinkedList<KeyValuePair<int, int>>[] map;

        public ImplementaCustomHashMap()
        {
            map = new LinkedList<KeyValuePair<int, int>>[Size];

            for (int i = 0; i < Size; i++)
                map[i] = new LinkedList<KeyValuePair<int, int>>();
        }

        private int Hash(int key)
        {
            return key % Size;
        }

        public void Insert(int key, int value)
        {

            int index = Hash(key);

            var bucket = map[index];

            foreach (var pair in bucket)
            {
                if (pair.Key == key)
                {
                    bucket.Remove(pair);

                    break;
                }
            }
            bucket.AddLast(new KeyValuePair<int, int>(key, value));
        }

        public int Get(int key)
        {
            int index = Hash(key);

            var bucket = map[index];

            foreach (var pair in bucket)
            {
                if (pair.Key == key)

                    return pair.Value;
            }
            return -1; // Not found
        }

        public void Remove(int key)
        {
            int index = Hash(key);

            var bucket = map[index];

            foreach (var pair in bucket)
            {
                if (pair.Key == key)
                {
                    bucket.Remove(pair);

                    return;
                }
            }
        }

        static void Main(string[] args)
        {
            ImplementaCustomHashMap hashMap = new ImplementaCustomHashMap();

            hashMap.Insert(1, 10);

            hashMap.Insert(2, 20);

            hashMap.Insert(3, 30);


            Console.WriteLine("Value at key 1: " + hashMap.Get(1));

            Console.WriteLine("Value at key 2: " + hashMap.Get(2));

            Console.WriteLine("Value at key 102: " + hashMap.Get(3));

            hashMap.Remove(2);

            Console.WriteLine("Value at key 2 after removal: " + hashMap.Get(2));
        }
    }
}
