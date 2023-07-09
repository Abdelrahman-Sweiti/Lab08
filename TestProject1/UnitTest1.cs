using Lab08;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Library_AddBook_CountIncreases()
        {
            var library = new Library();
            var book = new Book("Title", "Author");

           
            library.Add(book.Title, "First Name", "Last Name", 200); // Provide the missing arguments

            
            Assert.Equal(1, library.Count);
        }

        [Fact]
        public void Library_BorrowExistingTitle_ReturnsBookAndRemovesIt()
        {
            // Arrange
            var library = new Library();
            var book = new Book("Title", "Author");
            library.Add(book.Title, "First Name", "Last Name", 200);

            // Act
            var borrowedBook = library.Borrow(book.Title);

            // Assert
            Assert.Equal(book, borrowedBook);
            Assert.DoesNotContain(book, library);
            Assert.Equal(0, library.Count);
        }



        [Fact]
        public void Library_BorrowMissingTitle_ReturnsNull()
        {
            
            var library = new Library();

           
            var borrowedBook = library.Borrow("Missing Title");

           
            Assert.Null(borrowedBook);
        }

        [Fact]
        public void Library_ReturnBook_AddsBookToLibrary()
        {
           
            var library = new Library();
            var book = new Book("Title", "Author");

           
            library.Return(book);

            
            Assert.Contains(book, library);
            Assert.Equal(1, library.Count);
        }

        [Fact]
        public void Backpack_PackItem_CountIncreases()
        {
            
            var backpack = new Backpack<string>();

            
            backpack.Pack("Item");

           
            Assert.Equal(1, backpack.Count);
        }

        [Fact]
        public void Backpack_UnpackItemAtIndex_ReturnsItemAndRemovesIt()
        {
           
            var backpack = new Backpack<string>();
            backpack.Pack("Item");

           
            var unpackedItem = backpack.Unpack(0);

            
            Assert.Equal("Item", unpackedItem);
            Assert.Equal(0, backpack.Count);
        }
    }
}