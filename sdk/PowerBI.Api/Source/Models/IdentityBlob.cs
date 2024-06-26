// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Microsoft.PowerBI.Api.Models
{
    /// <summary> A blob for specifying an identity. Only supported for datasets with a DirectQuery connection to Azure SQL. </summary>
    public partial class IdentityBlob
    {
        /// <summary> Initializes a new instance of <see cref="IdentityBlob"/>. </summary>
        /// <param name="value"> An OAuth 2.0 access token for Azure SQL. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public IdentityBlob(string value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value;
        }

        /// <summary> An OAuth 2.0 access token for Azure SQL. </summary>
        public string Value { get; }
    }
}
