// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;

namespace Microsoft.PowerBI.Api.Models
{
    public partial class DataflowTransactionStatus
    {
        internal static DataflowTransactionStatus DeserializeDataflowTransactionStatus(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string transactionId = default;
            DataflowTransactionStatusStatus? status = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("transactionId"u8))
                {
                    transactionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new DataflowTransactionStatusStatus(property.Value.GetString());
                    continue;
                }
            }
            return new DataflowTransactionStatus(transactionId, status);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static DataflowTransactionStatus FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeDataflowTransactionStatus(document.RootElement);
        }
    }
}
