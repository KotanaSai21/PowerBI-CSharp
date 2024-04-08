// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;
using Azure.Core;

namespace Microsoft.PowerBI.Api.Models
{
    public partial class GoalsRulesFieldComparison : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Field))
            {
                writer.WritePropertyName("field"u8);
                writer.WriteStringValue(Field);
            }
            if (Optional.IsDefined(Operator))
            {
                writer.WritePropertyName("operator"u8);
                writer.WriteStringValue(Operator.Value.ToSerialString());
            }
            if (Optional.IsDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteObjectValue<GoalsRulesRuleValue>(Value);
            }
            writer.WriteEndObject();
        }

        internal static GoalsRulesFieldComparison DeserializeGoalsRulesFieldComparison(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string field = default;
            GoalRulesFieldComparisonKind? @operator = default;
            GoalsRulesRuleValue value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("field"u8))
                {
                    field = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("operator"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    @operator = property.Value.GetString().ToGoalRulesFieldComparisonKind();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    value = GoalsRulesRuleValue.DeserializeGoalsRulesRuleValue(property.Value);
                    continue;
                }
            }
            return new GoalsRulesFieldComparison(field, @operator, value);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static GoalsRulesFieldComparison FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeGoalsRulesFieldComparison(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue<GoalsRulesFieldComparison>(this);
            return content;
        }
    }
}
