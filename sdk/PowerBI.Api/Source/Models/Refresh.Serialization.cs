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
    public partial class Refresh
    {
        internal static Refresh DeserializeRefresh(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            RefreshType? refreshType = default;
            DateTimeOffset? startTime = default;
            DateTimeOffset? endTime = default;
            string serviceExceptionJson = default;
            string status = default;
            string requestId = default;
            IReadOnlyList<RefreshAttempt> refreshAttempts = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("refreshType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    refreshType = property.Value.GetString().ToRefreshType();
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
                if (property.NameEquals("serviceExceptionJson"u8))
                {
                    serviceExceptionJson = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("requestId"u8))
                {
                    requestId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("refreshAttempts"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RefreshAttempt> array = new List<RefreshAttempt>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RefreshAttempt.DeserializeRefreshAttempt(item));
                    }
                    refreshAttempts = array;
                    continue;
                }
            }
            return new Refresh(
                refreshType,
                startTime,
                endTime,
                serviceExceptionJson,
                status,
                requestId,
                refreshAttempts ?? new ChangeTrackingList<RefreshAttempt>());
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static Refresh FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeRefresh(document.RootElement);
        }
    }
}
