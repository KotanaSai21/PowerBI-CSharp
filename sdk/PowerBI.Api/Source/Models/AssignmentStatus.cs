// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Microsoft.PowerBI.Api.Models
{
    /// <summary> The status of a workspace assign-to-capacity operation. </summary>
    public enum AssignmentStatus
    {
        /// <summary> The assignment request was received, but the assignment operation hasn't started. </summary>
        Pending,
        /// <summary> The assignment operation is in progress. </summary>
        InProgress,
        /// <summary> The assignment operation has completed successfully. </summary>
        CompletedSuccessfully,
        /// <summary> The assignment operation failed. </summary>
        AssignmentFailed
    }
}
