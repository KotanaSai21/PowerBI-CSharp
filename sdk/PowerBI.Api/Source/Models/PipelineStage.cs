// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Microsoft.PowerBI.Api.Models
{
    /// <summary> A Power BI deployment pipeline stage. </summary>
    public partial class PipelineStage
    {
        /// <summary> Initializes a new instance of <see cref="PipelineStage"/>. </summary>
        /// <param name="order"> The stage order, starting from zero. </param>
        internal PipelineStage(int order)
        {
            Order = order;
        }

        /// <summary> Initializes a new instance of <see cref="PipelineStage"/>. </summary>
        /// <param name="order"> The stage order, starting from zero. </param>
        /// <param name="workspaceId"> The assigned workspace ID. Only applicable when there's an assigned workspace. </param>
        /// <param name="workspaceName"> The assigned workspace name. Only applicable when there's an assigned workspace and the user has access to the workspace. </param>
        internal PipelineStage(int order, Guid? workspaceId, string workspaceName)
        {
            Order = order;
            WorkspaceId = workspaceId;
            WorkspaceName = workspaceName;
        }

        /// <summary> The stage order, starting from zero. </summary>
        public int Order { get; }
        /// <summary> The assigned workspace ID. Only applicable when there's an assigned workspace. </summary>
        public Guid? WorkspaceId { get; }
        /// <summary> The assigned workspace name. Only applicable when there's an assigned workspace and the user has access to the workspace. </summary>
        public string WorkspaceName { get; }
    }
}
