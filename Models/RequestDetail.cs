using System;
namespace WebAPI_12_04.Models{
    public class RequestDetail{
    public int ID{get;set;}
    public int BookID{get;set;}
    public Book Book {get;set;}
    public int RequestID{get;set;}
    public Request Request{get;set;}

}
}
