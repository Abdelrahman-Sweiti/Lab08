using Lab08;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Lab08
{

    public class Library : ILibrary
    {
        private Dictionary<string, Book> books;

        public Library()
        {
            books = new Dictionary<string, Book>();
        }

        public int Count => books.Count;

        public void Add(string title, string firstName, string lastName, int numberOfPages)
        {
            var author = $"{firstName} {lastName}";
            var book = new Book(title, author);
            books[title] = book;
        }

        public Book Borrow(string title)
        {
            if (books.ContainsKey(title))
            {
                var book = books[title];
                books.Remove(title);
                return book;
            }
            return null;
        }

        public void Return(Book book)
        {
            books[book.Title] = book;
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return books.Values.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}