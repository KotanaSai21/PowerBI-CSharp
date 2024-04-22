// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Microsoft.PowerBI.Api.Models;

namespace Microsoft.PowerBI.Api
{
    internal partial class WidelySharedArtifactsRestClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> Initializes a new instance of WidelySharedArtifactsRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/> or <paramref name="pipeline"/> is null. </exception>
        public WidelySharedArtifactsRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            ClientDiagnostics = clientDiagnostics ?? throw new ArgumentNullException(nameof(clientDiagnostics));
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://api.powerbi.com");
        }

        internal HttpMessage CreateLinksSharedToWholeOrganizationRequest(string continuationToken)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/v1.0/myorg/admin/widelySharedArtifacts/linksSharedToWholeOrganization", false);
            if (continuationToken != null)
            {
                uri.AppendQuery("continuationToken", continuationToken, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Returns a list of Power BI reports that are shared with the whole organization through links. </summary>
        /// <param name="continuationToken"> Token required to get the next chunk of the result set. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// ## Permissions
        ///
        /// - The user must have administrator rights (such as Office 365 Global Administrator or Power BI Service Administrator) or authenticate using a service principal.
        /// - Delegated permissions are supported.
        ///
        /// ## Required Scope
        ///
        /// Tenant.Read.All or Tenant.ReadWrite.All
        ///
        /// ## Limitations
        ///
        /// Maximum 200 requests per hour.
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        public async Task<Response<ArtifactAccessResponse>> LinksSharedToWholeOrganizationAsync(string continuationToken = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateLinksSharedToWholeOrganizationRequest(continuationToken);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ArtifactAccessResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ArtifactAccessResponse.DeserializeArtifactAccessResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Returns a list of Power BI reports that are shared with the whole organization through links. </summary>
        /// <param name="continuationToken"> Token required to get the next chunk of the result set. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// ## Permissions
        ///
        /// - The user must have administrator rights (such as Office 365 Global Administrator or Power BI Service Administrator) or authenticate using a service principal.
        /// - Delegated permissions are supported.
        ///
        /// ## Required Scope
        ///
        /// Tenant.Read.All or Tenant.ReadWrite.All
        ///
        /// ## Limitations
        ///
        /// Maximum 200 requests per hour.
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        public Response<ArtifactAccessResponse> LinksSharedToWholeOrganization(string continuationToken = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateLinksSharedToWholeOrganizationRequest(continuationToken);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ArtifactAccessResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ArtifactAccessResponse.DeserializeArtifactAccessResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreatePublishedToWebRequest(string continuationToken)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/v1.0/myorg/admin/widelySharedArtifacts/publishedToWeb", false);
            if (continuationToken != null)
            {
                uri.AppendQuery("continuationToken", continuationToken, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Returns a list of Power BI items (such as reports or dashboards) that are published to the web. </summary>
        /// <param name="continuationToken"> Token required to get the next chunk of the result set. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// ## Permissions
        ///
        /// - The user must have administrator rights (such as Office 365 Global Administrator or Power BI Service Administrator) or authenticate using a service principal.
        /// - Delegated permissions are supported.
        ///
        /// ## Required Scope
        ///
        /// Tenant.Read.All or Tenant.ReadWrite.All
        ///
        /// ## Limitations
        ///
        /// Maximum 200 requests per hour.
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        public async Task<Response<ArtifactAccessResponse>> PublishedToWebAsync(string continuationToken = null, CancellationToken cancellationToken = default)
        {
            using var message = CreatePublishedToWebRequest(continuationToken);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ArtifactAccessResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ArtifactAccessResponse.DeserializeArtifactAccessResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Returns a list of Power BI items (such as reports or dashboards) that are published to the web. </summary>
        /// <param name="continuationToken"> Token required to get the next chunk of the result set. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// ## Permissions
        ///
        /// - The user must have administrator rights (such as Office 365 Global Administrator or Power BI Service Administrator) or authenticate using a service principal.
        /// - Delegated permissions are supported.
        ///
        /// ## Required Scope
        ///
        /// Tenant.Read.All or Tenant.ReadWrite.All
        ///
        /// ## Limitations
        ///
        /// Maximum 200 requests per hour.
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        public Response<ArtifactAccessResponse> PublishedToWeb(string continuationToken = null, CancellationToken cancellationToken = default)
        {
            using var message = CreatePublishedToWebRequest(continuationToken);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ArtifactAccessResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ArtifactAccessResponse.DeserializeArtifactAccessResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}