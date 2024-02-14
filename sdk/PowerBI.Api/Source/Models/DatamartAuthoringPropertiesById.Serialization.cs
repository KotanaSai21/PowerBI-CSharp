// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Microsoft.PowerBI.Api.Models
{
    public partial class DatamartAuthoringPropertiesById
    {
        internal static DatamartAuthoringPropertiesById DeserializeDatamartAuthoringPropertiesById(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> modifiedById = default;
            Optional<string> configuredById = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("modifiedById"u8))
                {
                    modifiedById = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("configuredById"u8))
                {
                    configuredById = property.Value.GetString();
                    continue;
                }
            }
            return new DatamartAuthoringPropertiesById(modifiedById.Value, configuredById.Value);
        }
    }
}
