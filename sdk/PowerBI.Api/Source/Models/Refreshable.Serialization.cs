// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;

namespace Microsoft.PowerBI.Api.Models
{
    public partial class Refreshable
    {
        internal static Refreshable DeserializeRefreshable(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            string name = default;
            RefreshableKind? kind = default;
            DateTimeOffset? startTime = default;
            DateTimeOffset? endTime = default;
            int? refreshCount = default;
            int? refreshFailures = default;
            float? averageDuration = default;
            float? medianDuration = default;
            int? refreshesPerDay = default;
            Refresh lastRefresh = default;
            RefreshSchedule refreshSchedule = default;
            IReadOnlyList<string> configuredBy = default;
            Capacity capacity = default;
            RefreshableGroup group = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    kind = new RefreshableKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("startTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("refreshCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    refreshCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("refreshFailures"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    refreshFailures = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("averageDuration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    averageDuration = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("medianDuration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    medianDuration = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("refreshesPerDay"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    refreshesPerDay = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("lastRefresh"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastRefresh = Refresh.DeserializeRefresh(property.Value);
                    continue;
                }
                if (property.NameEquals("refreshSchedule"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    refreshSchedule = RefreshSchedule.DeserializeRefreshSchedule(property.Value);
                    continue;
                }
                if (property.NameEquals("configuredBy"u8))
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
                    configuredBy = array;
                    continue;
                }
                if (property.NameEquals("capacity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    capacity = Capacity.DeserializeCapacity(property.Value);
                    continue;
                }
                if (property.NameEquals("group"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    group = RefreshableGroup.DeserializeRefreshableGroup(property.Value);
                    continue;
                }
            }
            return new Refreshable(
                id,
                name,
                kind,
                startTime,
                endTime,
                refreshCount,
                refreshFailures,
                averageDuration,
                medianDuration,
                refreshesPerDay,
                lastRefresh,
                refreshSchedule,
                configuredBy ?? new ChangeTrackingList<string>(),
                capacity,
                group);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static Refreshable FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeRefreshable(document.RootElement);
        }
    }
}
