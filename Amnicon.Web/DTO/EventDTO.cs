using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Amnicon.Web.DTO
{
	public class EventDTO
	{
		/// <summary>
		/// Guid of the Event in our system
		/// </summary>
		[JsonProperty("id")]
		public string Id { get; set; }

		/// <summary>
		/// Event unique identifier as defined in RFC5545
		/// </summary>
		[JsonProperty("iCalUID")]
		public string ICalUID { get; set; }

		/// <summary>
		/// ISO 8601 Date and Time of creation
		/// </summary>
		[JsonProperty("created")]
		public string Created { get; set; }

		/// <summary>
		/// Who created the event
		/// </summary>
		[JsonProperty("createdBy")]
		public UserDTO CreatedBy { get; set; }

		/// <summary>
		/// ISO 8601 Last date and time the event was updated
		/// </summary>
		[JsonProperty("lastUpdated")]
		public string LastUpdated { get; set; }

		/// <summary>
		/// What user in our system last modified the event
		/// </summary>
		[JsonProperty("lastUpdatedBy")]
		public UserDTO LastUpdatedBy { get; set; }

		/// <summary>
		/// Geographic location or any text entered by a user to express the location
		/// </summary>
		[JsonProperty("location")]
		public string Location { get; set; }

		/// <summary>
		/// Who organized the event
		/// </summary>
		[JsonProperty("organizer")]
		public UserDTO Organizer { get; set; }

		/// <summary>
		/// For a recurring event, this is the date and time from the recurring Event identified by recurringEventId 
		/// even if this occurence of the Event was moved to a different date or time
		/// </summary>
		[JsonProperty("originalStart")]
		public string OriginalStart { get; set; }

		/// <summary>
		/// For a recurring event, this is the date and time from the recurring Event identified by recurringEventId 
		/// even if this occurence of the Event was moved to a different date or time
		/// </summary>
		[JsonProperty("originalEnd")]
		public string OriginalEnd { get; set; }

		/// <summary>
		/// The event id of the recurring event if this event belongs to a recurrence
		/// </summary>
		[JsonProperty("recurringEventId")]
		public string RecurringEventId { get; set; }

		/// <summary>
		/// Sequence number per iCalendar
		/// </summary>
		[JsonProperty("sequence")]
		public int? Sequence { get; set; }

		/// <summary>
		/// ISO 8601 Start date and time of this event
		/// </summary>
		[JsonProperty("start")]
		public string Start { get; set; }

		/// <summary>
		/// ISO 8601 End date and time of this event
		/// </summary>
		[JsonProperty("end")]
		public string End { get; set; }

		/// <summary>
		/// Status of the event, possible values are [confirmed, cancelled, tentative]
		/// </summary>
		[JsonProperty("status")]
		public string Status { get; set; }

		/// <summary>
		/// A title or summary for the Event
		/// </summary>
		[JsonProperty("title")]
		public string Title { get; set; }

		/// <summary>
		/// Description of the event
		/// </summary>
		[JsonProperty("description")]
		public string Description { get; set; }

		/// <summary>
		/// Who was invited to, or is attending the Event
		/// </summary>
		[JsonProperty("attendees")]
		public IList<EventAttendeeDTO> Attendees { get; set; }

		/// <summary>
		/// Whether users other than the organizer can invite others to the Event
		/// </summary>
		[JsonProperty("attendeesCanInviteOthers")]
		public bool? AttendeesCanInviteOthers { get; set; }

		/// <summary>
		/// Whether users other than the organizer can see the other attendees
		/// </summary>
		[JsonProperty("AttendeesCanSeeOtherGuests")]
		public bool? AttendeeCanSeeOtherGuests { get; set; }
	}
}
