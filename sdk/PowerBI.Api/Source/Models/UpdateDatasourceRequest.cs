// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Microsoft.PowerBI.Api.Models
{
    /// <summary> An update data source to gateway request. </summary>
    public partial class UpdateDatasourceRequest
    {
        /// <summary> Initializes a new instance of <see cref="UpdateDatasourceRequest"/>. </summary>
        /// <param name="credentialDetails"> The credential details. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="credentialDetails"/> is null. </exception>
        public UpdateDatasourceRequest(CredentialDetails credentialDetails)
        {
            Argument.AssertNotNull(credentialDetails, nameof(credentialDetails));

            CredentialDetails = credentialDetails;
        }

        /// <summary> The credential details. </summary>
        public CredentialDetails CredentialDetails { get; }
    }
}
