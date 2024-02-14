// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Microsoft.PowerBI.Api.Models
{
    /// <summary> The DatamartDatasourceUsagesProperties. </summary>
    public partial class DatamartDatasourceUsagesProperties
    {
        /// <summary> Initializes a new instance of <see cref="DatamartDatasourceUsagesProperties"/>. </summary>
        internal DatamartDatasourceUsagesProperties()
        {
            DatasourceUsages = new ChangeTrackingList<DatasourceUsage>();
        }

        /// <summary> Initializes a new instance of <see cref="DatamartDatasourceUsagesProperties"/>. </summary>
        /// <param name="datasourceUsages"> The data source usages. </param>
        internal DatamartDatasourceUsagesProperties(IReadOnlyList<DatasourceUsage> datasourceUsages)
        {
            DatasourceUsages = datasourceUsages;
        }

        /// <summary> The data source usages. </summary>
        public IReadOnlyList<DatasourceUsage> DatasourceUsages { get; }
    }
}
