// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Microsoft.PowerBI.Api.Models
{
    /// <summary> The OData response wrapper for a Power BI table collection. </summary>
    public partial class Tables
    {
        /// <summary> Initializes a new instance of <see cref="Tables"/>. </summary>
        internal Tables()
        {
            Value = new ChangeTrackingList<Table>();
        }

        /// <summary> Initializes a new instance of <see cref="Tables"/>. </summary>
        /// <param name="odataContext"> OData context. </param>
        /// <param name="value"> The Power BI tables. </param>
        internal Tables(string odataContext, IReadOnlyList<Table> value)
        {
            OdataContext = odataContext;
            Value = value;
        }

        /// <summary> OData context. </summary>
        public string OdataContext { get; }
        /// <summary> The Power BI tables. </summary>
        public IReadOnlyList<Table> Value { get; }
    }
}
