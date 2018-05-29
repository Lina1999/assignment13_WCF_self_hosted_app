using System.Runtime.Serialization;

namespace WcfBookService
{
    [DataContract]
    public class Book
    {
        public int ID { get; private set; }
        public string Author { get; private set; }
        public string Title { get; private set; }
        public double Price { get; set; }
        public int Year { get; private set; }
        public Book() {  }
        public Book(int ID, string Author, string Title, double Price, int Year)
        {
            this.ID = ID;
            this.Author = Author;
            this.Title = Title;
            this.Price = Price;
            this.Year = Year;
        }
    }
}
