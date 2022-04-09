using Microsoft.AspNet.Identity.EntityFramework;
using MovieSite.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace MovieSite.Data
{
   public class DataContext :IdentityDbContext<IdentityUser>
    {
        public DbSet<Movie> Movies { get; set; }

        public DbSet<Person> People { get; set; }

        public DbSet<Genre> Genre { get; set; }
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
