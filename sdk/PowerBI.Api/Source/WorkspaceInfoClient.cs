// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Microsoft.PowerBI.Api.Models;

namespace Microsoft.PowerBI.Api
{
    /// <summary> The WorkspaceInfo service client. </summary>
    public partial class WorkspaceInfoClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal WorkspaceInfoRestClient RestClient { get; }

        /// <summary> Initializes a new instance of WorkspaceInfoClient for mocking. </summary>
        protected WorkspaceInfoClient()
        {
        }

        /// <summary> Initializes a new instance of WorkspaceInfoClient. </summary>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="options"> The options for configuring the client. </param>
        public WorkspaceInfoClient(TokenCredential credential, Uri endpoint = null, PowerBIClientOptions options = null)
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
            RestClient = new WorkspaceInfoRestClient(_clientDiagnostics, _pipeline, endpoint);
        }

        /// <summary> Initializes a new instance of WorkspaceInfoClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/> or <paramref name="pipeline"/> is null. </exception>
        internal WorkspaceInfoClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            RestClient = new WorkspaceInfoRestClient(clientDiagnostics, pipeline, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Initiates a call to receive metadata for the requested list of workspaces. </summary>
        /// <param name="requiredWorkspaces"> Required workspace IDs to get info for. </param>
        /// <param name="lineage"> Whether to return lineage info (upstream dataflows, tiles, data source IDs). </param>
        /// <param name="datasourceDetails"> Whether to return data source details. </param>
        /// <param name="datasetSchema"> Whether to return dataset schema (tables, columns and measures). If you set this parameter to `true`, you must fully enable metadata scanning in order for data to be returned. For more information, see [Enable tenant settings for metadata scanning](/power-bi/admin/service-admin-metadata-scanning-setup#enable-tenant-settings-for-metadata-scanning). </param>
        /// <param name="datasetExpressions"> Whether to return dataset expressions (DAX and Mashup queries). If you set this parameter to `true`, you must fully enable metadata scanning in order for data to be returned. For more information, see [Enable tenant settings for metadata scanning](/power-bi/admin/service-admin-metadata-scanning-setup#enable-tenant-settings-for-metadata-scanning). </param>
        /// <param name="getArtifactUsers"> Whether to return user details for a Power BI item (such as a report or a dashboard). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// &gt; [!IMPORTANT]
        /// &gt; If you set the `datasetSchema` or `datasetExpressions` parameters to `true`, you must fully enable metadata scanning in order for data to be returned. For more information, see [Enable tenant settings for metadata scanning](/power-bi/admin/service-admin-metadata-scanning-setup#enable-tenant-settings-for-metadata-scanning).
        ///
        /// ## Permissions
        ///
        /// The user must have administrator rights (such as Microsoft 365 Global Administrator or Power BI Service Administrator) or authenticate using a service principal.
        ///
        /// When running under service principal authentication, an app **must not** have any admin-consent required permissions for Power BI set on it in the Azure portal.
        ///
        /// ## Required Scope
        ///
        /// Tenant.Read.All or Tenant.ReadWrite.All
        ///
        /// Relevant only when authenticating via a standard delegated admin access token. Must not be present when authentication via a service principal is used.
        ///
        /// ## Limitations
        ///
        /// - Maximum 500 requests per hour.
        /// - Maximum 16 simultaneous requests.
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        public virtual async Task<Response<ScanRequest>> PostWorkspaceInfoAsync(RequiredWorkspaces requiredWorkspaces, bool? lineage = null, bool? datasourceDetails = null, bool? datasetSchema = null, bool? datasetExpressions = null, bool? getArtifactUsers = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("WorkspaceInfoClient.PostWorkspaceInfo");
            scope.Start();
            try
            {
                return await RestClient.PostWorkspaceInfoAsync(requiredWorkspaces, lineage, datasourceDetails, datasetSchema, datasetExpressions, getArtifactUsers, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Initiates a call to receive metadata for the requested list of workspaces. </summary>
        /// <param name="requiredWorkspaces"> Required workspace IDs to get info for. </param>
        /// <param name="lineage"> Whether to return lineage info (upstream dataflows, tiles, data source IDs). </param>
        /// <param name="datasourceDetails"> Whether to return data source details. </param>
        /// <param name="datasetSchema"> Whether to return dataset schema (tables, columns and measures). If you set this parameter to `true`, you must fully enable metadata scanning in order for data to be returned. For more information, see [Enable tenant settings for metadata scanning](/power-bi/admin/service-admin-metadata-scanning-setup#enable-tenant-settings-for-metadata-scanning). </param>
        /// <param name="datasetExpressions"> Whether to return dataset expressions (DAX and Mashup queries). If you set this parameter to `true`, you must fully enable metadata scanning in order for data to be returned. For more information, see [Enable tenant settings for metadata scanning](/power-bi/admin/service-admin-metadata-scanning-setup#enable-tenant-settings-for-metadata-scanning). </param>
        /// <param name="getArtifactUsers"> Whether to return user details for a Power BI item (such as a report or a dashboard). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// &gt; [!IMPORTANT]
        /// &gt; If you set the `datasetSchema` or `datasetExpressions` parameters to `true`, you must fully enable metadata scanning in order for data to be returned. For more information, see [Enable tenant settings for metadata scanning](/power-bi/admin/service-admin-metadata-scanning-setup#enable-tenant-settings-for-metadata-scanning).
        ///
        /// ## Permissions
        ///
        /// The user must have administrator rights (such as Microsoft 365 Global Administrator or Power BI Service Administrator) or authenticate using a service principal.
        ///
        /// When running under service principal authentication, an app **must not** have any admin-consent required permissions for Power BI set on it in the Azure portal.
        ///
        /// ## Required Scope
        ///
        /// Tenant.Read.All or Tenant.ReadWrite.All
        ///
        /// Relevant only when authenticating via a standard delegated admin access token. Must not be present when authentication via a service principal is used.
        ///
        /// ## Limitations
        ///
        /// - Maximum 500 requests per hour.
        /// - Maximum 16 simultaneous requests.
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        public virtual Response<ScanRequest> PostWorkspaceInfo(RequiredWorkspaces requiredWorkspaces, bool? lineage = null, bool? datasourceDetails = null, bool? datasetSchema = null, bool? datasetExpressions = null, bool? getArtifactUsers = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("WorkspaceInfoClient.PostWorkspaceInfo");
            scope.Start();
            try
            {
                return RestClient.PostWorkspaceInfo(requiredWorkspaces, lineage, datasourceDetails, datasetSchema, datasetExpressions, getArtifactUsers, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the scan status for the specified scan. </summary>
        /// <param name="scanId"> The scan ID, which is included in the response from the workspaces or the [Admin - WorkspaceInfo PostWorkspaceInfo](/rest/api/power-bi/admin/workspace-info-post-workspace-info) API call that triggered the scan. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// ## Permissions
        ///
        /// The user must have administrator rights (such as Microsoft 365 Global Administrator or Power BI Service Administrator) or authenticate using a service principal.
        ///
        /// When running under service principal authentication, an app **must not** have any admin-consent required permissions for Power BI set on it in the Azure portal.
        ///
        /// ## Required Scope
        ///
        /// Tenant.Read.All or Tenant.ReadWrite.All
        ///
        /// Relevant only when authenticating via a standard delegated admin access token. Must not be present when authentication via a service principal is used.
        ///
        /// ## Limitations
        ///
        /// Maximum 10,000 requests per hour.
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        public virtual async Task<Response<ScanRequest>> GetScanStatusAsync(Guid scanId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("WorkspaceInfoClient.GetScanStatus");
            scope.Start();
            try
            {
                return await RestClient.GetScanStatusAsync(scanId, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the scan status for the specified scan. </summary>
        /// <param name="scanId"> The scan ID, which is included in the response from the workspaces or the [Admin - WorkspaceInfo PostWorkspaceInfo](/rest/api/power-bi/admin/workspace-info-post-workspace-info) API call that triggered the scan. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// ## Permissions
        ///
        /// The user must have administrator rights (such as Microsoft 365 Global Administrator or Power BI Service Administrator) or authenticate using a service principal.
        ///
        /// When running under service principal authentication, an app **must not** have any admin-consent required permissions for Power BI set on it in the Azure portal.
        ///
        /// ## Required Scope
        ///
        /// Tenant.Read.All or Tenant.ReadWrite.All
        ///
        /// Relevant only when authenticating via a standard delegated admin access token. Must not be present when authentication via a service principal is used.
        ///
        /// ## Limitations
        ///
        /// Maximum 10,000 requests per hour.
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        public virtual Response<ScanRequest> GetScanStatus(Guid scanId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("WorkspaceInfoClient.GetScanStatus");
            scope.Start();
            try
            {
                return RestClient.GetScanStatus(scanId, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the scan result for the specified scan. </summary>
        /// <param name="scanId"> The scan ID, which is included in the response from the workspaces or the [Admin - WorkspaceInfo PostWorkspaceInfo](/rest/api/power-bi/admin/workspace-info-post-workspace-info) API call that triggered the scan. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// Only make this API call after a successful [GetScanStatus](/rest/api/power-bi/admin/workspace-info-get-scan-status) API call. The scan result will remain available for 24 hours.
        ///
        /// ## Permissions
        ///
        /// The user must have administrator rights (such as Microsoft 365 Global Administrator or Power BI Service Administrator) or authenticate using a service principal.
        ///
        /// When running under service principal authentication, an app **must not** have any admin-consent required permissions for Power BI set on it in the Azure portal.
        ///
        /// ## Required Scope
        ///
        /// Tenant.Read.All or Tenant.ReadWrite.All
        ///
        /// Relevant only when authenticating via a standard delegated admin access token. Must not be present when authentication via a service principal is used.
        ///
        /// ## Limitations
        ///
        /// Maximum 500 requests per hour.
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        public virtual async Task<Response<WorkspaceInfoResponse>> GetScanResultAsync(Guid scanId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("WorkspaceInfoClient.GetScanResult");
            scope.Start();
            try
            {
                return await RestClient.GetScanResultAsync(scanId, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the scan result for the specified scan. </summary>
        /// <param name="scanId"> The scan ID, which is included in the response from the workspaces or the [Admin - WorkspaceInfo PostWorkspaceInfo](/rest/api/power-bi/admin/workspace-info-post-workspace-info) API call that triggered the scan. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// Only make this API call after a successful [GetScanStatus](/rest/api/power-bi/admin/workspace-info-get-scan-status) API call. The scan result will remain available for 24 hours.
        ///
        /// ## Permissions
        ///
        /// The user must have administrator rights (such as Microsoft 365 Global Administrator or Power BI Service Administrator) or authenticate using a service principal.
        ///
        /// When running under service principal authentication, an app **must not** have any admin-consent required permissions for Power BI set on it in the Azure portal.
        ///
        /// ## Required Scope
        ///
        /// Tenant.Read.All or Tenant.ReadWrite.All
        ///
        /// Relevant only when authenticating via a standard delegated admin access token. Must not be present when authentication via a service principal is used.
        ///
        /// ## Limitations
        ///
        /// Maximum 500 requests per hour.
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        public virtual Response<WorkspaceInfoResponse> GetScanResult(Guid scanId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("WorkspaceInfoClient.GetScanResult");
            scope.Start();
            try
            {
                return RestClient.GetScanResult(scanId, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a list of workspace IDs in the organization. </summary>
        /// <param name="modifiedSince"> Last modified date (must be in ISO 8601 compliant UTC format). </param>
        /// <param name="excludePersonalWorkspaces"> Whether to exclude personal workspaces. </param>
        /// <param name="excludeInActiveWorkspaces"> Whether to exclude inactive workspaces. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// If the optional `modifiedSince` parameter is set to a date-time, only the IDs of workspaces that changed after that date-time are returned. If the `modifiedSince` parameter isn't used, the IDs of all workspaces in the organization are returned. The date-time specified by the `modifiedSince` parameter must be in the range of 30 minutes (to allow workspace changes to take effect) to 30 days prior to the current time.
        ///
        /// ## Permissions
        ///
        /// The user must have administrator rights (such as Microsoft 365 Global Administrator or Power BI Service Administrator) or authenticate using a service principal.
        ///
        /// When running under service principal authentication, an app **must not** have any admin-consent required permissions for Power BI set on it in the Azure portal.
        ///
        /// ## Required Scope
        ///
        /// Tenant.Read.All or Tenant.ReadWrite.All
        ///
        /// Relevant only when authenticating via a standard delegated admin access token. Must not be present when authentication via a service principal is used.
        ///
        /// ## Limitations
        ///
        /// Maximum 30 requests per hour.
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        public virtual async Task<Response<IReadOnlyList<ModifiedWorkspace>>> GetModifiedWorkspacesAsync(DateTimeOffset? modifiedSince = null, bool? excludePersonalWorkspaces = null, bool? excludeInActiveWorkspaces = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("WorkspaceInfoClient.GetModifiedWorkspaces");
            scope.Start();
            try
            {
                return await RestClient.GetModifiedWorkspacesAsync(modifiedSince, excludePersonalWorkspaces, excludeInActiveWorkspaces, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a list of workspace IDs in the organization. </summary>
        /// <param name="modifiedSince"> Last modified date (must be in ISO 8601 compliant UTC format). </param>
        /// <param name="excludePersonalWorkspaces"> Whether to exclude personal workspaces. </param>
        /// <param name="excludeInActiveWorkspaces"> Whether to exclude inactive workspaces. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// If the optional `modifiedSince` parameter is set to a date-time, only the IDs of workspaces that changed after that date-time are returned. If the `modifiedSince` parameter isn't used, the IDs of all workspaces in the organization are returned. The date-time specified by the `modifiedSince` parameter must be in the range of 30 minutes (to allow workspace changes to take effect) to 30 days prior to the current time.
        ///
        /// ## Permissions
        ///
        /// The user must have administrator rights (such as Microsoft 365 Global Administrator or Power BI Service Administrator) or authenticate using a service principal.
        ///
        /// When running under service principal authentication, an app **must not** have any admin-consent required permissions for Power BI set on it in the Azure portal.
        ///
        /// ## Required Scope
        ///
        /// Tenant.Read.All or Tenant.ReadWrite.All
        ///
        /// Relevant only when authenticating via a standard delegated admin access token. Must not be present when authentication via a service principal is used.
        ///
        /// ## Limitations
        ///
        /// Maximum 30 requests per hour.
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        public virtual Response<IReadOnlyList<ModifiedWorkspace>> GetModifiedWorkspaces(DateTimeOffset? modifiedSince = null, bool? excludePersonalWorkspaces = null, bool? excludeInActiveWorkspaces = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("WorkspaceInfoClient.GetModifiedWorkspaces");
            scope.Start();
            try
            {
                return RestClient.GetModifiedWorkspaces(modifiedSince, excludePersonalWorkspaces, excludeInActiveWorkspaces, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}