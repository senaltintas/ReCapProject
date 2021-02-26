using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //veritabanı ile projemizi ilişkilendirmek 
    public class ReCapProjectDataBaseContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) //projemiz hangi veri tabanı ile ilişkili 
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database = RecapProjectDataBase;Trusted_Connection =true");   
        }
        //entity classlar database ile eşlendi
        public DbSet<Car> Cars { get; set; } 
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet <Customer> Customers { get; set; }
        public DbSet <Rental> Rentals { get; set; }
    }
    
}
