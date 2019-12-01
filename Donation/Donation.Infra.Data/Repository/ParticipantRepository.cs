using System;
using System.Collections.Generic;
using Donation.Domain.Entities;
using Donation.Domain.Interfaces;

namespace Donation.Infra.Data.Repository
{
    class ParticipantRepository : RepositoryBase<Donations>, IParticipantRepository
    {
        public IEnumerable<Participant> FindById(string id)
        {
            throw new NotImplementedException();
        }
    }
}
