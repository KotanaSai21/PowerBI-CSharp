// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Microsoft.PowerBI.Api.Models
{
    /// <summary> Odata response wrapper for dataflow transactions. </summary>
    public partial class DataflowTransactions
    {
        /// <summary> Initializes a new instance of <see cref="DataflowTransactions"/>. </summary>
        internal DataflowTransactions()
        {
            Value = new ChangeTrackingList<DataflowTransaction>();
        }

        /// <summary> Initializes a new instance of <see cref="DataflowTransactions"/>. </summary>
        /// <param name="odataContext"> OData context. </param>
        /// <param name="value"> The dataflow transactions. </param>
        internal DataflowTransactions(string odataContext, IReadOnlyList<DataflowTransaction> value)
        {
            OdataContext = odataContext;
            Value = value;
        }

        /// <summary> OData context. </summary>
        public string OdataContext { get; }
        /// <summary> The dataflow transactions. </summary>
        public IReadOnlyList<DataflowTransaction> Value { get; }
    }
}
