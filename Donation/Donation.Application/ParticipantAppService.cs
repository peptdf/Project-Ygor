using Donation.Application.Interfaces;
using Donation.Domain.Entities;
using Donation.Domain.Services;

namespace Donation.Application
{
    class ParticipantAppService : AppServiceBase<Participant>, IParticipantAppService
    {

        private readonly IParticipantService _IParticipantService;

        public ParticipantAppService(IParticipantService iparticipantService) : base(iparticipantService)
        {
            _IParticipantService = iparticipantService;
        }
    }
}
