using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using HealthInsuranceInquiry.Domain.Entities;

namespace HealthInsuranceInquiry.Infrastructure.Configurations;

public class HealthInsuranceRequestConfiguration : IEntityTypeConfiguration<InsuranceRequest>
{
    public void Configure(EntityTypeBuilder<InsuranceRequest> builder)
    {

        builder.Property(s => s.Id);
        builder.Property(s => s.Name).IsRequired().HasMaxLength(150);
    }
}
