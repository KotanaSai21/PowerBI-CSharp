// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;
using Azure.Core;

namespace Microsoft.PowerBI.Api.Models
{
    public partial class DatasetSecurityProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(IsEffectiveIdentityRequired))
            {
                writer.WritePropertyName("IsEffectiveIdentityRequired"u8);
                writer.WriteBooleanValue(IsEffectiveIdentityRequired.Value);
            }
            if (Optional.IsDefined(IsEffectiveIdentityRolesRequired))
            {
                writer.WritePropertyName("IsEffectiveIdentityRolesRequired"u8);
                writer.WriteBooleanValue(IsEffectiveIdentityRolesRequired.Value);
            }
            if (Optional.IsDefined(IsOnPremGatewayRequired))
            {
                writer.WritePropertyName("IsOnPremGatewayRequired"u8);
                writer.WriteBooleanValue(IsOnPremGatewayRequired.Value);
            }
            if (Optional.IsDefined(Encryption))
            {
                writer.WritePropertyName("Encryption"u8);
                writer.WriteObjectValue<Encryption>(Encryption);
            }
            writer.WriteEndObject();
        }

        internal static DatasetSecurityProperties DeserializeDatasetSecurityProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? isEffectiveIdentityRequired = default;
            bool? isEffectiveIdentityRolesRequired = default;
            bool? isOnPremGatewayRequired = default;
            Encryption encryption = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("IsEffectiveIdentityRequired"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isEffectiveIdentityRequired = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("IsEffectiveIdentityRolesRequired"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isEffectiveIdentityRolesRequired = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("IsOnPremGatewayRequired"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isOnPremGatewayRequired = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("Encryption"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    encryption = Encryption.DeserializeEncryption(property.Value);
                    continue;
                }
            }
            return new DatasetSecurityProperties(isEffectiveIdentityRequired, isEffectiveIdentityRolesRequired, isOnPremGatewayRequired, encryption);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static DatasetSecurityProperties FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeDatasetSecurityProperties(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue<DatasetSecurityProperties>(this);
            return content;
        }
    }
}
