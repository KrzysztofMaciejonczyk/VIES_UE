using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MyApi
{
    internal class WiesDB : DbContext
    {
        public DbSet<WIES> Wieses {  get; set; }
        public WiesDB() 
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite(@" Data Source = WIES .db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
