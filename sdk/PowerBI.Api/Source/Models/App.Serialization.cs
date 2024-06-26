// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure;

namespace Microsoft.PowerBI.Api.Models
{
    public partial class App
    {
        internal static App DeserializeApp(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Guid id = default;
            string name = default;
            string description = default;
            DateTimeOffset? lastUpdate = default;
            string publishedBy = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastUpdate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastUpdate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("publishedBy"u8))
                {
                    publishedBy = property.Value.GetString();
                    continue;
                }
            }
            return new App(id, name, description, lastUpdate, publishedBy);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static App FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeApp(document.RootElement);
        }
    }
}
