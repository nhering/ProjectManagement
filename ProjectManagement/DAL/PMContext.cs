using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using ProjectManagement.Models;

namespace ProjectManagement.DAL
{
    public class PMContext : DbContext
    {
        public PMContext() : base("PMContext")
        {
        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<People> People { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Card> Cards { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}