// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Microsoft.PowerBI.Api.Models
{
    /// <summary> The SubscriptionProperties. </summary>
    public partial class SubscriptionProperties
    {
        /// <summary> Initializes a new instance of <see cref="SubscriptionProperties"/>. </summary>
        public SubscriptionProperties()
        {
            Subscriptions = new ChangeTrackingList<Subscription>();
        }

        /// <summary> Initializes a new instance of <see cref="SubscriptionProperties"/>. </summary>
        /// <param name="subscriptions"> (Empty Value) The subscription details for a Power BI item (such as a report or a dashboard). This property will be removed from the payload response in an upcoming release. You can retrieve subscription information for a Power BI report by using the [Get Report Subscriptions as Admin](/rest/api/power-bi/admin/reports-get-report-subscriptions-as-admin) API call. </param>
        internal SubscriptionProperties(IList<Subscription> subscriptions)
        {
            Subscriptions = subscriptions;
        }

        /// <summary> (Empty Value) The subscription details for a Power BI item (such as a report or a dashboard). This property will be removed from the payload response in an upcoming release. You can retrieve subscription information for a Power BI report by using the [Get Report Subscriptions as Admin](/rest/api/power-bi/admin/reports-get-report-subscriptions-as-admin) API call. </summary>
        public IList<Subscription> Subscriptions { get; }
    }
}
