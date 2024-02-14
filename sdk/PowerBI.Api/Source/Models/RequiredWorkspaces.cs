// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Microsoft.PowerBI.Api.Models
{
    /// <summary> A required workspaces request. </summary>
    public partial class RequiredWorkspaces
    {
        /// <summary> Initializes a new instance of <see cref="RequiredWorkspaces"/>. </summary>
        public RequiredWorkspaces()
        {
            Workspaces = new ChangeTrackingList<Guid>();
        }

        /// <summary> Initializes a new instance of <see cref="RequiredWorkspaces"/>. </summary>
        /// <param name="workspaces"> The required workspace IDs to be scanned (supports 1 to 100 workspace IDs). </param>
        internal RequiredWorkspaces(IList<Guid> workspaces)
        {
            Workspaces = workspaces;
        }

        /// <summary> The required workspace IDs to be scanned (supports 1 to 100 workspace IDs). </summary>
        public IList<Guid> Workspaces { get; }
    }
}
