// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;
using Azure.Core;

namespace Microsoft.PowerBI.Api.Models
{
    public partial class Role : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            if (Optional.IsDefined(ModelPermission))
            {
                writer.WritePropertyName("modelPermission"u8);
                writer.WriteStringValue(ModelPermission);
            }
            if (Optional.IsDefined(Members))
            {
                writer.WritePropertyName("members"u8);
                writer.WriteObjectValue<RoleMember>(Members);
            }
            if (Optional.IsDefined(TablePermissions))
            {
                writer.WritePropertyName("tablePermissions"u8);
                writer.WriteObjectValue<RoleTablePermission>(TablePermissions);
            }
            writer.WriteEndObject();
        }

        internal static Role DeserializeRole(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            string modelPermission = default;
            RoleMember members = default;
            RoleTablePermission tablePermissions = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("modelPermission"u8))
                {
                    modelPermission = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("members"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    members = RoleMember.DeserializeRoleMember(property.Value);
                    continue;
                }
                if (property.NameEquals("tablePermissions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tablePermissions = RoleTablePermission.DeserializeRoleTablePermission(property.Value);
                    continue;
                }
            }
            return new Role(name, modelPermission, members, tablePermissions);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static Role FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeRole(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue<Role>(this);
            return content;
        }
    }
}