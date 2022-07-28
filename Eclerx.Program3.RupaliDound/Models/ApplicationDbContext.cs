using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Eclerx.Program3.RupaliDound.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext() : base("EclerxConn")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Supplier>()
                .HasIndex(x => x.MobileNo)
                .IsUnique();
        }
        public DbSet<Supplier> Suppliers { get; set; }
    }
}