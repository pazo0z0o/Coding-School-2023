using Microsoft.EntityFrameworkCore;
using Session_16.EF.PetShop.Orm.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Session_16.EF.PetShop.Orm;
using Session_16.EF.Models;

namespace Session_16.EF.PetShop.Orm.Context
{
    public class AppDbContext : DbContext
    {   
        public DbSet<Customers> Customs { get; set; }
        public DbSet<Employees> Emps { get; set; }
        public DbSet<Pet> Pets { get; set; }

        public DbSet<PetFood> PetFoods { get; set; }
        public DbSet<MonthlyLedger> MonthLedger { get; set; }
        public DbSet<PetReport> PetRep { get; set; }
        public DbSet<Transactions> Transact { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CustomersConfig());
            modelBuilder.ApplyConfiguration(new EmployeesConfig());
            modelBuilder.ApplyConfiguration(new PetConfig());
            modelBuilder.ApplyConfiguration(new PetFoodConfig());
            modelBuilder.ApplyConfiguration(new PetReportConfig());
            modelBuilder.ApplyConfiguration(new TransactionsConfig());
            modelBuilder.ApplyConfiguration(new MonLedgerConfig());
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 

            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            base.OnConfiguring(optionsBuilder);
        }





    }
}
