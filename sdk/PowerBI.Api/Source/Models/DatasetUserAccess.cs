// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Microsoft.PowerBI.Api.Models
{
    /// <summary> A Power BI principal access right entry for a dataset. </summary>
    public partial class DatasetUserAccess : Principal
    {
        /// <summary> Initializes a new instance of <see cref="DatasetUserAccess"/>. </summary>
        /// <param name="identifier"> For principal type `User`, provide the *UPN*. Otherwise provide the [object ID](/power-bi/developer/embedded/embedded-troubleshoot#what-is-the-difference-between-application-object-id-and-principal-object-id) of the principal. </param>
        /// <param name="principalType"> The principal type. </param>
        /// <param name="datasetUserAccessRight"> The access rights to assign to the user for the dataset (permission level). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="identifier"/> is null. </exception>
        public DatasetUserAccess(string identifier, PrincipalType principalType, DatasetUserAccessRight datasetUserAccessRight) : base(identifier, principalType)
        {
            Argument.AssertNotNull(identifier, nameof(identifier));

            DatasetUserAccessRight = datasetUserAccessRight;
        }

        /// <summary> The access rights to assign to the user for the dataset (permission level). </summary>
        public DatasetUserAccessRight DatasetUserAccessRight { get; set; }
    }
}
