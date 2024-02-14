// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Microsoft.PowerBI.Api.Models
{
    public partial class DatasetStorageMode : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(TargetStorageMode))
            {
                writer.WritePropertyName("targetStorageMode"u8);
                writer.WriteStringValue(TargetStorageMode);
            }
            writer.WriteEndObject();
        }

        internal static DatasetStorageMode DeserializeDatasetStorageMode(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> targetStorageMode = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("targetStorageMode"u8))
                {
                    targetStorageMode = property.Value.GetString();
                    continue;
                }
            }
            return new DatasetStorageMode(targetStorageMode.Value);
        }
    }
}
