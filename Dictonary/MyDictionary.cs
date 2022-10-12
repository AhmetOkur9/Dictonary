using System;
using System.Collections.Generic;
using System.Text;

namespace Dictonary
{
    class MyDictionary<T>
    {
        T[] things;
        public MyDictionary()
        {
            things = new T[0];
        }
        public void Add(T thing)
        {
            T[] tempArray = things;
            things = new T[things.Length+1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                things[i] = tempArray[i];
            }

            things[things.Length - 1] = thing;
        }

    }
}
