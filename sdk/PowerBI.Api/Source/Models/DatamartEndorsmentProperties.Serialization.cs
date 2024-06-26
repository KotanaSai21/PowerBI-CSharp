// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;

namespace Microsoft.PowerBI.Api.Models
{
    public partial class DatamartEndorsmentProperties
    {
        internal static DatamartEndorsmentProperties DeserializeDatamartEndorsmentProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            EndorsementDetails endorsementDetails = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("endorsementDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endorsementDetails = EndorsementDetails.DeserializeEndorsementDetails(property.Value);
                    continue;
                }
            }
            return new DatamartEndorsmentProperties(endorsementDetails);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static DatamartEndorsmentProperties FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeDatamartEndorsmentProperties(document.RootElement);
        }
    }
}
