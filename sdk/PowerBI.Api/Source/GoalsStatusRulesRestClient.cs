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
    internal partial class GoalsStatusRulesRestClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly Guid _groupId;
        private readonly Guid _scorecardId;
        private readonly Guid _goalId;
        private readonly Uri _endpoint;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> Initializes a new instance of GoalsStatusRulesRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="groupId"> The unique identifier of the workspace. </param>
        /// <param name="scorecardId"> The unique identifier of the scorecard. </param>
        /// <param name="goalId"> The unique identifier of the goal. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/> or <paramref name="pipeline"/> is null. </exception>
        public GoalsStatusRulesRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Guid groupId, Guid scorecardId, Guid goalId, Uri endpoint = null)
        {
            ClientDiagnostics = clientDiagnostics ?? throw new ArgumentNullException(nameof(clientDiagnostics));
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _groupId = groupId;
            _scorecardId = scorecardId;
            _goalId = goalId;
            _endpoint = endpoint ?? new Uri("https://api.powerbi.com");
        }

        internal HttpMessage CreatePreviewGetRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/v1.0/myorg/groups/", false);
            uri.AppendPath(_groupId, true);
            uri.AppendPath("/scorecards(", false);
            uri.AppendPath(_scorecardId, true);
            uri.AppendPath(")/goals(", false);
            uri.AppendPath(_goalId, true);
            uri.AppendPath(")/statusRules", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Returns status rules of a goal. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// ## Required Scope
        ///
        /// Dataset.Read.All or Dataset.ReadWrite.All
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        public async Task<Response<GoalsRulesGoalStatusRules>> PreviewGetAsync(CancellationToken cancellationToken = default)
        {
            using var message = CreatePreviewGetRequest();
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        GoalsRulesGoalStatusRules value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = GoalsRulesGoalStatusRules.DeserializeGoalsRulesGoalStatusRules(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Returns status rules of a goal. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// ## Required Scope
        ///
        /// Dataset.Read.All or Dataset.ReadWrite.All
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        public Response<GoalsRulesGoalStatusRules> PreviewGet(CancellationToken cancellationToken = default)
        {
            using var message = CreatePreviewGetRequest();
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        GoalsRulesGoalStatusRules value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = GoalsRulesGoalStatusRules.DeserializeGoalsRulesGoalStatusRules(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreatePreviewPostRequest(GoalsRulesGoalStatusRulesUpdateRequest statusRulesUpdateRequest)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/v1.0/myorg/groups/", false);
            uri.AppendPath(_groupId, true);
            uri.AppendPath("/scorecards(", false);
            uri.AppendPath(_scorecardId, true);
            uri.AppendPath(")/goals(", false);
            uri.AppendPath(_goalId, true);
            uri.AppendPath(")/statusRules", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue<GoalsRulesGoalStatusRulesUpdateRequest>(statusRulesUpdateRequest);
            request.Content = content;
            return message;
        }

        /// <summary> Creates or updates status rules of a goal. </summary>
        /// <param name="statusRulesUpdateRequest"> The status rules definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="statusRulesUpdateRequest"/> is null. </exception>
        /// <remarks>
        /// ## Required Scope
        ///
        /// Dataset.ReadWrite.All
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        public async Task<Response<GoalsRulesGoalStatusRules>> PreviewPostAsync(GoalsRulesGoalStatusRulesUpdateRequest statusRulesUpdateRequest, CancellationToken cancellationToken = default)
        {
            if (statusRulesUpdateRequest == null)
            {
                throw new ArgumentNullException(nameof(statusRulesUpdateRequest));
            }

            using var message = CreatePreviewPostRequest(statusRulesUpdateRequest);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        GoalsRulesGoalStatusRules value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = GoalsRulesGoalStatusRules.DeserializeGoalsRulesGoalStatusRules(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Creates or updates status rules of a goal. </summary>
        /// <param name="statusRulesUpdateRequest"> The status rules definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="statusRulesUpdateRequest"/> is null. </exception>
        /// <remarks>
        /// ## Required Scope
        ///
        /// Dataset.ReadWrite.All
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        public Response<GoalsRulesGoalStatusRules> PreviewPost(GoalsRulesGoalStatusRulesUpdateRequest statusRulesUpdateRequest, CancellationToken cancellationToken = default)
        {
            if (statusRulesUpdateRequest == null)
            {
                throw new ArgumentNullException(nameof(statusRulesUpdateRequest));
            }

            using var message = CreatePreviewPostRequest(statusRulesUpdateRequest);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        GoalsRulesGoalStatusRules value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = GoalsRulesGoalStatusRules.DeserializeGoalsRulesGoalStatusRules(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreatePreviewDeleteRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/v1.0/myorg/groups/", false);
            uri.AppendPath(_groupId, true);
            uri.AppendPath("/scorecards(", false);
            uri.AppendPath(_scorecardId, true);
            uri.AppendPath(")/goals(", false);
            uri.AppendPath(_goalId, true);
            uri.AppendPath(")/statusRules", false);
            request.Uri = uri;
            return message;
        }

        /// <summary> Removes status rule definitions from a goal. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// ## Required Scope
        ///
        /// Dataset.ReadWrite.All
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        public async Task<Response> PreviewDeleteAsync(CancellationToken cancellationToken = default)
        {
            using var message = CreatePreviewDeleteRequest();
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Removes status rule definitions from a goal. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// ## Required Scope
        ///
        /// Dataset.ReadWrite.All
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        public Response PreviewDelete(CancellationToken cancellationToken = default)
        {
            using var message = CreatePreviewDeleteRequest();
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
