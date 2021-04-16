using System;
namespace WebAPI_12_04.Models{
public class User{
    public int  ID{get;set;}
    public string UserName{get;set;}
    public string Passwords{get;set;}
    public int RoleID{get;set;}
    public Role UserRole {get;set;}
    public DateTime InitialDate{get;set;}
}
}