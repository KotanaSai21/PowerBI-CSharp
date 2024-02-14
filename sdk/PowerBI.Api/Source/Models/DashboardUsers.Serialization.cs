// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Microsoft.PowerBI.Api.Models
{
    public partial class DashboardUsers
    {
        internal static DashboardUsers DeserializeDashboardUsers(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> odataContext = default;
            Optional<IReadOnlyList<DashboardUser>> value = default;
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
                    List<DashboardUser> array = new List<DashboardUser>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DashboardUser.DeserializeDashboardUser(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new DashboardUsers(odataContext.Value, Optional.ToList(value));
        }
    }
}
