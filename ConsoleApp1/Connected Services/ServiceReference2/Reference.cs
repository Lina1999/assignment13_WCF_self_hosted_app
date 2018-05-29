﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApp1.ServiceReference2 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference2.IBookService")]
    public interface IBookService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/GetBookInfo", ReplyAction="http://tempuri.org/IBookService/GetBookInfoResponse")]
        string GetBookInfo(int bookID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/GetBookInfo", ReplyAction="http://tempuri.org/IBookService/GetBookInfoResponse")]
        System.Threading.Tasks.Task<string> GetBookInfoAsync(int bookID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/AddBook", ReplyAction="http://tempuri.org/IBookService/AddBookResponse")]
        WcfBookService.BookResult AddBook(WcfBookService.Book book);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/AddBook", ReplyAction="http://tempuri.org/IBookService/AddBookResponse")]
        System.Threading.Tasks.Task<WcfBookService.BookResult> AddBookAsync(WcfBookService.Book book);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/UpdatePrice", ReplyAction="http://tempuri.org/IBookService/UpdatePriceResponse")]
        void UpdatePrice(int bookID, double price);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/UpdatePrice", ReplyAction="http://tempuri.org/IBookService/UpdatePriceResponse")]
        System.Threading.Tasks.Task UpdatePriceAsync(int bookID, double price);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBookServiceChannel : ConsoleApp1.ServiceReference2.IBookService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BookServiceClient : System.ServiceModel.ClientBase<ConsoleApp1.ServiceReference2.IBookService>, ConsoleApp1.ServiceReference2.IBookService {
        
        public BookServiceClient() {
        }
        
        public BookServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BookServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BookServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BookServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetBookInfo(int bookID) {
            return base.Channel.GetBookInfo(bookID);
        }
        
        public System.Threading.Tasks.Task<string> GetBookInfoAsync(int bookID) {
            return base.Channel.GetBookInfoAsync(bookID);
        }
        
        public WcfBookService.BookResult AddBook(WcfBookService.Book book) {
            return base.Channel.AddBook(book);
        }
        
        public System.Threading.Tasks.Task<WcfBookService.BookResult> AddBookAsync(WcfBookService.Book book) {
            return base.Channel.AddBookAsync(book);
        }
        
        public void UpdatePrice(int bookID, double price) {
            base.Channel.UpdatePrice(bookID, price);
        }
        
        public System.Threading.Tasks.Task UpdatePriceAsync(int bookID, double price) {
            return base.Channel.UpdatePriceAsync(bookID, price);
        }
    }
}