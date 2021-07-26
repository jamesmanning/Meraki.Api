using Meraki.Api.Data;
using Refit;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IInventoryDevices
	{
		/// <summary>
		/// getOrganizationInventoryDevices
		/// </summary>
		/// <remarks>
		/// Return the device inventory for an organization
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId"></param>
		/// <param name="perPage">The number of entries per page returned. Acceptable range is 3 - 1000. Default is 1000.</param>
		/// <param name="startingAfter">A token used by the server to indicate the start of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
		/// <param name="endingBefore">A token used by the server to indicate the end of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
		/// <param name="usedState">Filter results by used or unused inventory. Accepted values are "used" or "unused".</param>
		/// <param name="search">Search for devices in inventory based on serial number, mac address, or model.</param>
		/// <returns>Task of Object</returns>
		[Get("/organizations/{organizationId}/inventoryDevices")]
		Task<List<InventoryDevices>> GetOrganizationInventoryDevicesAsync(
			[AliasAs("organizationId")] string organizationId,
			[AliasAs("perPage")] int? perPage = null,
			[AliasAs("startingAfter")] string? startingAfter = null,
			[AliasAs("endingBefore")] string? endingBefore = null,
			[AliasAs("usedState")] string? usedState = null,
			[AliasAs("search")] string? search = null,
			CancellationToken cancellationToken = default);
	}
}