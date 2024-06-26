// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Microsoft.PowerBI.Api.Models
{
    /// <summary> A connection string wrapper. </summary>
    public partial class ConnectionDetails
    {
        /// <summary> Initializes a new instance of <see cref="ConnectionDetails"/>. </summary>
        /// <param name="connectionString"> A dataset connection string. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionString"/> is null. </exception>
        public ConnectionDetails(string connectionString)
        {
            Argument.AssertNotNull(connectionString, nameof(connectionString));

            ConnectionString = connectionString;
        }

        /// <summary> A dataset connection string. </summary>
        public string ConnectionString { get; }
    }
}
