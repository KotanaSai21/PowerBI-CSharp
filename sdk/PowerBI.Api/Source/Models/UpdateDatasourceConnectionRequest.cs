// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Microsoft.PowerBI.Api.Models
{
    /// <summary> Power BI dataset data source connection update request. </summary>
    public partial class UpdateDatasourceConnectionRequest
    {
        /// <summary> Initializes a new instance of <see cref="UpdateDatasourceConnectionRequest"/>. </summary>
        /// <param name="connectionDetails"> The target connection details of the updated data source. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionDetails"/> is null. </exception>
        public UpdateDatasourceConnectionRequest(DatasourceConnectionDetails connectionDetails)
        {
            Argument.AssertNotNull(connectionDetails, nameof(connectionDetails));

            ConnectionDetails = connectionDetails;
        }

        /// <summary> Initializes a new instance of <see cref="UpdateDatasourceConnectionRequest"/>. </summary>
        /// <param name="connectionDetails"> The target connection details of the updated data source. </param>
        /// <param name="datasourceSelector"> The connection details of the data source that needs update. This is mandatory when a dataset has more than one data source. </param>
        internal UpdateDatasourceConnectionRequest(DatasourceConnectionDetails connectionDetails, Datasource datasourceSelector)
        {
            ConnectionDetails = connectionDetails;
            DatasourceSelector = datasourceSelector;
        }

        /// <summary> The target connection details of the updated data source. </summary>
        public DatasourceConnectionDetails ConnectionDetails { get; }
        /// <summary> The connection details of the data source that needs update. This is mandatory when a dataset has more than one data source. </summary>
        public Datasource DatasourceSelector { get; set; }
    }
}
