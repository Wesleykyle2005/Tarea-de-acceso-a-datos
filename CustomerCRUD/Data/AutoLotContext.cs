using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharedModels;
using System.Configuration;


namespace CustomerCRUD.Data
{
    public class AutoLotContext:DbContext
    {
        public DbSet<Customer> customers { get; set; }
        public DbSet<CreditRisks> creditRisks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connection = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
            optionsBuilder.UseSqlServer(connection);
        }
    }
}
