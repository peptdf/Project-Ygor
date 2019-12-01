using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Text;

namespace Donation.Infra.Data.Migrations
{
    class Configuration : DbMigrationsConfiguration<Donation.Infra.Data.Context.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }
    }
}
