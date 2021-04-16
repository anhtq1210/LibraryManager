using System;
namespace WebAPI_12_04.ViewModel{
    
public class BookCreateRequest{
    public string Name{get;set;}
    public string Author{get;set;}
    public int ID{get;set;}
    public int CategoryID{get;set;}
    public DateTime PublicDate{get;set;}
    public DateTime InitialDate{get;set;}
}
}