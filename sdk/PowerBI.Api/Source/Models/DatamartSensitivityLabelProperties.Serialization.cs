// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;

namespace Microsoft.PowerBI.Api.Models
{
    public partial class DatamartSensitivityLabelProperties
    {
        internal static DatamartSensitivityLabelProperties DeserializeDatamartSensitivityLabelProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SensitivityLabel sensitivityLabel = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sensitivityLabel"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sensitivityLabel = SensitivityLabel.DeserializeSensitivityLabel(property.Value);
                    continue;
                }
            }
            return new DatamartSensitivityLabelProperties(sensitivityLabel);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static DatamartSensitivityLabelProperties FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeDatamartSensitivityLabelProperties(document.RootElement);
        }
    }
}
