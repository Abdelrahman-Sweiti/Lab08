using Lab08;
using System.Collections;
using System.Collections.Generic;

namespace Lab08
{

    public class Backpack<T> : IBag<T>
    {
        private List<T> items;

        public Backpack()
        {
            items = new List<T>();
        }

        public int Count => items.Count;

        public void Pack(T item)
        {
            if (item != null)
            {
                items.Add(item);
            }
        }

        public T Unpack(int index)
        {
            if (index >= 0 && index < items.Count)
            {
                var item = items[index];
                items.RemoveAt(index);
                return item;
            }
            return default(T);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}