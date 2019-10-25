using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Amnicon.Web.DTO
{
	public class EventAttendeeDTO
	{
		/// <summary>
		/// GUID of the user if they exist on our system
		/// </summary>
		[JsonProperty("id")]
		public string Id { get; set; }

		/// <summary>
		/// Display name of the attendee
		/// </summary>
		[JsonProperty("displayName")]
		public  string DisplayName { get; set; }

		/// <summary>
		/// Email address of attendee
		/// </summary>
		[JsonProperty("email")]
		public string EmailAddress { get; set; }

		/// <summary>
		/// Response status from the attendee, possible values are [declined, tentative, accepted]
		/// </summary>
		[JsonProperty("responseStatus")]
		public  string ResponseStatus { get; set; }

		/// <summary>
		/// If the attendee indicated they will be bringing additional guests
		/// </summary>
		[JsonProperty("additionalGuests")]
		public  int? AdditionalGuests { get; set; }

		/// <summary>
		/// Any comments from the attendee
		/// </summary>
		[JsonProperty("comment")]
		public  string Comment { get; set; }

		/// <summary>
		/// Whether the organizer has indicated the attendee is optional or not
		/// </summary>
		[JsonProperty("optional")]
		public  bool? Optional { get; set; }
	}
}
