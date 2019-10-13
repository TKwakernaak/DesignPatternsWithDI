using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public static class FakeCache
    {
        public static Coffee TryGetValue(string key)
        {
            if (key == "coffee")
                return new Coffee("Old cached coffee");
            else
                return null;
        }


        public static void InsertValue<T>(T item)
        {
            Console.WriteLine($"item of type {item.GetType()} is added to cache");
        }
    }
}