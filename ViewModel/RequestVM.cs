using System;
using System.Collections.Generic;

namespace WebAPI_12_04.ViewModel{
    public enum Status{
        Pending,
        Approved,
        Rejected
    }
public class Request{
    public int ID{get;set;}
    public DateTime RequestDate{get;set;}
    public DateTime InitialDate{get;set;}
    public Status Status{get;set;}
}
}