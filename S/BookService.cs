using System.Runtime.Serialization;
using System.ServiceModel;

namespace WcfBookService
{
    [ServiceContract]
    public interface IBookService
    {
        
        [OperationContract]
        string GetBookInfo(int bookID);

        [OperationContract]
        BookResult AddBook(Book book);

        [OperationContract]
        void UpdatePrice(int bookID, double price);

    }

    [DataContract]
    public class BookResult
    {
        public string Status { get; set; }
        public string Messege { get; set; }
    }
}

