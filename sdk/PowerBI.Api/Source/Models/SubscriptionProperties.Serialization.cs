// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Microsoft.PowerBI.Api.Models
{
    public partial class SubscriptionProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Subscriptions))
            {
                writer.WritePropertyName("subscriptions"u8);
                writer.WriteStartArray();
                foreach (var item in Subscriptions)
                {
                    writer.WriteObjectValue<Subscription>(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static SubscriptionProperties DeserializeSubscriptionProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<Subscription> subscriptions = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("subscriptions"u8))
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
                    subscriptions = array;
                    continue;
                }
            }
            return new SubscriptionProperties(subscriptions ?? new ChangeTrackingList<Subscription>());
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static SubscriptionProperties FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeSubscriptionProperties(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue<SubscriptionProperties>(this);
            return content;
        }
    }
}