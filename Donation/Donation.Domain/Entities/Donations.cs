﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Donation.Domain.Entities
{
    public class Donations
    {

        public string DonationType { get; set; }

        public string ParticipantDonorId { get; set; }

        public string ParticipantBeneficiaryId { get; set; }

        public string DonationDescription { get; set; }

        public DateTime DonationDate { get; set; }


    }
}
