using CRMSERVER1.Domain.Entities;
using CRMSERVER1.Domain.Enums;
using GenericRepository;
using Microsoft.EntityFrameworkCore;

namespace CRMSERVER1.Infrastructure.Context;
public class ApplicationDbContext : DbContext,IUnitOfWork
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Customer> Customers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>()
             .Property(p => p.CustomerType)
             .HasConversion(Customer => Customer.Value, value => CustomerTypeEnum.FromValue(value));
    }
}
