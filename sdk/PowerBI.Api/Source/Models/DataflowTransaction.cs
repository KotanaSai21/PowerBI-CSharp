// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Microsoft.PowerBI.Api.Models
{
    /// <summary> A Power BI dataflow transaction. </summary>
    public partial class DataflowTransaction
    {
        /// <summary> Initializes a new instance of <see cref="DataflowTransaction"/>. </summary>
        /// <param name="id"> The transaction ID. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        internal DataflowTransaction(string id)
        {
            Argument.AssertNotNull(id, nameof(id));

            Id = id;
        }

        /// <summary> Initializes a new instance of <see cref="DataflowTransaction"/>. </summary>
        /// <param name="id"> The transaction ID. </param>
        /// <param name="refreshType"> The type of refresh transaction. </param>
        /// <param name="startTime"> The start time of the transaction. </param>
        /// <param name="endTime"> The end time of the transaction. </param>
        /// <param name="status"> The status of the transaction. </param>
        internal DataflowTransaction(string id, string refreshType, string startTime, string endTime, string status)
        {
            Id = id;
            RefreshType = refreshType;
            StartTime = startTime;
            EndTime = endTime;
            Status = status;
        }

        /// <summary> The transaction ID. </summary>
        public string Id { get; }
        /// <summary> The type of refresh transaction. </summary>
        public string RefreshType { get; }
        /// <summary> The start time of the transaction. </summary>
        public string StartTime { get; }
        /// <summary> The end time of the transaction. </summary>
        public string EndTime { get; }
        /// <summary> The status of the transaction. </summary>
        public string Status { get; }
    }
}
