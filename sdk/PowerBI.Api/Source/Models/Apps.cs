// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Microsoft.PowerBI.Api.Models
{
    /// <summary> The OData response wrapper for a list of Power BI installed apps. </summary>
    public partial class Apps
    {
        /// <summary> Initializes a new instance of <see cref="Apps"/>. </summary>
        internal Apps()
        {
            Value = new ChangeTrackingList<App>();
        }

        /// <summary> Initializes a new instance of <see cref="Apps"/>. </summary>
        /// <param name="odataContext"> OData context. </param>
        /// <param name="value"> The list of installed apps. </param>
        internal Apps(string odataContext, IReadOnlyList<App> value)
        {
            OdataContext = odataContext;
            Value = value;
        }

        /// <summary> OData context. </summary>
        public string OdataContext { get; }
        /// <summary> The list of installed apps. </summary>
        public IReadOnlyList<App> Value { get; }
    }
}
