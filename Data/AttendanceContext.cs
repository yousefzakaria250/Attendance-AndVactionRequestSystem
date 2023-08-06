using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class AttendanceContext : DbContext
    {
        public AttendanceContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Employee> Employee { set; get; }
        public DbSet<Department> Department { set; get; }
        public DbSet<Request> Request { set; get; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                               .HasOne(c => c.Supervisior)
                               .WithMany()
                               .HasForeignKey(c => c.SupervisiorId);
        }
    }
}
