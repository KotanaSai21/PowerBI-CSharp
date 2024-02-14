// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Microsoft.PowerBI.Api.Models
{
    /// <summary> A Power BI response with the status of a workspace assign-to-capacity operation. </summary>
    public partial class WorkspaceCapacityAssignmentStatus
    {
        /// <summary> Initializes a new instance of <see cref="WorkspaceCapacityAssignmentStatus"/>. </summary>
        /// <param name="status"> The status of a workspace assign-to-capacity operation. </param>
        internal WorkspaceCapacityAssignmentStatus(AssignmentStatus status)
        {
            Status = status;
        }

        /// <summary> Initializes a new instance of <see cref="WorkspaceCapacityAssignmentStatus"/>. </summary>
        /// <param name="status"> The status of a workspace assign-to-capacity operation. </param>
        /// <param name="startTime"> The start date and time of a workspace assignment operation. </param>
        /// <param name="endTime"> The end date and time of a workspace assignment operation. </param>
        /// <param name="capacityId"> The capacity ID. </param>
        /// <param name="activityId"> The activity ID of the assignment operation (provided in case of an assignment failure). </param>
        internal WorkspaceCapacityAssignmentStatus(AssignmentStatus status, DateTimeOffset? startTime, DateTimeOffset? endTime, Guid? capacityId, Guid? activityId)
        {
            Status = status;
            StartTime = startTime;
            EndTime = endTime;
            CapacityId = capacityId;
            ActivityId = activityId;
        }

        /// <summary> The status of a workspace assign-to-capacity operation. </summary>
        public AssignmentStatus Status { get; }
        /// <summary> The start date and time of a workspace assignment operation. </summary>
        public DateTimeOffset? StartTime { get; }
        /// <summary> The end date and time of a workspace assignment operation. </summary>
        public DateTimeOffset? EndTime { get; }
        /// <summary> The capacity ID. </summary>
        public Guid? CapacityId { get; }
        /// <summary> The activity ID of the assignment operation (provided in case of an assignment failure). </summary>
        public Guid? ActivityId { get; }
    }
}
