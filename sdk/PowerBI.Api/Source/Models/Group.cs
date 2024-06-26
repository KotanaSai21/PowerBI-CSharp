// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Microsoft.PowerBI.Api.Models
{
    /// <summary> A Power BI group. </summary>
    public partial class Group : GroupBaseProperties
    {
        /// <summary> Initializes a new instance of <see cref="Group"/>. </summary>
        /// <param name="id"> The workspace ID. </param>
        public Group(Guid id) : base(id)
        {
        }

        /// <summary> Initializes a new instance of <see cref="Group"/>. </summary>
        /// <param name="id"> The workspace ID. </param>
        /// <param name="name"> The group name. </param>
        /// <param name="isReadOnly"> Whether the group is read-only. </param>
        /// <param name="isOnDedicatedCapacity"> Whether the group is assigned to a dedicated capacity. </param>
        /// <param name="capacityId"> The capacity ID. </param>
        /// <param name="dataflowStorageId"> The Power BI dataflow storage account ID. </param>
        /// <param name="defaultDatasetStorageFormat"> The default dataset storage format in the workspace. Returned only when `isOnDedicatedCapacity` is `true`. </param>
        /// <param name="logAnalyticsWorkspace"> The Log Analytics workspace assigned to the group.  This is returned only when retrieving a single group. </param>
        internal Group(Guid id, string name, bool? isReadOnly, bool? isOnDedicatedCapacity, Guid? capacityId, Guid? dataflowStorageId, DefaultDatasetStorageFormat? defaultDatasetStorageFormat, AzureResource logAnalyticsWorkspace) : base(id, name)
        {
            IsReadOnly = isReadOnly;
            IsOnDedicatedCapacity = isOnDedicatedCapacity;
            CapacityId = capacityId;
            DataflowStorageId = dataflowStorageId;
            DefaultDatasetStorageFormat = defaultDatasetStorageFormat;
            LogAnalyticsWorkspace = logAnalyticsWorkspace;
        }

        /// <summary> Whether the group is read-only. </summary>
        public bool? IsReadOnly { get; set; }
        /// <summary> Whether the group is assigned to a dedicated capacity. </summary>
        public bool? IsOnDedicatedCapacity { get; set; }
        /// <summary> The capacity ID. </summary>
        public Guid? CapacityId { get; set; }
        /// <summary> The Power BI dataflow storage account ID. </summary>
        public Guid? DataflowStorageId { get; set; }
        /// <summary> The default dataset storage format in the workspace. Returned only when `isOnDedicatedCapacity` is `true`. </summary>
        public DefaultDatasetStorageFormat? DefaultDatasetStorageFormat { get; set; }
        /// <summary> The Log Analytics workspace assigned to the group.  This is returned only when retrieving a single group. </summary>
        public AzureResource LogAnalyticsWorkspace { get; set; }
    }
}
