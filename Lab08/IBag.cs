using System.Collections.Generic;

namespace Lab08
{

    public interface IBag<T> : IEnumerable<T>
    {
        void Pack(T item);
        T Unpack(int index);
    }
}