// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;
using Azure.Core;

namespace Microsoft.PowerBI.Api.Models
{
    public partial class DatasetQueryScaleOutSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(AutoSyncReadOnlyReplicas))
            {
                writer.WritePropertyName("autoSyncReadOnlyReplicas"u8);
                writer.WriteBooleanValue(AutoSyncReadOnlyReplicas.Value);
            }
            if (Optional.IsDefined(MaxReadOnlyReplicas))
            {
                writer.WritePropertyName("maxReadOnlyReplicas"u8);
                writer.WriteNumberValue(MaxReadOnlyReplicas.Value);
            }
            writer.WriteEndObject();
        }

        internal static DatasetQueryScaleOutSettings DeserializeDatasetQueryScaleOutSettings(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? autoSyncReadOnlyReplicas = default;
            int? maxReadOnlyReplicas = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("autoSyncReadOnlyReplicas"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    autoSyncReadOnlyReplicas = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("maxReadOnlyReplicas"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxReadOnlyReplicas = property.Value.GetInt32();
                    continue;
                }
            }
            return new DatasetQueryScaleOutSettings(autoSyncReadOnlyReplicas, maxReadOnlyReplicas);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static DatasetQueryScaleOutSettings FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeDatasetQueryScaleOutSettings(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue<DatasetQueryScaleOutSettings>(this);
            return content;
        }
    }
}