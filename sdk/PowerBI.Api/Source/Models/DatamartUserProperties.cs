// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Microsoft.PowerBI.Api.Models
{
    /// <summary> The DatamartUserProperties. </summary>
    public partial class DatamartUserProperties
    {
        /// <summary> Initializes a new instance of <see cref="DatamartUserProperties"/>. </summary>
        internal DatamartUserProperties()
        {
            Users = new ChangeTrackingList<DatamartUser>();
        }

        /// <summary> Initializes a new instance of <see cref="DatamartUserProperties"/>. </summary>
        /// <param name="users"> The user access details for a Power BI datamart. </param>
        internal DatamartUserProperties(IReadOnlyList<DatamartUser> users)
        {
            Users = users;
        }

        /// <summary> The user access details for a Power BI datamart. </summary>
        public IReadOnlyList<DatamartUser> Users { get; }
    }
}
