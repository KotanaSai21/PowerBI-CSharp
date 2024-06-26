// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Microsoft.PowerBI.Api.Models
{
    /// <summary> The OData response wrapper for a list of Power BI principals with access to a dataset. </summary>
    public partial class DatasetUsersAccess
    {
        /// <summary> Initializes a new instance of <see cref="DatasetUsersAccess"/>. </summary>
        internal DatasetUsersAccess()
        {
            Value = new ChangeTrackingList<DatasetUserAccess>();
        }

        /// <summary> Initializes a new instance of <see cref="DatasetUsersAccess"/>. </summary>
        /// <param name="odataContext"></param>
        /// <param name="value"> The list of users with access to a dataset. </param>
        internal DatasetUsersAccess(string odataContext, IReadOnlyList<DatasetUserAccess> value)
        {
            OdataContext = odataContext;
            Value = value;
        }

        /// <summary> Gets the odata context. </summary>
        public string OdataContext { get; }
        /// <summary> The list of users with access to a dataset. </summary>
        public IReadOnlyList<DatasetUserAccess> Value { get; }
    }
}
