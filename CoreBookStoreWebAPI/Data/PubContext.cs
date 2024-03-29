using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreBookStoreWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreBookStoreWebAPI.Data
{
    public class PubContext : DbContext
    {
        public PubContext(DbContextOptions options) : base(options)
        { }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}