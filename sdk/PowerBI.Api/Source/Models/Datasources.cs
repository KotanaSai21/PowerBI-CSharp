// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Microsoft.PowerBI.Api.Models
{
    /// <summary> The OData response wrapper for a Power BI data source collection. </summary>
    public partial class Datasources
    {
        /// <summary> Initializes a new instance of <see cref="Datasources"/>. </summary>
        internal Datasources()
        {
            Value = new ChangeTrackingList<Datasource>();
        }

        /// <summary> Initializes a new instance of <see cref="Datasources"/>. </summary>
        /// <param name="odataContext"> OData context. </param>
        /// <param name="value"> The data source collection. </param>
        internal Datasources(string odataContext, IReadOnlyList<Datasource> value)
        {
            OdataContext = odataContext;
            Value = value;
        }

        /// <summary> OData context. </summary>
        public string OdataContext { get; }
        /// <summary> The data source collection. </summary>
        public IReadOnlyList<Datasource> Value { get; }
    }
}
