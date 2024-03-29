using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookMinAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BookMinAPI.Data
{
    public class PubContext : DbContext
    {
        public PubContext(DbContextOptions options) : base(options)
        { }
        public DbSet<Author> Authors => Set<Author>();
        //public DbSet<Book> Books => Set<Book>();
    }
}