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
    /// <summary> The Profiles service client. </summary>
    public partial class ProfilesClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal ProfilesRestClient RestClient { get; }

        /// <summary> Initializes a new instance of ProfilesClient for mocking. </summary>
        protected ProfilesClient()
        {
        }

        /// <summary> Initializes a new instance of ProfilesClient. </summary>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="options"> The options for configuring the client. </param>
        public ProfilesClient(TokenCredential credential, Uri endpoint = null, PowerBIClientOptions options = null)
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
            RestClient = new ProfilesRestClient(_clientDiagnostics, _pipeline, endpoint);
        }

        /// <summary> Initializes a new instance of ProfilesClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/> or <paramref name="pipeline"/> is null. </exception>
        internal ProfilesClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            RestClient = new ProfilesRestClient(clientDiagnostics, pipeline, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Returns a list of service principal profiles for the organization. </summary>
        /// <param name="filter"> Filters the results based on a boolean condition, using 'id', 'displayName', or 'servicePrincipalId'. Supports only 'eq' operator. </param>
        /// <param name="top"> Returns only the first n results. This parameter must be in the range of 1-5000. </param>
        /// <param name="skip"> Skips the first n results. Use with top to fetch results beyond the first 5000. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// ## Permissions
        ///
        /// The user must have administrator rights or authenticate using a service principal.
        ///
        /// ## Required Scope
        ///
        /// Tenant.Read.All or Tenant.ReadWrite.All
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        public virtual async Task<Response<AdminServicePrincipalProfiles>> GetProfilesAsAdminAsync(string filter = null, int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ProfilesClient.GetProfilesAsAdmin");
            scope.Start();
            try
            {
                return await RestClient.GetProfilesAsAdminAsync(filter, top, skip, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Returns a list of service principal profiles for the organization. </summary>
        /// <param name="filter"> Filters the results based on a boolean condition, using 'id', 'displayName', or 'servicePrincipalId'. Supports only 'eq' operator. </param>
        /// <param name="top"> Returns only the first n results. This parameter must be in the range of 1-5000. </param>
        /// <param name="skip"> Skips the first n results. Use with top to fetch results beyond the first 5000. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// ## Permissions
        ///
        /// The user must have administrator rights or authenticate using a service principal.
        ///
        /// ## Required Scope
        ///
        /// Tenant.Read.All or Tenant.ReadWrite.All
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        public virtual Response<AdminServicePrincipalProfiles> GetProfilesAsAdmin(string filter = null, int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ProfilesClient.GetProfilesAsAdmin");
            scope.Start();
            try
            {
                return RestClient.GetProfilesAsAdmin(filter, top, skip, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes the specified service principal profile. </summary>
        /// <param name="profileId"> The service principal profile ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// ## Permissions
        ///
        /// The user must have administrator rights.
        ///
        /// ## Required Scope
        ///
        /// Tenant.ReadWrite.All
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        public virtual async Task<Response> DeleteProfileAsAdminAsync(Guid profileId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ProfilesClient.DeleteProfileAsAdmin");
            scope.Start();
            try
            {
                return await RestClient.DeleteProfileAsAdminAsync(profileId, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes the specified service principal profile. </summary>
        /// <param name="profileId"> The service principal profile ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// ## Permissions
        ///
        /// The user must have administrator rights.
        ///
        /// ## Required Scope
        ///
        /// Tenant.ReadWrite.All
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        public virtual Response DeleteProfileAsAdmin(Guid profileId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ProfilesClient.DeleteProfileAsAdmin");
            scope.Start();
            try
            {
                return RestClient.DeleteProfileAsAdmin(profileId, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Returns a list of service principal profiles. </summary>
        /// <param name="top"> Returns only the first n results. </param>
        /// <param name="skip"> Skips the first n results. </param>
        /// <param name="filter"> Get a profile by DisplayName. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// &lt;br/&gt;Returns a list of profiles that belongs to service principal caller.
        ///
        /// ## Limitations
        ///
        /// Can only be called by a service principal.
        /// </remarks>
        public virtual async Task<Response<ServicePrincipalProfiles>> GetProfilesAsync(int? top = null, int? skip = null, string filter = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ProfilesClient.GetProfiles");
            scope.Start();
            try
            {
                return await RestClient.GetProfilesAsync(top, skip, filter, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Returns a list of service principal profiles. </summary>
        /// <param name="top"> Returns only the first n results. </param>
        /// <param name="skip"> Skips the first n results. </param>
        /// <param name="filter"> Get a profile by DisplayName. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// &lt;br/&gt;Returns a list of profiles that belongs to service principal caller.
        ///
        /// ## Limitations
        ///
        /// Can only be called by a service principal.
        /// </remarks>
        public virtual Response<ServicePrincipalProfiles> GetProfiles(int? top = null, int? skip = null, string filter = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ProfilesClient.GetProfiles");
            scope.Start();
            try
            {
                return RestClient.GetProfiles(top, skip, filter, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates a new service principal profile. </summary>
        /// <param name="createOrUpdateProfileRequest"> The create profile request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// &lt;br/&gt;Creates a new profile that belongs to service principal caller.
        ///
        /// ## Limitations
        ///
        /// Can only be called by a service principal.
        /// </remarks>
        public virtual async Task<Response<ServicePrincipalProfile>> CreateProfileAsync(CreateOrUpdateProfileRequest createOrUpdateProfileRequest, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ProfilesClient.CreateProfile");
            scope.Start();
            try
            {
                return await RestClient.CreateProfileAsync(createOrUpdateProfileRequest, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates a new service principal profile. </summary>
        /// <param name="createOrUpdateProfileRequest"> The create profile request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// &lt;br/&gt;Creates a new profile that belongs to service principal caller.
        ///
        /// ## Limitations
        ///
        /// Can only be called by a service principal.
        /// </remarks>
        public virtual Response<ServicePrincipalProfile> CreateProfile(CreateOrUpdateProfileRequest createOrUpdateProfileRequest, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ProfilesClient.CreateProfile");
            scope.Start();
            try
            {
                return RestClient.CreateProfile(createOrUpdateProfileRequest, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Returns the specified service principal profile. </summary>
        /// <param name="profileId"> The service principal profile ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// &lt;br/&gt;Returns the specified profile if it exists and belongs to service principal caller.
        ///
        /// ## Limitations
        ///
        /// Can only be called by a service principal.
        /// </remarks>
        public virtual async Task<Response<ServicePrincipalProfile>> GetProfileAsync(Guid profileId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ProfilesClient.GetProfile");
            scope.Start();
            try
            {
                return await RestClient.GetProfileAsync(profileId, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Returns the specified service principal profile. </summary>
        /// <param name="profileId"> The service principal profile ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// &lt;br/&gt;Returns the specified profile if it exists and belongs to service principal caller.
        ///
        /// ## Limitations
        ///
        /// Can only be called by a service principal.
        /// </remarks>
        public virtual Response<ServicePrincipalProfile> GetProfile(Guid profileId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ProfilesClient.GetProfile");
            scope.Start();
            try
            {
                return RestClient.GetProfile(profileId, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates the specified service principal profile name. </summary>
        /// <param name="profileId"> The service principal profile ID. </param>
        /// <param name="createOrUpdateProfileRequest"> The update profile request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// &lt;br/&gt;Updates the specified profile name if it exists and belongs to service principal caller.
        ///
        /// ## Limitations
        ///
        /// Can only be called by a service principal.
        /// </remarks>
        public virtual async Task<Response<ServicePrincipalProfile>> UpdateProfileAsync(Guid profileId, CreateOrUpdateProfileRequest createOrUpdateProfileRequest, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ProfilesClient.UpdateProfile");
            scope.Start();
            try
            {
                return await RestClient.UpdateProfileAsync(profileId, createOrUpdateProfileRequest, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates the specified service principal profile name. </summary>
        /// <param name="profileId"> The service principal profile ID. </param>
        /// <param name="createOrUpdateProfileRequest"> The update profile request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// &lt;br/&gt;Updates the specified profile name if it exists and belongs to service principal caller.
        ///
        /// ## Limitations
        ///
        /// Can only be called by a service principal.
        /// </remarks>
        public virtual Response<ServicePrincipalProfile> UpdateProfile(Guid profileId, CreateOrUpdateProfileRequest createOrUpdateProfileRequest, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ProfilesClient.UpdateProfile");
            scope.Start();
            try
            {
                return RestClient.UpdateProfile(profileId, createOrUpdateProfileRequest, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes the specified service principal profile. </summary>
        /// <param name="profileId"> The service principal profile ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// &lt;br/&gt;Deletes the specified profile if it exists and belongs to service principal caller.
        ///
        /// ## Limitations
        ///
        /// Can only be called by a service principal.
        /// </remarks>
        public virtual async Task<Response> DeleteProfileAsync(Guid profileId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ProfilesClient.DeleteProfile");
            scope.Start();
            try
            {
                return await RestClient.DeleteProfileAsync(profileId, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes the specified service principal profile. </summary>
        /// <param name="profileId"> The service principal profile ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// &lt;br/&gt;Deletes the specified profile if it exists and belongs to service principal caller.
        ///
        /// ## Limitations
        ///
        /// Can only be called by a service principal.
        /// </remarks>
        public virtual Response DeleteProfile(Guid profileId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ProfilesClient.DeleteProfile");
            scope.Start();
            try
            {
                return RestClient.DeleteProfile(profileId, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}