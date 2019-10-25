using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace Amnicon.Domain
{
	public static class StringExtensions
	{
		public static string ToISO8601(this DateTime dt)
		{
			return dt.ToUniversalTime().ToString("o", CultureInfo.InvariantCulture);
		}

		public static string RemoveWhitespace(this string s)
		{
			return Regex.Replace(s, @"\s+", "");
		}
	}
}
