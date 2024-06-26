// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Microsoft.PowerBI.Api.Models
{
    /// <summary> A Power BI dependent dataset. </summary>
    public partial class DependentDataset
    {
        /// <summary> Initializes a new instance of <see cref="DependentDataset"/>. </summary>
        public DependentDataset()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DependentDataset"/>. </summary>
        /// <param name="targetDatasetId"> The target dataset ID. </param>
        /// <param name="groupId"> The target group ID. </param>
        internal DependentDataset(string targetDatasetId, string groupId)
        {
            TargetDatasetId = targetDatasetId;
            GroupId = groupId;
        }

        /// <summary> The target dataset ID. </summary>
        public string TargetDatasetId { get; set; }
        /// <summary> The target group ID. </summary>
        public string GroupId { get; set; }
    }
}
