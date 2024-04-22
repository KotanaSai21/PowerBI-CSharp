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
    /// <summary> The DataflowStorageAccounts service client. </summary>
    public partial class DataflowStorageAccountsClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal DataflowStorageAccountsRestClient RestClient { get; }

        /// <summary> Initializes a new instance of DataflowStorageAccountsClient for mocking. </summary>
        protected DataflowStorageAccountsClient()
        {
        }

        /// <summary> Initializes a new instance of DataflowStorageAccountsClient. </summary>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="options"> The options for configuring the client. </param>
        public DataflowStorageAccountsClient(TokenCredential credential, Uri endpoint = null, PowerBIClientOptions options = null)
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
            RestClient = new DataflowStorageAccountsRestClient(_clientDiagnostics, _pipeline, endpoint);
        }

        /// <summary> Initializes a new instance of DataflowStorageAccountsClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/> or <paramref name="pipeline"/> is null. </exception>
        internal DataflowStorageAccountsClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            RestClient = new DataflowStorageAccountsRestClient(clientDiagnostics, pipeline, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Returns a list of dataflow storage accounts that the user has access to. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// ## Required Scope
        ///
        /// StorageAccount.Read.All or StorageAccount.ReadWrite.All
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        public virtual async Task<Response<DataflowStorageAccounts>> GetDataflowStorageAccountsAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DataflowStorageAccountsClient.GetDataflowStorageAccounts");
            scope.Start();
            try
            {
                return await RestClient.GetDataflowStorageAccountsAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Returns a list of dataflow storage accounts that the user has access to. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// ## Required Scope
        ///
        /// StorageAccount.Read.All or StorageAccount.ReadWrite.All
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        public virtual Response<DataflowStorageAccounts> GetDataflowStorageAccounts(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DataflowStorageAccountsClient.GetDataflowStorageAccounts");
            scope.Start();
            try
            {
                return RestClient.GetDataflowStorageAccounts(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}