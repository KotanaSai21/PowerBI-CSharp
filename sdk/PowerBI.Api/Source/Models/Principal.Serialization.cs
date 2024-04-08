// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;
using Azure.Core;

namespace Microsoft.PowerBI.Api.Models
{
    public partial class Principal : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("identifier"u8);
            writer.WriteStringValue(Identifier);
            writer.WritePropertyName("principalType"u8);
            writer.WriteStringValue(PrincipalType.ToSerialString());
            writer.WriteEndObject();
        }

        internal static Principal DeserializePrincipal(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string identifier = default;
            PrincipalType principalType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("identifier"u8))
                {
                    identifier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("principalType"u8))
                {
                    principalType = property.Value.GetString().ToPrincipalType();
                    continue;
                }
            }
            return new Principal(identifier, principalType);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static Principal FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializePrincipal(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue<Principal>(this);
            return content;
        }
    }
}
