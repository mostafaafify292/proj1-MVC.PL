using Microsoft.EntityFrameworkCore;
using Proj1_MVC.DAL.Data.Configuration;
using Proj1_MVC.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj1_MVC.DAL.Data
{
    public class AddDbContext : DbContext
    {
        public AddDbContext(DbContextOptions options):base(options)
        {
            
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server = ., Database=Proj1-MVC, Trusted_Connection=True");
        //}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DepartmentConfiguration());
        }
        public DbSet<Department> departments { get; set; }
    }
}
