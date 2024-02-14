// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Microsoft.PowerBI.Api.Models
{
    public partial class DatasetUsers
    {
        internal static DatasetUsers DeserializeDatasetUsers(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> odataContext = default;
            Optional<IReadOnlyList<DatasetUser>> value = default;
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
                    List<DatasetUser> array = new List<DatasetUser>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DatasetUser.DeserializeDatasetUser(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new DatasetUsers(odataContext.Value, Optional.ToList(value));
        }
    }
}
