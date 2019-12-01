using Donation.Infra.Data.Repository;
using System.Web.Mvc;
using AutoMapper;
using System.Collections.Generic;
using Donation.Domain.Entities;
using Donation.Models;
using Donation.Application.Interfaces;
using System.Web.Http;

namespace Donation.Controllers
{
    [System.Web.Http.Authorize]
    public class DonationController : ApiController
    {
        private readonly IDonationAppService _DonationApp;

        // GET All
        public IEnumerable<string> GetAll()
        {
            return new string[] { "value1", "value2" };
        }

        // GET by id
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
