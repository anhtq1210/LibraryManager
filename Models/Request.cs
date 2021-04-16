using System;
using System.Collections.Generic;

namespace WebAPI_12_04.Models
{
    public enum Status{
        Pending,
        Approved,
        Rejected
    }
public class Request{
    public int  ID{get;set;}
    public User User{get;set;}
    public DateTime RequestDate{get;set;}
    public DateTime InitialDate{get;set;}
    public ICollection<RequestDetail> RequestDetail {get;set;} = new List<RequestDetail>();
    public Status Status{get;set;}
}
}