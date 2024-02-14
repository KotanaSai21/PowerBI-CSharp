// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Microsoft.PowerBI.Api.Models
{
    public partial class AdminServicePrincipalProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ServicePrincipalId))
            {
                writer.WritePropertyName("servicePrincipalId"u8);
                writer.WriteStringValue(ServicePrincipalId.Value);
            }
            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(Id);
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            writer.WriteEndObject();
        }

        internal static AdminServicePrincipalProfile DeserializeAdminServicePrincipalProfile(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Guid> servicePrincipalId = default;
            Guid id = default;
            Optional<string> displayName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("servicePrincipalId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    servicePrincipalId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
            }
            return new AdminServicePrincipalProfile(id, displayName.Value, Optional.ToNullable(servicePrincipalId));
        }
    }
}
