// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;
using Azure.Core;

namespace Microsoft.PowerBI.Api.Models
{
    public partial class DependentDataflow : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(TargetDataflowId))
            {
                writer.WritePropertyName("targetDataflowId"u8);
                writer.WriteStringValue(TargetDataflowId);
            }
            if (Optional.IsDefined(GroupId))
            {
                writer.WritePropertyName("groupId"u8);
                writer.WriteStringValue(GroupId);
            }
            writer.WriteEndObject();
        }

        internal static DependentDataflow DeserializeDependentDataflow(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string targetDataflowId = default;
            string groupId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("targetDataflowId"u8))
                {
                    targetDataflowId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("groupId"u8))
                {
                    groupId = property.Value.GetString();
                    continue;
                }
            }
            return new DependentDataflow(targetDataflowId, groupId);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static DependentDataflow FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeDependentDataflow(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue<DependentDataflow>(this);
            return content;
        }
    }
}