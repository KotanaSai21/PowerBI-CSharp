// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Microsoft.PowerBI.Api.Models
{
    /// <summary> Power BI dataset data sources update request. </summary>
    public partial class UpdateDatasourcesRequest
    {
        /// <summary> Initializes a new instance of <see cref="UpdateDatasourcesRequest"/>. </summary>
        /// <param name="updateDetails"> An array of data source connection update requests. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="updateDetails"/> is null. </exception>
        public UpdateDatasourcesRequest(IEnumerable<UpdateDatasourceConnectionRequest> updateDetails)
        {
            Argument.AssertNotNull(updateDetails, nameof(updateDetails));

            UpdateDetails = updateDetails.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="UpdateDatasourcesRequest"/>. </summary>
        /// <param name="updateDetails"> An array of data source connection update requests. </param>
        internal UpdateDatasourcesRequest(IList<UpdateDatasourceConnectionRequest> updateDetails)
        {
            UpdateDetails = updateDetails;
        }

        /// <summary> An array of data source connection update requests. </summary>
        public IList<UpdateDatasourceConnectionRequest> UpdateDetails { get; }
    }
}
