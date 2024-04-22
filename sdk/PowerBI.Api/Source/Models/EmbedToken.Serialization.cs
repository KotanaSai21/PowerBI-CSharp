// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure;

namespace Microsoft.PowerBI.Api.Models
{
    public partial class EmbedToken
    {
        internal static EmbedToken DeserializeEmbedToken(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string token = default;
            Guid tokenId = default;
            DateTimeOffset expiration = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("token"u8))
                {
                    token = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tokenId"u8))
                {
                    tokenId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("expiration"u8))
                {
                    expiration = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new EmbedToken(token, tokenId, expiration);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static EmbedToken FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeEmbedToken(document.RootElement);
        }
    }
}