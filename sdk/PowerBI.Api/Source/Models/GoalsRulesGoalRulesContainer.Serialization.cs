// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Microsoft.PowerBI.Api.Models
{
    public partial class GoalsRulesGoalRulesContainer : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ScorecardObjectId))
            {
                writer.WritePropertyName("scorecardObjectId"u8);
                writer.WriteStringValue(ScorecardObjectId.Value);
            }
            if (Optional.IsDefined(GoalObjectId))
            {
                writer.WritePropertyName("goalObjectId"u8);
                writer.WriteStringValue(GoalObjectId.Value);
            }
            if (Optional.IsDefined(LastModifiedTime))
            {
                writer.WritePropertyName("lastModifiedTime"u8);
                writer.WriteStringValue(LastModifiedTime.Value, "O");
            }
            if (Optional.IsDefined(Rules))
            {
                writer.WritePropertyName("rules"u8);
                writer.WriteStringValue(Rules);
            }
            writer.WriteEndObject();
        }

        internal static GoalsRulesGoalRulesContainer DeserializeGoalsRulesGoalRulesContainer(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Guid? scorecardObjectId = default;
            Guid? goalObjectId = default;
            DateTimeOffset? lastModifiedTime = default;
            string rules = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("scorecardObjectId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scorecardObjectId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("goalObjectId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    goalObjectId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("lastModifiedTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastModifiedTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("rules"u8))
                {
                    rules = property.Value.GetString();
                    continue;
                }
            }
            return new GoalsRulesGoalRulesContainer(scorecardObjectId, goalObjectId, lastModifiedTime, rules);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static GoalsRulesGoalRulesContainer FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeGoalsRulesGoalRulesContainer(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue<GoalsRulesGoalRulesContainer>(this);
            return content;
        }
    }
}
