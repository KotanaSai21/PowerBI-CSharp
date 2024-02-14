// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Microsoft.PowerBI.Api.Models
{
    public partial class GoalRefreshHistory
    {
        internal static GoalRefreshHistory DeserializeGoalRefreshHistory(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Guid> goalId = default;
            Optional<GoalValueType> connectionType = default;
            Optional<GoalProcessingStatus> status = default;
            Optional<DateTimeOffset> timestamp = default;
            Optional<Guid> rootActivityId = default;
            Optional<string> message = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("goalId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    goalId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("connectionType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    connectionType = property.Value.GetString().ToGoalValueType();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = property.Value.GetString().ToGoalProcessingStatus();
                    continue;
                }
                if (property.NameEquals("timestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("rootActivityId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rootActivityId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
            }
            return new GoalRefreshHistory(Optional.ToNullable(goalId), Optional.ToNullable(connectionType), Optional.ToNullable(status), Optional.ToNullable(timestamp), Optional.ToNullable(rootActivityId), message.Value);
        }
    }
}
