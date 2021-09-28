﻿using Meraki.Api.Attributes;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	[DataContract]
	public abstract class NetworkOrConfigurationTemplate : NamedIdentifiedItem
	{
		/// <summary>
		/// ProductTypes
		/// </summary>
		[DataMember(Name = "productTypes")]
		public abstract List<ProductType> ProductTypes { get; set; }

		/// <summary>
		/// The timezone of the configuration template.
		/// For a list of allowed timezones, please see the 'TZ' column in the table in https://en.wikipedia.org/wiki/List_of_tz_database_time_zones
		/// </summary>
		[DataMember(Name = "timeZone")]
		[ApiAccess(ApiAccess.CreateUpdate)]
		public string TimeZone { get; set; } = string.Empty;
	}
}