using Lab08;
using System.Collections.Generic;

namespace Lab08
{

    public interface ILibrary : IReadOnlyCollection<Book>
    {
        void Add(string title, string firstName, string lastName, int numberOfPages);
        Book Borrow(string title);
        void Return(Book book);
    }
}