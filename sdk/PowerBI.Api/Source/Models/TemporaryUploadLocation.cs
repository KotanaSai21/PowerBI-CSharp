// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Microsoft.PowerBI.Api.Models
{
    /// <summary> A Power BI update report content request. </summary>
    public partial class TemporaryUploadLocation
    {
        /// <summary> Initializes a new instance of <see cref="TemporaryUploadLocation"/>. </summary>
        /// <param name="url"> The shared access signature URL for the temporary blob storage. </param>
        /// <param name="expirationTime"> The expiration date and time of the shared access signature URL. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="url"/> is null. </exception>
        internal TemporaryUploadLocation(string url, DateTimeOffset expirationTime)
        {
            Argument.AssertNotNull(url, nameof(url));

            Url = url;
            ExpirationTime = expirationTime;
        }

        /// <summary> The shared access signature URL for the temporary blob storage. </summary>
        public string Url { get; }
        /// <summary> The expiration date and time of the shared access signature URL. </summary>
        public DateTimeOffset ExpirationTime { get; }
    }
}
