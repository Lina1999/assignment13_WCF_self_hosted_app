using System.Collections.Generic;


namespace WcfBookService
{
    public class BookService : IBookService
    {
        List<Book> books = new List<Book>();
        
        public BookService() { }

        public  BookService(List<Book> books)
        {
            this.books = books;
        }

        /// <summary>
        /// Getting Book info by its ID
        /// </summary>
        /// <param name="bookID"></param>
        /// <returns></returns>
        public string GetBookInfo(int bookID)
        {
            string ans = "ID = " + bookID;
            for (int i = 0; i < books.Count; ++i)
            {
                if (bookID == books[i].ID)
                {
                    ans += " Author = " + books[i].Author + " Title = " + books[i].Title +
                        " Price = " + books[i].Price + " Year = " + books[i].Year;
                    return ans;
                }
            }
            return ans;
        }

        /// <summary>
        /// Adding new book
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        public BookResult AddBook(Book book)
        {
            BookResult bookRes = new BookResult();
            for (int i = 0; i < books.Count; ++i)
            {
                if (book.ID == books[i].ID)
                {
                    bookRes.Status = "Failure";
                    bookRes.Messege = "This book ID already exists";
                    return bookRes;
                }
            }
            bookRes.Status = "Success";
            bookRes.Messege = "Book Added";
            books.Add(book);
            return bookRes;
        }

        /// <summary>
        /// Updating book price
        /// </summary>
        /// <param name="bookID"></param>
        /// <param name="price"></param>
        public void UpdatePrice(int bookID, double price)
        {
            for (int i = 0; i < books.Count; ++i)
            {
                if (bookID == books[i].ID)
                {
                    books[i].Price = price;
                    return;
                }
            }
        }
    }
}