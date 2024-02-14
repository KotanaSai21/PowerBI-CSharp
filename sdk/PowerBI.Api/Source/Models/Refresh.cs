// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Microsoft.PowerBI.Api.Models
{
    /// <summary> A Power BI refresh history entry. </summary>
    public partial class Refresh
    {
        /// <summary> Initializes a new instance of <see cref="Refresh"/>. </summary>
        internal Refresh()
        {
            RefreshAttempts = new ChangeTrackingList<RefreshAttempt>();
        }

        /// <summary> Initializes a new instance of <see cref="Refresh"/>. </summary>
        /// <param name="refreshType"> The type of refresh request. </param>
        /// <param name="startTime"> The start date and time of the refresh. </param>
        /// <param name="endTime"> The end date and time of the refresh (may be empty if a refresh is in progress). </param>
        /// <param name="serviceExceptionJson"> Failure error code in JSON format (empty if no error). </param>
        /// <param name="status">
        /// - `Unknown` if the completion state is unknown or a refresh is in progress.
        /// - `Completed` for a successfully completed refresh.
        /// - `Failed` for an unsuccessful refresh (`serviceExceptionJson` will contain the error code).
        /// - `Disabled` if the refresh is disabled by a selective refresh.
        /// </param>
        /// <param name="requestId"> The identifier of the refresh request. Provide this identifier in all service requests. </param>
        /// <param name="refreshAttempts"> The refresh attempt list. </param>
        internal Refresh(RefreshType? refreshType, DateTimeOffset? startTime, DateTimeOffset? endTime, string serviceExceptionJson, string status, string requestId, IReadOnlyList<RefreshAttempt> refreshAttempts)
        {
            RefreshType = refreshType;
            StartTime = startTime;
            EndTime = endTime;
            ServiceExceptionJson = serviceExceptionJson;
            Status = status;
            RequestId = requestId;
            RefreshAttempts = refreshAttempts;
        }

        /// <summary> The type of refresh request. </summary>
        public RefreshType? RefreshType { get; }
        /// <summary> The start date and time of the refresh. </summary>
        public DateTimeOffset? StartTime { get; }
        /// <summary> The end date and time of the refresh (may be empty if a refresh is in progress). </summary>
        public DateTimeOffset? EndTime { get; }
        /// <summary> Failure error code in JSON format (empty if no error). </summary>
        public string ServiceExceptionJson { get; }
        /// <summary>
        /// - `Unknown` if the completion state is unknown or a refresh is in progress.
        /// - `Completed` for a successfully completed refresh.
        /// - `Failed` for an unsuccessful refresh (`serviceExceptionJson` will contain the error code).
        /// - `Disabled` if the refresh is disabled by a selective refresh.
        /// </summary>
        public string Status { get; }
        /// <summary> The identifier of the refresh request. Provide this identifier in all service requests. </summary>
        public string RequestId { get; }
        /// <summary> The refresh attempt list. </summary>
        public IReadOnlyList<RefreshAttempt> RefreshAttempts { get; }
    }
}
