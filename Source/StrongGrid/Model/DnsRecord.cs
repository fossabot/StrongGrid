﻿using Newtonsoft.Json;

namespace StrongGrid.Model
{
	/// <summary>
	/// DNS record
	/// </summary>
	public class DnsRecord
	{
		/// <summary>
		/// Gets or sets the host.
		/// </summary>
		/// <value>
		/// The host.
		/// </value>
		[JsonProperty("host")]
		public string Host { get; set; }

		/// <summary>
		/// Gets or sets the type.
		/// </summary>
		/// <value>
		/// The type.
		/// </value>
		[JsonProperty("type")]
		public string Type { get; set; }

		/// <summary>
		/// Gets or sets the data.
		/// </summary>
		/// <value>
		/// The data.
		/// </value>
		[JsonProperty("data")]
		public string Data { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether the dns record is valid.
		/// </summary>
		/// <value>
		///   <c>true</c> if this instance is valid; otherwise, <c>false</c>.
		/// </value>
		[JsonProperty("valid")]
		public bool IsValid { get; set; }
	}
}
