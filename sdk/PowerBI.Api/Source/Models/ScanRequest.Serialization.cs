// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure;

namespace Microsoft.PowerBI.Api.Models
{
    public partial class ScanRequest
    {
        internal static ScanRequest DeserializeScanRequest(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Guid? id = default;
            DateTimeOffset? createdDateTime = default;
            string status = default;
            PowerBIApiErrorResponseDetail error = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("createdDateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createdDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    error = PowerBIApiErrorResponseDetail.DeserializePowerBIApiErrorResponseDetail(property.Value);
                    continue;
                }
            }
            return new ScanRequest(id, createdDateTime, status, error);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static ScanRequest FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeScanRequest(document.RootElement);
        }
    }
}