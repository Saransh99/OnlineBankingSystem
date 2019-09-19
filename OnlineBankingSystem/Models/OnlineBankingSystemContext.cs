using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OnlineBankingSystem.Models
{
    public class OnlineBankingSystemContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<BranchManager> BranchManagers { get; set; }
        public DbSet<Administrator> Administrators { get; set; }
        public DbSet<AccountDetail> AccountDetails { get; set; }

    }
}