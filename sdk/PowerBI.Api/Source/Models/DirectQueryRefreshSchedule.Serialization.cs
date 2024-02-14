// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Microsoft.PowerBI.Api.Models
{
    public partial class DirectQueryRefreshSchedule : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Frequency))
            {
                writer.WritePropertyName("frequency"u8);
                writer.WriteNumberValue(Frequency.Value);
            }
            if (Optional.IsCollectionDefined(Days))
            {
                writer.WritePropertyName("days"u8);
                writer.WriteStartArray();
                foreach (var item in Days)
                {
                    writer.WriteStringValue(item.ToSerialString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Times))
            {
                writer.WritePropertyName("times"u8);
                writer.WriteStartArray();
                foreach (var item in Times)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(LocalTimeZoneId))
            {
                writer.WritePropertyName("localTimeZoneId"u8);
                writer.WriteStringValue(LocalTimeZoneId);
            }
            writer.WriteEndObject();
        }

        internal static DirectQueryRefreshSchedule DeserializeDirectQueryRefreshSchedule(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> frequency = default;
            Optional<IList<Days>> days = default;
            Optional<IList<string>> times = default;
            Optional<string> localTimeZoneId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("frequency"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    frequency = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("days"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<Days> array = new List<Days>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString().ToDays());
                    }
                    days = array;
                    continue;
                }
                if (property.NameEquals("times"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    times = array;
                    continue;
                }
                if (property.NameEquals("localTimeZoneId"u8))
                {
                    localTimeZoneId = property.Value.GetString();
                    continue;
                }
            }
            return new DirectQueryRefreshSchedule(Optional.ToNullable(frequency), Optional.ToList(days), Optional.ToList(times), localTimeZoneId.Value);
        }
    }
}
