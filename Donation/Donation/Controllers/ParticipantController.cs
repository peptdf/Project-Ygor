using AutoMapper;
using Donation.Application;
using Donation.Application.Interfaces;
using Donation.Domain.Entities;
using Donation.Models;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Mvc;
namespace Donation.Controllers
{
    [System.Web.Http.Authorize]
    [System.Web.Http.RoutePrefix("api/Participant")]
    public class ParticipantController : ApiController
    {
        private const string LocalLoginProvider = "Local";
        private ApplicationUserManager _userManager;
        private readonly IParticipantAppService _participantApp;

        public ParticipantController(ParticipantAppService participantApp)
        {
            _participantApp = participantApp;
          
        }

        public ParticipantController(ApplicationUserManager userManager,
            ISecureDataFormat<AuthenticationTicket> accessTokenFormat)
        {
            UserManager = userManager;
            AccessTokenFormat = accessTokenFormat;
        }

        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? Request.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }

        public ISecureDataFormat<AuthenticationTicket> AccessTokenFormat { get; private set; }



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
        public void Post(ParticipantModels participant)
        {
            if (ModelState.IsValid)
            {
                var participantDomain = Mapper.Map<ParticipantModels, Participant>(participant);
                _participantApp.add(participantDomain);

                return RedirectToAction("Index");
            }

            ViewBag.ClienteId = new SelectList(_participantApp.Getall(), "ParticipantId", "Name", participant.ParticipantId);
            return View(participant);
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
