// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure;

namespace Microsoft.PowerBI.Api.Models
{
    public partial class DatamartUserProperties
    {
        internal static DatamartUserProperties DeserializeDatamartUserProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<DatamartUser> users = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("users"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DatamartUser> array = new List<DatamartUser>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DatamartUser.DeserializeDatamartUser(item));
                    }
                    users = array;
                    continue;
                }
            }
            return new DatamartUserProperties(users ?? new ChangeTrackingList<DatamartUser>());
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static DatamartUserProperties FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeDatamartUserProperties(document.RootElement);
        }
    }
}
