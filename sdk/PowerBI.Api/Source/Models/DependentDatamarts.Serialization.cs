// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;
using Azure.Core;

namespace Microsoft.PowerBI.Api.Models
{
    public partial class DependentDatamarts : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(TargetDatamartId))
            {
                writer.WritePropertyName("targetDatamartId"u8);
                writer.WriteStringValue(TargetDatamartId);
            }
            if (Optional.IsDefined(GroupId))
            {
                writer.WritePropertyName("groupId"u8);
                writer.WriteStringValue(GroupId);
            }
            writer.WriteEndObject();
        }

        internal static DependentDatamarts DeserializeDependentDatamarts(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string targetDatamartId = default;
            string groupId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("targetDatamartId"u8))
                {
                    targetDatamartId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("groupId"u8))
                {
                    groupId = property.Value.GetString();
                    continue;
                }
            }
            return new DependentDatamarts(targetDatamartId, groupId);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static DependentDatamarts FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeDependentDatamarts(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue<DependentDatamarts>(this);
            return content;
        }
    }
}