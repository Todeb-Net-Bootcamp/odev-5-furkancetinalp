using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DbContexts
{
    public class PaymentAppDbContext : DbContext
    {
        private IConfiguration _configuration;
        
        public PaymentAppDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public DbSet<Bank> Banks { get; set; }
        public DbSet<CustomerList> CustomerLists { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<CardType> CardTypes { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<BankAddress> BankAddresses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = _configuration.GetConnectionString("MsComm");
            base.OnConfiguring(optionsBuilder.UseSqlServer(connectionString));

        }

    }
}
