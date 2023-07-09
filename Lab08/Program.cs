namespace Lab08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var library = new Library();
            library.Add("Book 1", "Ali", "Saif", 180);
            library.Add("Book 2", "Sarah", "Ahmed", 220);

           
            var borrowedBook = library.Borrow("Book 1");
            Console.WriteLine("Borrowed Book: " + borrowedBook.Title);

           
            var backpack = new Backpack<Book>();
            backpack.Pack(borrowedBook);
            Console.WriteLine("Packed Book: " + backpack.First().Title);

            
            var unpackedBook = backpack.Unpack(0);
            Console.WriteLine("Unpacked Book: " + unpackedBook.Title);

           
            library.Return(unpackedBook);
            Console.WriteLine("Returned Book: " + unpackedBook.Title);
        }
    }
}