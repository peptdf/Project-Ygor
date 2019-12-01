using System;
using System.Collections.Generic;
using System.Text;

namespace Donation.Infra.Data.EntityConfig
{
    class DonationConfiguration : EntityTypeConfiguration<Donation>
    {
        public DonationConfiguration()
        {
            HasKey(p => p.clienteId);

            Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(50);

            Property(p => p.SobreNome)
                .IsRequired()
                .HasMaxLength(100);

            Property(p => p.Idade)
                .IsRequired();

            Property(p => p.Ativo)
                .IsRequired();
        }

    }
}
