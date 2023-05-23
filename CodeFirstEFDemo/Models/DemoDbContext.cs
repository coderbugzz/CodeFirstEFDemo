using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeFirstEFDemo.Models
{
    public class DemoDbContext : DbContext
    {
        public DemoDbContext() : base("DefaultConnection")
        {
        }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Author> Authors { get; set; }
    }
}