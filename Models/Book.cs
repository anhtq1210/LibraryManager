using System;
namespace WebAPI_12_04.Models{
    
public class Book{
    public int  ID{get;set;}
    public string Name{get;set;}
    public string Author{get;set;}
    public DateTime PublicDate{get;set;}
    public int CategoryID{get;set;}
    public Category Category{get;set;}
    public DateTime InitialDate{get;set;}
}
}