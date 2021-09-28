using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Override1
	/// </summary>
	[DataContract]
	public class Override1
	{
		/// <summary>
		/// List of switch profiles ids for template network
		/// </summary>
		/// <value>List of switch profiles ids for template network</value>
		[DataMember(Name = "switchProfiles")]
		public List<string> SwitchProfiles { get; set; } = new();
		/// <summary>
		/// List of switch serials for non-template network
		/// </summary>
		/// <value>List of switch serials for non-template network</value>
		[DataMember(Name = "switches")]
		public List<string> Switches { get; set; } = new();
		/// <summary>
		/// List of switch stack ids for non-template network
		/// </summary>
		/// <value>List of switch stack ids for non-template network</value>
		[DataMember(Name = "stacks")]
		public List<string> Stacks { get; set; } = new();
		/// <summary>
		/// IGMP snooping setting for switches, switch stacks or switch profiles
		/// </summary>
		/// <value>IGMP snooping setting for switches, switch stacks or switch profiles</value>
		[DataMember(Name = "igmpSnoopingEnabled")]
		public bool? IgmpSnoopingEnabled { get; set; }
		/// <summary>
		/// Flood unknown multicast traffic setting for switches, switch stacks or switch profiles
		/// </summary>
		/// <value>Flood unknown multicast traffic setting for switches, switch stacks or switch profiles</value>
		[DataMember(Name = "floodUnknownMulticastTrafficEnabled")]
		public bool? FloodUnknownMulticastTrafficEnabled { get; set; }
	}
}
