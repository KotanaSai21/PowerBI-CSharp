// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Microsoft.PowerBI.Api.Models
{
    public partial class SubscriptionsByUserResponse
    {
        internal static SubscriptionsByUserResponse DeserializeSubscriptionsByUserResponse(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> odataContext = default;
            Optional<IReadOnlyList<Subscription>> subscriptionEntities = default;
            Optional<string> continuationUri = default;
            Optional<string> continuationToken = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("odata.context"u8))
                {
                    odataContext = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subscriptionEntities"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<Subscription> array = new List<Subscription>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Subscription.DeserializeSubscription(item));
                    }
                    subscriptionEntities = array;
                    continue;
                }
                if (property.NameEquals("continuationUri"u8))
                {
                    continuationUri = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("continuationToken"u8))
                {
                    continuationToken = property.Value.GetString();
                    continue;
                }
            }
            return new SubscriptionsByUserResponse(odataContext.Value, Optional.ToList(subscriptionEntities), continuationUri.Value, continuationToken.Value);
        }
    }
}
