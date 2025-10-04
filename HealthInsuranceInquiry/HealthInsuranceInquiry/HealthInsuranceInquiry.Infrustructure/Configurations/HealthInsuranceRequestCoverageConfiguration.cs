using HealthInsuranceInquiry.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthInsuranceInquiry.Infrastructure.Configurations;

public class HealthInsuranceRequestCoverageConfiguration : IEntityTypeConfiguration<InsuranceRequestCoverage>
{
    public void Configure(EntityTypeBuilder<InsuranceRequestCoverage> builder)
    {
        builder.Property(s => s.Id);
        builder.Property(s => s.Price).IsRequired();
        builder.Property(s => s.Coverage).IsRequired();
        builder.Property(s => s.CreatedDate).IsRequired();
        builder.HasOne(a => a.InsuranceRequest)
               .WithMany(a => a.InsuranceRequestCoverages)
               .HasForeignKey(a => a.InsuranceRequestId);
    }
}