// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Microsoft.PowerBI.Api.Models
{
    /// <summary> A publish data source to gateway request. </summary>
    public partial class PublishDatasourceToGatewayRequest
    {
        /// <summary> Initializes a new instance of <see cref="PublishDatasourceToGatewayRequest"/>. </summary>
        /// <param name="dataSourceType"> The data source type. </param>
        /// <param name="connectionDetails"> The connection details. </param>
        /// <param name="credentialDetails"> The credential details. </param>
        /// <param name="dataSourceName"> The data source name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dataSourceType"/>, <paramref name="connectionDetails"/>, <paramref name="credentialDetails"/> or <paramref name="dataSourceName"/> is null. </exception>
        public PublishDatasourceToGatewayRequest(string dataSourceType, string connectionDetails, CredentialDetails credentialDetails, string dataSourceName)
        {
            Argument.AssertNotNull(dataSourceType, nameof(dataSourceType));
            Argument.AssertNotNull(connectionDetails, nameof(connectionDetails));
            Argument.AssertNotNull(credentialDetails, nameof(credentialDetails));
            Argument.AssertNotNull(dataSourceName, nameof(dataSourceName));

            DataSourceType = dataSourceType;
            ConnectionDetails = connectionDetails;
            CredentialDetails = credentialDetails;
            DataSourceName = dataSourceName;
        }

        /// <summary> The data source type. </summary>
        public string DataSourceType { get; }
        /// <summary> The connection details. </summary>
        public string ConnectionDetails { get; }
        /// <summary> The credential details. </summary>
        public CredentialDetails CredentialDetails { get; }
        /// <summary> The data source name. </summary>
        public string DataSourceName { get; }
    }
}
