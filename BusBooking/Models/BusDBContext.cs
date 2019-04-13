using MySql.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using System.Web;

namespace BusBooking.Models
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public partial class BusDBContext : DbContext
    {
        public BusDBContext()
            : base("name=ConString")
        {
        }

        public virtual DbSet<Bus> buses { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bus>()
                .Property(e => e.Color)
                .IsUnicode(false);
        }
        public List<Bus> topBuses()
        {

            return buses.OrderByDescending(item => item.DriverName).Take(5).ToList();
        }
    }
}