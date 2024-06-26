// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Microsoft.PowerBI.Api.Models
{
    /// <summary> The OData response wrapper for a Power BI tile collection. </summary>
    public partial class Tiles
    {
        /// <summary> Initializes a new instance of <see cref="Tiles"/>. </summary>
        internal Tiles()
        {
            Value = new ChangeTrackingList<Tile>();
        }

        /// <summary> Initializes a new instance of <see cref="Tiles"/>. </summary>
        /// <param name="odataContext"> OData context. </param>
        /// <param name="value"> The tile collection. </param>
        internal Tiles(string odataContext, IReadOnlyList<Tile> value)
        {
            OdataContext = odataContext;
            Value = value;
        }

        /// <summary> OData context. </summary>
        public string OdataContext { get; }
        /// <summary> The tile collection. </summary>
        public IReadOnlyList<Tile> Value { get; }
    }
}
