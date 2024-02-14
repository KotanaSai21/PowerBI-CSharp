// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Microsoft.PowerBI.Api.Models
{
    public partial class DatamartAuthoringProperties
    {
        internal static DatamartAuthoringProperties DeserializeDatamartAuthoringProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> modifiedBy = default;
            Optional<DateTimeOffset> modifiedDateTime = default;
            Optional<string> configuredBy = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("modifiedBy"u8))
                {
                    modifiedBy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("modifiedDateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    modifiedDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("configuredBy"u8))
                {
                    configuredBy = property.Value.GetString();
                    continue;
                }
            }
            return new DatamartAuthoringProperties(modifiedBy.Value, Optional.ToNullable(modifiedDateTime), configuredBy.Value);
        }
    }
}
