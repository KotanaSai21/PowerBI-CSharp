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
    /// <summary> The Goals service client. </summary>
    public partial class GoalsClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal GoalsRestClient RestClient { get; }

        /// <summary> Initializes a new instance of GoalsClient for mocking. </summary>
        protected GoalsClient()
        {
        }

        /// <summary> Initializes a new instance of GoalsClient. </summary>
        /// <param name="groupId"> The unique identifier of the workspace. </param>
        /// <param name="scorecardId"> The unique identifier of the scorecard. </param>
        /// <param name="goalId"> The unique identifier of the goal. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="options"> The options for configuring the client. </param>
        public GoalsClient(Guid groupId, Guid scorecardId, Guid goalId, TokenCredential credential, Uri endpoint = null, PowerBIClientOptions options = null)
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
            RestClient = new GoalsRestClient(_clientDiagnostics, _pipeline, groupId, scorecardId, goalId, endpoint);
        }

        /// <summary> Initializes a new instance of GoalsClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="groupId"> The unique identifier of the workspace. </param>
        /// <param name="scorecardId"> The unique identifier of the scorecard. </param>
        /// <param name="goalId"> The unique identifier of the goal. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/> or <paramref name="pipeline"/> is null. </exception>
        internal GoalsClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Guid groupId, Guid scorecardId, Guid goalId, Uri endpoint = null)
        {
            RestClient = new GoalsRestClient(clientDiagnostics, pipeline, groupId, scorecardId, goalId, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Returns a list of goals from a scorecard. </summary>
        /// <param name="expand"> Accepts a comma-separated list of data types, which will be expanded inline in the response. Supports `goalValues` and `aggregations`. </param>
        /// <param name="select"> Allows the clients to select specific properties from the server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// ## Required Scope
        ///
        /// Dataset.Read.All or Dataset.ReadWrite.All
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        public virtual async Task<Response<Goals>> PreviewGetAsync(string expand = null, string select = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GoalsClient.PreviewGet");
            scope.Start();
            try
            {
                return await RestClient.PreviewGetAsync(expand, select, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Returns a list of goals from a scorecard. </summary>
        /// <param name="expand"> Accepts a comma-separated list of data types, which will be expanded inline in the response. Supports `goalValues` and `aggregations`. </param>
        /// <param name="select"> Allows the clients to select specific properties from the server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// ## Required Scope
        ///
        /// Dataset.Read.All or Dataset.ReadWrite.All
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        public virtual Response<Goals> PreviewGet(string expand = null, string select = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GoalsClient.PreviewGet");
            scope.Start();
            try
            {
                return RestClient.PreviewGet(expand, select, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Adds a new goal to a scorecard. </summary>
        /// <param name="goal"> The properties of the new goal. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// ## Required Scope
        ///
        /// Dataset.ReadWrite.All
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        public virtual async Task<Response<Goal>> PreviewPostAsync(GoalCreateRequest goal, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GoalsClient.PreviewPost");
            scope.Start();
            try
            {
                return await RestClient.PreviewPostAsync(goal, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Adds a new goal to a scorecard. </summary>
        /// <param name="goal"> The properties of the new goal. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// ## Required Scope
        ///
        /// Dataset.ReadWrite.All
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        public virtual Response<Goal> PreviewPost(GoalCreateRequest goal, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GoalsClient.PreviewPost");
            scope.Start();
            try
            {
                return RestClient.PreviewPost(goal, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Returns a goal by ID from a scorecard. </summary>
        /// <param name="expand"> description. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// ## Required Scope
        ///
        /// Dataset.Read.All or Dataset.ReadWrite.All
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        public virtual async Task<Response<Goal>> PreviewGetByIDAsync(string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GoalsClient.PreviewGetByID");
            scope.Start();
            try
            {
                return await RestClient.PreviewGetByIDAsync(expand, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Returns a goal by ID from a scorecard. </summary>
        /// <param name="expand"> description. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// ## Required Scope
        ///
        /// Dataset.Read.All or Dataset.ReadWrite.All
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        public virtual Response<Goal> PreviewGetByID(string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GoalsClient.PreviewGetByID");
            scope.Start();
            try
            {
                return RestClient.PreviewGetByID(expand, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates a goal by ID. </summary>
        /// <param name="goal"> The goal properties to patch. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// ## Required Scope
        ///
        /// Dataset.ReadWrite.All
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        public virtual async Task<Response<Goal>> PreviewPatchByIDAsync(Goal goal, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GoalsClient.PreviewPatchByID");
            scope.Start();
            try
            {
                return await RestClient.PreviewPatchByIDAsync(goal, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates a goal by ID. </summary>
        /// <param name="goal"> The goal properties to patch. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// ## Required Scope
        ///
        /// Dataset.ReadWrite.All
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        public virtual Response<Goal> PreviewPatchByID(Goal goal, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GoalsClient.PreviewPatchByID");
            scope.Start();
            try
            {
                return RestClient.PreviewPatchByID(goal, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a goal from a scorecard by goal ID. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// ## Required Scope
        ///
        /// Dataset.ReadWrite.All
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        public virtual async Task<Response> PreviewDeleteByIDAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GoalsClient.PreviewDeleteByID");
            scope.Start();
            try
            {
                return await RestClient.PreviewDeleteByIDAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a goal from a scorecard by goal ID. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// ## Required Scope
        ///
        /// Dataset.ReadWrite.All
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        public virtual Response PreviewDeleteByID(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GoalsClient.PreviewDeleteByID");
            scope.Start();
            try
            {
                return RestClient.PreviewDeleteByID(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Reads refresh history of a connected goal. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// ## Required Scope
        ///
        /// Dataset.Read.All or Dataset.ReadWrite.All
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        public virtual async Task<Response<GoalRefreshHistories>> PreviewGetRefreshHistoryAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GoalsClient.PreviewGetRefreshHistory");
            scope.Start();
            try
            {
                return await RestClient.PreviewGetRefreshHistoryAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Reads refresh history of a connected goal. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// ## Required Scope
        ///
        /// Dataset.Read.All or Dataset.ReadWrite.All
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        public virtual Response<GoalRefreshHistories> PreviewGetRefreshHistory(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GoalsClient.PreviewGetRefreshHistory");
            scope.Start();
            try
            {
                return RestClient.PreviewGetRefreshHistory(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Disconnects the current value of a goal. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// ## Required Scope
        ///
        /// Dataset.ReadWrite.All
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        public virtual async Task<Response<Goal>> PreviewDeleteGoalCurrentValueConnectionAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GoalsClient.PreviewDeleteGoalCurrentValueConnection");
            scope.Start();
            try
            {
                return await RestClient.PreviewDeleteGoalCurrentValueConnectionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Disconnects the current value of a goal. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// ## Required Scope
        ///
        /// Dataset.ReadWrite.All
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        public virtual Response<Goal> PreviewDeleteGoalCurrentValueConnection(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GoalsClient.PreviewDeleteGoalCurrentValueConnection");
            scope.Start();
            try
            {
                return RestClient.PreviewDeleteGoalCurrentValueConnection(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Disconnects the target value of a goal. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// ## Required Scope
        ///
        /// Dataset.ReadWrite.All
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        public virtual async Task<Response<Goal>> PreviewDeleteGoalTargetValueConnectionAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GoalsClient.PreviewDeleteGoalTargetValueConnection");
            scope.Start();
            try
            {
                return await RestClient.PreviewDeleteGoalTargetValueConnectionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Disconnects the target value of a goal. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// ## Required Scope
        ///
        /// Dataset.ReadWrite.All
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        public virtual Response<Goal> PreviewDeleteGoalTargetValueConnection(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GoalsClient.PreviewDeleteGoalTargetValueConnection");
            scope.Start();
            try
            {
                return RestClient.PreviewDeleteGoalTargetValueConnection(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Schedules a refresh of the connected value of a goal. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// ## Required Scope
        ///
        /// Dataset.ReadWrite.All
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        public virtual async Task<Response> PreviewRefreshGoalCurrentValueAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GoalsClient.PreviewRefreshGoalCurrentValue");
            scope.Start();
            try
            {
                return await RestClient.PreviewRefreshGoalCurrentValueAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Schedules a refresh of the connected value of a goal. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// ## Required Scope
        ///
        /// Dataset.ReadWrite.All
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        public virtual Response PreviewRefreshGoalCurrentValue(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GoalsClient.PreviewRefreshGoalCurrentValue");
            scope.Start();
            try
            {
                return RestClient.PreviewRefreshGoalCurrentValue(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Schedules a refresh of the target value of a goal. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// ## Required Scope
        ///
        /// Dataset.ReadWrite.All
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        public virtual async Task<Response> PreviewRefreshGoalTargetValueAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GoalsClient.PreviewRefreshGoalTargetValue");
            scope.Start();
            try
            {
                return await RestClient.PreviewRefreshGoalTargetValueAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Schedules a refresh of the target value of a goal. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// ## Required Scope
        ///
        /// Dataset.ReadWrite.All
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        public virtual Response PreviewRefreshGoalTargetValue(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GoalsClient.PreviewRefreshGoalTargetValue");
            scope.Start();
            try
            {
                return RestClient.PreviewRefreshGoalTargetValue(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
