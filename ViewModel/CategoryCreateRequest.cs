using System;
using System.Collections.Generic;
namespace WebAPI_12_04.ViewModel{
    public class CategoryCreateRequest{
    public string Name{get;set;}
    public IList<int> BookIds { get; set;}
    public DateTime InitialDate{get;set;}

}
}

