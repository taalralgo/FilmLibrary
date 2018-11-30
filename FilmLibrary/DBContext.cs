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

        public DbSet<Actor> Cities { get; set; }

        public DbSet<Actor> Countries { get; set; }


        public DbSet<Actor> Customers { get; set; }


        public DbSet<Actor> Films { get; set; }


        public DbSet<Actor> Inventories { get; set; }


        public DbSet<Actor> Languages { get; set; }


        public DbSet<Actor> Payments { get; set; }


        public DbSet<Actor> Rentals { get; set; }


        public DbSet<Actor> Staffs { get; set; }

        public DbSet<Actor> Stores { get; set; }

        public DBContext() : base("FilmLibrary")
        {
            Database.SetInitializer<DBContext>(new DropCreateDatabaseIfModelChanges<DBContext>());
        }

    }
}
