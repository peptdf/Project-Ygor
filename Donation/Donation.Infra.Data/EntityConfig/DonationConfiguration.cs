using System.Data.Entity.ModelConfiguration;
using Donation.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;


namespace Donation.Infra.Data.EntityConfig
{
    class DonationConfiguration : EntityTypeConfiguration<Donations>
    {
        public DonationConfiguration()
        {
            HasKey(p => p.DonationType);

            Property(p => p.DonationDescription)
                .IsRequired()
                .HasMaxLength(50);

            Property(p => p.DonationType)
                .IsRequired()
                .HasMaxLength(100);

            Property(p => p.DonationDate)
                .IsRequired();

          
        }

    }
}
