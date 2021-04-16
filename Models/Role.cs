using System;
using System.Collections.Generic;
namespace WebAPI_12_04.Models{
public class Role{
    public int ID{get;set;}
    public string Name{get;set;}
    public ICollection<User> User {get;set;} = new List<User>();
    public DateTime InitialDate{get;set;}
}}
