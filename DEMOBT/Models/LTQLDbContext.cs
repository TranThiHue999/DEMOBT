using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace DEMOBT.Models
{
    public partial class LTQLDbContext : DbContext
    {
        public LTQLDbContext()
            : base("name=LTQLDbContext")
        {
        }

        public virtual DbSet<Person> Persons { get;set; }
        public virtual DbSet<Employee> Employees { get;set; }
        public virtual DbSet<Account> Accounts { get;set; }
        public virtual DbSet<Role> Roles { get;set; }
        public virtual DbSet<KhachHang> KhachHangs { get;set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .Property(e => e.Username)
                .IsUnicode(false);
            modelBuilder.Entity<Account>()
                .Property(e => e.Password)
                .IsUnicode(false);
        }
        //internal void DeleteObject(Func<string, ActionResult> delete)
        //{
        //    throw new NotImplementedException();
        //}

    }
}
