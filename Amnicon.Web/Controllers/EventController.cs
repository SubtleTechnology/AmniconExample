using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Amnicon.Domain;
using Amnicon.Web.DTO;

namespace Amnicon.Web.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
		private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

		string[] attendees = new string[] { "John Doe", "Tommy Sue", "Sam Smith" };

        // GET: api/Event
        [HttpGet]
        public IEnumerable<EventDTO> Get()
        {
			Logger.Debug($"Get");
			var rng = new Random();

			return Enumerable.Range(1, 5)
				.Select(index => new EventDTO {
					Id = Guid.NewGuid().ToString(),
					Created = DateTime.Now.ToISO8601(),
					Start = DateTime.Now.AddDays(2).ToISO8601(),
					Organizer = new UserDTO(Guid.NewGuid().ToString(), "Brad Young", "bradyoung@amniconsolutions.com"),
					Title = $"Title of an Event "+index,
					Attendees = (from att in Enumerable.Range(1, 5) 
								 let name = attendees[rng.Next(attendees.Length)]
								 select new EventAttendeeDTO {
										Id = Guid.NewGuid().ToString(),
										DisplayName = name,
										EmailAddress = $"{name.RemoveWhitespace()}@amniconsolutions.com"
									}).ToList()
				}).ToArray();
        }

        // GET: api/Event/5
        [HttpGet("{id}", Name = "Get")]
        public EventDTO Get(string id)
        {
			Logger.Debug($"Get {id}");
			return new EventDTO();
        }

        // POST: api/Event
        [HttpPost]
        public void Post([FromBody] EventDTO ev)
        {
			Logger.Debug($"Post {ev.Id} {ev.Title}");
        }

        // PUT: api/Event/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody] EventDTO ev)
        {
			Logger.Debug($"Put {id} {ev.Title}");
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
			Logger.Debug($"Delete {id}");
        }
    }
}
