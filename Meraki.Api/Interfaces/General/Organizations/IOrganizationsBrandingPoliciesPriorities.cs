﻿namespace Meraki.Api.Interfaces.General.Organizations;

public interface IOrganizationsBrandingPoliciesPriorities
{
	/// <summary>
	/// Return the branding policy IDs of an organization in priority order
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	[Get("/organizations/{organizationId}/brandingPolicies/priorities")]
	Task<BrandingPoliciesPriorities> GetPrioritiesAsync(
		[AliasAs("organizationId")] string organizationId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update the priority ordering of an organization&#39;s branding policies.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="brandingPoliciesPriorities">Body for updating an organization branding policies priorities</param>
	[Put("/organizations/{organizationId}/brandingPolicies/priorities")]
	Task<BrandingPoliciesPriorities> UpdatePrioritiesAsync(
		[AliasAs("organizationId")] string organizationId,
		[Body] BrandingPoliciesPriorities brandingPoliciesPriorities,
		CancellationToken cancellationToken = default
		);
}
