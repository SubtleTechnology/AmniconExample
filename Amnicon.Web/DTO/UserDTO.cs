using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Amnicon.Web.DTO
{
	public class UserDTO
	{
		public UserDTO(string id, string displayName, string emailAddress)
		{
			Id = id;
			DisplayName = displayName;
			EmailAddress = emailAddress;
		}

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
		/// Email address of the user
		/// </summary>
		[JsonProperty("email")]
		public string EmailAddress { get; set; }
	}
}
