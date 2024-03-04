using DataBase.Models;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace DataBase
{
    public class MyDbContext : DbContext
    {
        internal DbSet<Item> Items { get; set; }
        internal DbSet<Tax> Taxes { get; set; }

        public MyDbContext(DbContextOptions<MyDbContext> options)
           : base(options)
        {
        }
        public MyDbContext()
        {
        }
    }
}