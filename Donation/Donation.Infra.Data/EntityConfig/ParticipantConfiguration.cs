using System;
using System.Collections.Generic;
using System.Text;

namespace Donation.Infra.Data.EntityConfig
{
    class ParticipantConfiguration : EntityTypeConfiguration<Participant>
    {
        public ParticipantConfiguration()
        {
            HasKey(p => p.ParticipantId);

            Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(100);

            
            Property(p => p.Age)
                .IsRequired();

            Property(p => p.Active)
                .IsRequired();

            Property(p => p.PersonType)
                .IsRequired();
        }
    }
}
