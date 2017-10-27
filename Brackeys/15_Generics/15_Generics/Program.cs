using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            KeyValuePair<string, int> meaning = new KeyValuePair<string, int> ("Life", 42);
            meaning.Print();

            Console.WriteLine();

            Console.WriteLine(Utility.CompareValues("hello", 10));
            Console.WriteLine(Utility.CompareTypes("hi","hello"));

            Console.ReadKey();
        }
    }

    class KeyValuePair<TKey, TValue>
    {
        public TKey key;
        public TValue value;

        public KeyValuePair (TKey _key, TValue _value)
        {
            key = _key;
            value = _value;
        }

        public void Print()
        {
            Console.WriteLine("Key: " + key.ToString());
            Console.WriteLine("Value: " + value.ToString());
        }
    }

    class Utility
    {
        public static bool CompareValues<T01, T02> (T01 value01, T02 value02)
        {
            return value01.Equals(value02);
        }

        public static bool CompareTypes<T01, T02> (T01 type01, T02 type02)
        {
            return typeof(T01).Equals(typeof(T02));
        }
    }
}
