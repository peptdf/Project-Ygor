﻿using Donation.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donation.Domain.Interfaces
{
    public interface IDonationRepository : IRepositoryBase<Donations>
    {
    }
}
