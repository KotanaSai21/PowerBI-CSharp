// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Microsoft.PowerBI.Api.Models
{
    /// <summary> Update details for a paginated report data source. </summary>
    public partial class UpdateRdlDatasourceDetails
    {
        /// <summary> Initializes a new instance of <see cref="UpdateRdlDatasourceDetails"/>. </summary>
        /// <param name="connectionDetails"> The new connection details for the paginated report data source. </param>
        /// <param name="datasourceName"> The name of the paginated report data source. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionDetails"/> or <paramref name="datasourceName"/> is null. </exception>
        public UpdateRdlDatasourceDetails(RdlDatasourceConnectionDetails connectionDetails, string datasourceName)
        {
            Argument.AssertNotNull(connectionDetails, nameof(connectionDetails));
            Argument.AssertNotNull(datasourceName, nameof(datasourceName));

            ConnectionDetails = connectionDetails;
            DatasourceName = datasourceName;
        }

        /// <summary> The new connection details for the paginated report data source. </summary>
        public RdlDatasourceConnectionDetails ConnectionDetails { get; }
        /// <summary> The name of the paginated report data source. </summary>
        public string DatasourceName { get; }
    }
}
