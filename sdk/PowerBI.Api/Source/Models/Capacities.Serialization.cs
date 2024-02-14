// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Microsoft.PowerBI.Api.Models
{
    public partial class Capacities
    {
        internal static Capacities DeserializeCapacities(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> odataContext = default;
            Optional<IReadOnlyList<Capacity>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("odata.context"u8))
                {
                    odataContext = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<Capacity> array = new List<Capacity>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Capacity.DeserializeCapacity(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new Capacities(odataContext.Value, Optional.ToList(value));
        }
    }
}
