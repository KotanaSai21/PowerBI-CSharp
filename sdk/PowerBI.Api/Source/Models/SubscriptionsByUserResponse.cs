// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Microsoft.PowerBI.Api.Models
{
    /// <summary> OData response wrapper for a Power BI subscriptions for user. </summary>
    public partial class SubscriptionsByUserResponse
    {
        /// <summary> Initializes a new instance of <see cref="SubscriptionsByUserResponse"/>. </summary>
        internal SubscriptionsByUserResponse()
        {
            SubscriptionEntities = new ChangeTrackingList<Subscription>();
        }

        /// <summary> Initializes a new instance of <see cref="SubscriptionsByUserResponse"/>. </summary>
        /// <param name="odataContext"></param>
        /// <param name="subscriptionEntities"> The subscriptions for user. </param>
        /// <param name="continuationUri"> The URI for the next chunk in the result set. </param>
        /// <param name="continuationToken"> Token to get the next chunk of the result set. </param>
        internal SubscriptionsByUserResponse(string odataContext, IReadOnlyList<Subscription> subscriptionEntities, string continuationUri, string continuationToken)
        {
            OdataContext = odataContext;
            SubscriptionEntities = subscriptionEntities;
            ContinuationUri = continuationUri;
            ContinuationToken = continuationToken;
        }

        /// <summary> Gets the odata context. </summary>
        public string OdataContext { get; }
        /// <summary> The subscriptions for user. </summary>
        public IReadOnlyList<Subscription> SubscriptionEntities { get; }
        /// <summary> The URI for the next chunk in the result set. </summary>
        public string ContinuationUri { get; }
        /// <summary> Token to get the next chunk of the result set. </summary>
        public string ContinuationToken { get; }
    }
}
