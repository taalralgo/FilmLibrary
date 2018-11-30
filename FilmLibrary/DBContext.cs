using FilmLibrary.Les_Modeles;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmLibrary
{
    class DBContext : DbContext
    {
        public DbSet<Actor> Actors { get; set; }

        public DbSet<Adresse> Adresses { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<City> Cities { get; set; }

        public DbSet<Country> Countries { get; set; }


        public DbSet<Customer> Customers { get; set; }


        public DbSet<Film> Films { get; set; }


        public DbSet<Inventory> Inventories { get; set; }


        public DbSet<Language> Languages { get; set; }


        public DbSet<Payment> Payments { get; set; }


        public DbSet<Rental> Rentals { get; set; }


        public DbSet<Staff> Staffs { get; set; }

        public DbSet<Store> Stores { get; set; }

        public DBContext() : base("FilmLibrary")
        {
            Database.SetInitializer<DBContext>(new DropCreateDatabaseIfModelChanges<DBContext>());
        }

    }
}
