// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Microsoft.PowerBI.Api.Models
{
    /// <summary> The unique ID and information protection label change status of a Power BI item. </summary>
    public partial class ChangeLabelStatus
    {
        /// <summary> Initializes a new instance of <see cref="ChangeLabelStatus"/>. </summary>
        /// <param name="id"> The unique ID of a Power BI item. The ID is in UUID format for dashboards, reports, and dataflows; and in UUID or string format for datasets. </param>
        /// <param name="status"> The status of an information protection label change operation. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        internal ChangeLabelStatus(string id, Status status)
        {
            Argument.AssertNotNull(id, nameof(id));

            Id = id;
            Status = status;
        }

        /// <summary> The unique ID of a Power BI item. The ID is in UUID format for dashboards, reports, and dataflows; and in UUID or string format for datasets. </summary>
        public string Id { get; }
        /// <summary> The status of an information protection label change operation. </summary>
        public Status Status { get; }
    }
}
