using System;
using System.Collections;
using System.Linq;

namespace Dictionary
{
    class Dictionaryy<U, T>
    {
        public U[] Key { get; set; }
        public T[] Value { get; set; }
        public int Count { get; set; }

        public Dictionaryy(int capasity)
        {
            Key = new U[capasity];
            Value = new T[capasity];
            Count = 0;
        }

        public void Add(U paramKey, T paramValue)
        {
            if (!Key.Contains(paramKey))
            {
                Key[Count] = paramKey;
                Value[Count] = paramValue;
                Count++;
            }
        }

        public void Delete(U paramKey)
        {
            if (Key.Contains(paramKey))
            {
                int index = Array.IndexOf(Key, paramKey);
                Array.Copy(Key, index + 1, Key, index, Count - 1 - index);
                Array.Copy(Value, index + 1, Value, index, Count - 1 - index);
                Count--;
            }
        }

        public void Update(U paramKey, T paramValue)
        {
            if (Key.Contains(paramKey))
            {
                Value[Array.IndexOf(Key, paramKey)] = paramValue;
            }
        }
    }
}
