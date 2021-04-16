using System;
using WebAPI_12_04.Models;
using Microsoft.EntityFrameworkCore;
namespace WebAPI_12_04.Data
{
    public class LibDbContext : DbContext
    {
        public DbSet<Book> Book {get; set;}
        public DbSet<Category> Category {get; set;}
        public DbSet<Request> Request {get;set;}
        public DbSet<RequestDetail> RequestDetail {get;set;}
        public DbSet<Role> Role {get;set;}
        public DbSet<User> User {get;set;}



        protected override void OnConfiguring (DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=DESKTOP-JI28T8O;Database=LibDb;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

    }
}