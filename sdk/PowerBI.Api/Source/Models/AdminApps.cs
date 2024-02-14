// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Microsoft.PowerBI.Api.Models
{
    /// <summary> The OData response wrapper for a list of Power BI installed apps for Admin APIs. </summary>
    public partial class AdminApps
    {
        /// <summary> Initializes a new instance of <see cref="AdminApps"/>. </summary>
        internal AdminApps()
        {
            Value = new ChangeTrackingList<AdminApp>();
        }

        /// <summary> Initializes a new instance of <see cref="AdminApps"/>. </summary>
        /// <param name="odataContext"> OData context. </param>
        /// <param name="value"> The list of installed apps. </param>
        internal AdminApps(string odataContext, IReadOnlyList<AdminApp> value)
        {
            OdataContext = odataContext;
            Value = value;
        }

        /// <summary> OData context. </summary>
        public string OdataContext { get; }
        /// <summary> The list of installed apps. </summary>
        public IReadOnlyList<AdminApp> Value { get; }
    }
}
