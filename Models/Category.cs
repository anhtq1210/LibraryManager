using System;
using System.Collections.Generic;
namespace WebAPI_12_04.Models{
    public class Category{
    public int  ID{get;set;}
    public string Name{get;set;}
    public DateTime InitialDate{get;set;}
    public ICollection<Book> Books {get;set;} = new List<Book>();
}
}

