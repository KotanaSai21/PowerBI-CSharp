// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Microsoft.PowerBI.Api.Models;

namespace Microsoft.PowerBI.Api
{
    /// <summary> The InformationProtection service client. </summary>
    public partial class InformationProtectionClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal InformationProtectionRestClient RestClient { get; }

        /// <summary> Initializes a new instance of InformationProtectionClient for mocking. </summary>
        protected InformationProtectionClient()
        {
        }

        /// <summary> Initializes a new instance of InformationProtectionClient. </summary>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="options"> The options for configuring the client. </param>
        public InformationProtectionClient(TokenCredential credential, Uri endpoint = null, PowerBIClientOptions options = null)
        {
            if (credential == null)
            {
                throw new ArgumentNullException(nameof(credential));
            }
            endpoint ??= new Uri("https://api.powerbi.com");

            options ??= new PowerBIClientOptions();
            _clientDiagnostics = new ClientDiagnostics(options);
            string[] scopes = { "https://analysis.windows.net/powerbi/api/.default" };
            _pipeline = HttpPipelineBuilder.Build(options, new BearerTokenAuthenticationPolicy(credential, scopes));
            RestClient = new InformationProtectionRestClient(_clientDiagnostics, _pipeline, endpoint);
        }

        /// <summary> Initializes a new instance of InformationProtectionClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/> or <paramref name="pipeline"/> is null. </exception>
        internal InformationProtectionClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            RestClient = new InformationProtectionRestClient(clientDiagnostics, pipeline, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Remove sensitivity labels from Power BI items (such as reports or dashboards) by item ID. </summary>
        /// <param name="artifacts"> A composite of artifact ID lists for each type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// For a usage example, see [Set or remove sensitivity labels](/power-bi/admin/service-security-sensitivity-label-inheritance-set-remove-api).
        ///
        /// ## Permissions
        ///
        /// - The user must have administrator rights (such as Office 365 Global Administrator or Power BI Service Administrator).
        /// - The admin user must have sufficient [usage rights](/azure/information-protection/configure-usage-rights) to delete labels.
        ///
        /// ## Required Scope
        ///
        /// Tenant.ReadWrite.All
        ///
        /// ## Limitations
        ///
        /// - Maximum 25 requests per hour.
        /// - Each request can update up to 2,000 Power BI items.
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        public virtual async Task<Response<InformationProtectionChangeLabelResponse>> RemoveLabelsAsAdminAsync(InformationProtectionArtifactsChangeLabel artifacts, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("InformationProtectionClient.RemoveLabelsAsAdmin");
            scope.Start();
            try
            {
                return await RestClient.RemoveLabelsAsAdminAsync(artifacts, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Remove sensitivity labels from Power BI items (such as reports or dashboards) by item ID. </summary>
        /// <param name="artifacts"> A composite of artifact ID lists for each type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// For a usage example, see [Set or remove sensitivity labels](/power-bi/admin/service-security-sensitivity-label-inheritance-set-remove-api).
        ///
        /// ## Permissions
        ///
        /// - The user must have administrator rights (such as Office 365 Global Administrator or Power BI Service Administrator).
        /// - The admin user must have sufficient [usage rights](/azure/information-protection/configure-usage-rights) to delete labels.
        ///
        /// ## Required Scope
        ///
        /// Tenant.ReadWrite.All
        ///
        /// ## Limitations
        ///
        /// - Maximum 25 requests per hour.
        /// - Each request can update up to 2,000 Power BI items.
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        public virtual Response<InformationProtectionChangeLabelResponse> RemoveLabelsAsAdmin(InformationProtectionArtifactsChangeLabel artifacts, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("InformationProtectionClient.RemoveLabelsAsAdmin");
            scope.Start();
            try
            {
                return RestClient.RemoveLabelsAsAdmin(artifacts, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Set sensitivity labels on Power BI items (such as reports or dashboards) by item ID. </summary>
        /// <param name="informationProtectionChangeLabelDetails"> Set label details. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// To set a sensitivity label using this API, the admin user or the delegated user (if provided) must have the label included in their [label policy](/microsoft-365/compliance/create-sensitivity-labels?view=o365-worldwide). For a usage example, see [Set or remove sensitivity labels](/power-bi/admin/service-security-sensitivity-label-inheritance-set-remove-api).
        ///
        /// ## Permissions
        ///
        /// - The user must have administrator rights (such as Office 365 Global Administrator or Power BI Service Administrator).
        /// - The admin user and the delegated user (if provided) must have sufficient [usage rights](/azure/information-protection/configure-usage-rights) to set labels.
        ///
        /// ## Required Scope
        ///
        /// Tenant.ReadWrite.All
        ///
        /// ## Limitations
        ///
        /// - Maximum 25 requests per hour.
        /// - Each request can update up to 2,000 Power BI items.
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        public virtual async Task<Response<InformationProtectionChangeLabelResponse>> SetLabelsAsAdminAsync(InformationProtectionChangeLabelDetails informationProtectionChangeLabelDetails, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("InformationProtectionClient.SetLabelsAsAdmin");
            scope.Start();
            try
            {
                return await RestClient.SetLabelsAsAdminAsync(informationProtectionChangeLabelDetails, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Set sensitivity labels on Power BI items (such as reports or dashboards) by item ID. </summary>
        /// <param name="informationProtectionChangeLabelDetails"> Set label details. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// To set a sensitivity label using this API, the admin user or the delegated user (if provided) must have the label included in their [label policy](/microsoft-365/compliance/create-sensitivity-labels?view=o365-worldwide). For a usage example, see [Set or remove sensitivity labels](/power-bi/admin/service-security-sensitivity-label-inheritance-set-remove-api).
        ///
        /// ## Permissions
        ///
        /// - The user must have administrator rights (such as Office 365 Global Administrator or Power BI Service Administrator).
        /// - The admin user and the delegated user (if provided) must have sufficient [usage rights](/azure/information-protection/configure-usage-rights) to set labels.
        ///
        /// ## Required Scope
        ///
        /// Tenant.ReadWrite.All
        ///
        /// ## Limitations
        ///
        /// - Maximum 25 requests per hour.
        /// - Each request can update up to 2,000 Power BI items.
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        public virtual Response<InformationProtectionChangeLabelResponse> SetLabelsAsAdmin(InformationProtectionChangeLabelDetails informationProtectionChangeLabelDetails, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("InformationProtectionClient.SetLabelsAsAdmin");
            scope.Start();
            try
            {
                return RestClient.SetLabelsAsAdmin(informationProtectionChangeLabelDetails, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
