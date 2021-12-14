using GUI_Group_Project.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Group_Project.Database
{
    class HotelDBContext:DbContext
    {
        public DbSet<Customer>Customers { get; set; }
        public DbSet<Employer> Employers { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<roomres> Roomres{ get; set; }
        public DbSet<hallres> Hallres { get; set; }
        public DbSet<Meeting> Meetings { get; set; }
        public DbSet<dj> Djs { get; set; }
    }
}
