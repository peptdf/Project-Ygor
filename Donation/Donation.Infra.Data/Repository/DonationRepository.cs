using Donation.Domain.Entities;
using Donation.Domain.Interfaces;


namespace Donation.Infra.Data.Repository
{
    class DonationRepository : RepositoryBase<Donations>, IDonationRepository
    {
    }
}
