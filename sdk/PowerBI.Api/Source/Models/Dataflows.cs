// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Microsoft.PowerBI.Api.Models
{
    /// <summary> OData response wrapper for a dataflow metadata list. </summary>
    public partial class Dataflows
    {
        /// <summary> Initializes a new instance of <see cref="Dataflows"/>. </summary>
        internal Dataflows()
        {
            Value = new ChangeTrackingList<Dataflow>();
        }

        /// <summary> Initializes a new instance of <see cref="Dataflows"/>. </summary>
        /// <param name="odataContext"></param>
        /// <param name="value"> The dataflow metadata list. </param>
        internal Dataflows(string odataContext, IReadOnlyList<Dataflow> value)
        {
            OdataContext = odataContext;
            Value = value;
        }

        /// <summary> Gets the odata context. </summary>
        public string OdataContext { get; }
        /// <summary> The dataflow metadata list. </summary>
        public IReadOnlyList<Dataflow> Value { get; }
    }
}
