// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Microsoft.PowerBI.Api.Models
{
    /// <summary> The PipelineUsersProperties. </summary>
    public partial class PipelineUsersProperties
    {
        /// <summary> Initializes a new instance of <see cref="PipelineUsersProperties"/>. </summary>
        internal PipelineUsersProperties()
        {
            Users = new ChangeTrackingList<PipelineUser>();
        }

        /// <summary> Initializes a new instance of <see cref="PipelineUsersProperties"/>. </summary>
        /// <param name="users"> The collection of deployment pipeline users. Only returned when `$expand` is set to `users` in the request. </param>
        internal PipelineUsersProperties(IReadOnlyList<PipelineUser> users)
        {
            Users = users;
        }

        /// <summary> The collection of deployment pipeline users. Only returned when `$expand` is set to `users` in the request. </summary>
        public IReadOnlyList<PipelineUser> Users { get; }
    }
}
