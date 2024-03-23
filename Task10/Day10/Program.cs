namespace Day10
{
    public delegate string UserDefined(Book book);
    public class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string[] Authors { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }

        public Book(string iSBN, string title, string[] authors, DateTime publicationDate, decimal price)
        {
            ISBN = iSBN;
            Title = title;
            Authors = authors;
            PublicationDate = publicationDate;
            Price = price;
        }

        public override string ToString()
        {
            return $"ISBN: {ISBN}, Title: {Title}, Authors: {string.Join(", ", Authors)}, PublicationDate: {PublicationDate}, Price: {Price}";
        }
    }
    public class  BookFunctions
    {
        public static string GetTitle(Book book)
        {
            return $"Title: {book.Title}";
        }
        public static string GetAuthors(Book book)
        {
            return $"Authors: {string.Join(", ", book.Authors)}";
        }
        public static string GetPrice(Book book)
        {
            return $"Price: {book.Price}";
        }
    }
    public class LibraryEngine
    {
        public static void ProcessBooks(List<Book> bList, UserDefined fptr)
        {
            foreach (Book book in bList)
            {
                
                Console.WriteLine(fptr(book));
            }
        }

        public static void ProcessBooks2(List<Book> bList, Func<Book, string> fptr2)
        {
            foreach (Book book in bList)
            {

                Console.WriteLine(fptr2(book));
            }
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            List<Book> books = new List<Book>
            {
                   new Book("123", "Book 1", new string[] { "Author 1", "Author 2" }, DateTime.Now, 10),
                   new Book("456", "Book 2", new string[] { "Author 3", "Author 4" }, DateTime.Now, 20),
            };

            // a
            UserDefined fPtr = BookFunctions.GetTitle;
            LibraryEngine.ProcessBooks(books, fPtr);
            fPtr += BookFunctions.GetAuthors;
            LibraryEngine.ProcessBooks(books, fPtr);
            fPtr += BookFunctions.GetPrice;
            LibraryEngine.ProcessBooks(books, fPtr);

            // b
            Func<Book, string> fPtr2 = BookFunctions.GetTitle;
            LibraryEngine.ProcessBooks2(books, fPtr2);
            fPtr2 += BookFunctions.GetAuthors;
            LibraryEngine.ProcessBooks2(books, fPtr2);
            fPtr2 += BookFunctions.GetPrice;
            LibraryEngine.ProcessBooks2(books, fPtr2);

            // c
            UserDefined fptr3 = delegate(Book book)
            {
                return book.ToString();
            };
            LibraryEngine.ProcessBooks(books, fptr3);

            // d
            Func<Book, string> fptr4 =  (Book book) => book.ToString();
            LibraryEngine.ProcessBooks2(books, fptr4);

        }
    }
}
