using HealthInsuranceInquiry.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace HealthInsuranceInquiry.Infrastructure;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }

    #region DbSets

     public DbSet<InsuranceRequest> InsuranceRequest => Set<InsuranceRequest>();

    #endregion
}