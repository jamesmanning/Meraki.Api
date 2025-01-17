﻿namespace Meraki.Api.Data;

/// <summary>
/// Link layers
/// </summary>
[ApiAccessReadOnlyClass]
[DataContract]
public class LinkLayers
{
	/// <summary>
	/// Nodes
	/// </summary>
	[DataMember(Name = "nodes")]
	public List<LinkLayerNode> Nodes { get; set; } = new();

	/// <summary>
	/// Links
	/// </summary>
	[DataMember(Name = "links")]
	public List<LinkLayerLinks> Links { get; set; } = new();
}
