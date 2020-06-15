using System;
using Microsoft.EntityFrameworkCore;

namespace CustManSvc.Service.Database
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        { }
    }
}
