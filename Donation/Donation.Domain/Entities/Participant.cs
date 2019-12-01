using System;
using System.Collections.Generic;
using System.Text;

namespace Donation.Domain.Entities
{
    class Participant
    {
        public string ParticipantId { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public bool Active { get; set; }

        public string PersonType { get; set; }
    }
}
