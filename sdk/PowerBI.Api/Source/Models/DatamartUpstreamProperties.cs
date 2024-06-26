// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Microsoft.PowerBI.Api.Models
{
    /// <summary> The DatamartUpstreamProperties. </summary>
    public partial class DatamartUpstreamProperties
    {
        /// <summary> Initializes a new instance of <see cref="DatamartUpstreamProperties"/>. </summary>
        internal DatamartUpstreamProperties()
        {
            UpstreamDataflows = new ChangeTrackingList<DependentDataflow>();
            UpstreamDatamarts = new ChangeTrackingList<DependentDatamart>();
        }

        /// <summary> Initializes a new instance of <see cref="DatamartUpstreamProperties"/>. </summary>
        /// <param name="upstreamDataflows"> The list of all the dataflows this item depends on. </param>
        /// <param name="upstreamDatamarts"> The list of all the datamarts this item depends on. </param>
        internal DatamartUpstreamProperties(IReadOnlyList<DependentDataflow> upstreamDataflows, IReadOnlyList<DependentDatamart> upstreamDatamarts)
        {
            UpstreamDataflows = upstreamDataflows;
            UpstreamDatamarts = upstreamDatamarts;
        }

        /// <summary> The list of all the dataflows this item depends on. </summary>
        public IReadOnlyList<DependentDataflow> UpstreamDataflows { get; }
        /// <summary> The list of all the datamarts this item depends on. </summary>
        public IReadOnlyList<DependentDatamart> UpstreamDatamarts { get; }
    }
}
