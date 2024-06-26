// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Microsoft.PowerBI.Api.Models
{
    /// <summary> The filter direction of the relationship. </summary>
    public enum CrossFilteringBehavior
    {
        /// <summary> For filtering purposes, the filter will be applied on the table where values are being aggregated. </summary>
        OneDirection,
        /// <summary> For filtering purposes, both tables are treated as a single table. </summary>
        BothDirections,
        /// <summary> Cross filtering behavior is automatically defined. </summary>
        Automatic
    }
}
