using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EmirHomework
{
    public class BookContext : DbContext
    {
        public DbSet<Book> Book { get; set; }
        public DbSet<Publisher> Publisher { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=DESKTOP-RNM469S\\SQLEXPRESS;Database=BookDb;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }
}