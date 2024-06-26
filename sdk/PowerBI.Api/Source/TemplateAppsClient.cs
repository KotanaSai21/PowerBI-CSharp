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
    /// <summary> The TemplateApps service client. </summary>
    public partial class TemplateAppsClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal TemplateAppsRestClient RestClient { get; }

        /// <summary> Initializes a new instance of TemplateAppsClient for mocking. </summary>
        protected TemplateAppsClient()
        {
        }

        /// <summary> Initializes a new instance of TemplateAppsClient. </summary>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="options"> The options for configuring the client. </param>
        public TemplateAppsClient(TokenCredential credential, Uri endpoint = null, PowerBIClientOptions options = null)
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
            RestClient = new TemplateAppsRestClient(_clientDiagnostics, _pipeline, endpoint);
        }

        /// <summary> Initializes a new instance of TemplateAppsClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/> or <paramref name="pipeline"/> is null. </exception>
        internal TemplateAppsClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            RestClient = new TemplateAppsRestClient(clientDiagnostics, pipeline, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Generates an installation ticket for the [automated install flow](/power-bi/connect-data/template-apps-auto-install) of the specified template app. </summary>
        /// <param name="requestParameters"> Create Install Ticket parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// ## Permissions
        ///
        /// The caller must use service principal for authentication. For more information, see [Embed Power BI content with service principal](/power-bi/developer/embed-service-principal) and [Considerations and limitations](/power-bi/developer/embedded/embed-service-principal#considerations-and-limitations).
        ///
        /// ## Limitations
        ///
        /// - The tenant making this API call *must* own the specified template app.
        /// - The template app must either be published to Microsoft AppSource, or, both the ticket creator and the end-user installing with the ticket must have explicit access to the app.
        /// - All query parameters in the install ticket *must* be configured.
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        public virtual async Task<Response<InstallTicket>> CreateInstallTicketAsync(CreateInstallTicketRequest requestParameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TemplateAppsClient.CreateInstallTicket");
            scope.Start();
            try
            {
                return await RestClient.CreateInstallTicketAsync(requestParameters, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Generates an installation ticket for the [automated install flow](/power-bi/connect-data/template-apps-auto-install) of the specified template app. </summary>
        /// <param name="requestParameters"> Create Install Ticket parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// ## Permissions
        ///
        /// The caller must use service principal for authentication. For more information, see [Embed Power BI content with service principal](/power-bi/developer/embed-service-principal) and [Considerations and limitations](/power-bi/developer/embedded/embed-service-principal#considerations-and-limitations).
        ///
        /// ## Limitations
        ///
        /// - The tenant making this API call *must* own the specified template app.
        /// - The template app must either be published to Microsoft AppSource, or, both the ticket creator and the end-user installing with the ticket must have explicit access to the app.
        /// - All query parameters in the install ticket *must* be configured.
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        public virtual Response<InstallTicket> CreateInstallTicket(CreateInstallTicketRequest requestParameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TemplateAppsClient.CreateInstallTicket");
            scope.Start();
            try
            {
                return RestClient.CreateInstallTicket(requestParameters, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
