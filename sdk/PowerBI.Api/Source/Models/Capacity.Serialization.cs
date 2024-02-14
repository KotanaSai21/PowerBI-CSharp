// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Microsoft.PowerBI.Api.Models
{
    public partial class Capacity
    {
        internal static Capacity DeserializeCapacity(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Guid id = default;
            Optional<string> displayName = default;
            Optional<IReadOnlyList<string>> admins = default;
            Optional<string> sku = default;
            CapacityState state = default;
            CapacityUserAccessRight capacityUserAccessRight = default;
            Optional<string> region = default;
            Optional<Guid> tenantKeyId = default;
            Optional<TenantKey> tenantKey = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("admins"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    admins = array;
                    continue;
                }
                if (property.NameEquals("sku"u8))
                {
                    sku = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    state = property.Value.GetString().ToCapacityState();
                    continue;
                }
                if (property.NameEquals("capacityUserAccessRight"u8))
                {
                    capacityUserAccessRight = property.Value.GetString().ToCapacityUserAccessRight();
                    continue;
                }
                if (property.NameEquals("region"u8))
                {
                    region = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tenantKeyId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tenantKeyId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("tenantKey"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tenantKey = TenantKey.DeserializeTenantKey(property.Value);
                    continue;
                }
            }
            return new Capacity(id, displayName.Value, Optional.ToList(admins), sku.Value, state, capacityUserAccessRight, region.Value, Optional.ToNullable(tenantKeyId), tenantKey.Value);
        }
    }
}
