// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Microsoft.PowerBI.Api.Models
{
    /// <summary> A dataset object in [GenerateTokenRequestV2](#generatetokenrequestv2). </summary>
    public partial class GenerateTokenRequestV2Dataset
    {
        /// <summary> Initializes a new instance of <see cref="GenerateTokenRequestV2Dataset"/>. </summary>
        /// <param name="id"> The dataset ID. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public GenerateTokenRequestV2Dataset(string id)
        {
            Argument.AssertNotNull(id, nameof(id));

            Id = id;
        }

        /// <summary> Initializes a new instance of <see cref="GenerateTokenRequestV2Dataset"/>. </summary>
        /// <param name="id"> The dataset ID. </param>
        /// <param name="xmlaPermissions"> XMLA Permissions. </param>
        internal GenerateTokenRequestV2Dataset(string id, XmlaPermissions? xmlaPermissions)
        {
            Id = id;
            XmlaPermissions = xmlaPermissions;
        }

        /// <summary> The dataset ID. </summary>
        public string Id { get; }
        /// <summary> XMLA Permissions. </summary>
        public XmlaPermissions? XmlaPermissions { get; set; }
    }
}
