using Donation.Application.Interfaces;
using Donation.Domain.Entities;
using Donation.Domain.Services;


namespace Donation.Application
{
    public class DonationAppService : AppServiceBase<Donations>, IDonationAppService
    {
        private readonly IDonationService _IDonationService;

        public DonationAppService(IDonationService idonationService) : base(idonationService)
        {
            _IDonationService = idonationService;
        }
    }
}
