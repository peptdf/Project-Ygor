using Donation.Domain.Entities;
using System.Collections.Generic;

namespace Donation.Domain.Interfaces
{
    public interface IParticipantRepository : IRepositoryBase<Participant>
    {
        IEnumerable<Participant> FindById(string Id);
    }
}
