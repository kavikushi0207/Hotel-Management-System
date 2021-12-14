using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace GUI_Group_Project.Models
{
    public partial class lastmodel : DbContext
    {
        public lastmodel()
            : base("name=lastmodel")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<dj> djs { get; set; }
        public virtual DbSet<Employer> Employers { get; set; }
        public virtual DbSet<hallre> hallres { get; set; }
        public virtual DbSet<Meeting> Meetings { get; set; }
        public virtual DbSet<MenuItem> MenuItems { get; set; }
        public virtual DbSet<roomre> roomres { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
