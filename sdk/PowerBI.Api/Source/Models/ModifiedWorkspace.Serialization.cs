// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure;

namespace Microsoft.PowerBI.Api.Models
{
    public partial class ModifiedWorkspace
    {
        internal static ModifiedWorkspace DeserializeModifiedWorkspace(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Guid id = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("Id"u8))
                {
                    id = property.Value.GetGuid();
                    continue;
                }
            }
            return new ModifiedWorkspace(id);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static ModifiedWorkspace FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeModifiedWorkspace(document.RootElement);
        }
    }
}