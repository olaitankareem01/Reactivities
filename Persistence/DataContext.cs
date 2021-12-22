using Domain;
using Microsoft.EntityFrameworkCore;
using System;


namespace Persistence
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions dbContextOptions):base(dbContextOptions)
        {
          
        }

        public DbSet<Activity> Activities { get; set; }
    }
}
