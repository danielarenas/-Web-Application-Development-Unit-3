using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace CINE.Models
{
    public class CineDBconnetion:DbContext
    {
        public CineDBconnetion(): base("cinedb")
        {

        }
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }

        public DbSet<Clasificacion> Clasificacions{get; set; }
        public DbSet<Categoty> Categoties { get; set; }
    }
}