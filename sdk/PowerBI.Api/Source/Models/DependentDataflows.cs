// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Microsoft.PowerBI.Api.Models
{
    /// <summary> The OData response wrapper for a list of Power BI dependent dataflows. </summary>
    public partial class DependentDataflows
    {
        /// <summary> Initializes a new instance of <see cref="DependentDataflows"/>. </summary>
        internal DependentDataflows()
        {
            Value = new ChangeTrackingList<DependentDataflow>();
        }

        /// <summary> Initializes a new instance of <see cref="DependentDataflows"/>. </summary>
        /// <param name="odataContext"></param>
        /// <param name="value"> The dependent dataflows. </param>
        internal DependentDataflows(string odataContext, IReadOnlyList<DependentDataflow> value)
        {
            OdataContext = odataContext;
            Value = value;
        }

        /// <summary> Gets the odata context. </summary>
        public string OdataContext { get; }
        /// <summary> The dependent dataflows. </summary>
        public IReadOnlyList<DependentDataflow> Value { get; }
    }
}
