// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Microsoft.PowerBI.Api.Models
{
    public partial class PipelineUsersProperties
    {
        internal static PipelineUsersProperties DeserializePipelineUsersProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<PipelineUser>> users = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("users"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PipelineUser> array = new List<PipelineUser>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PipelineUser.DeserializePipelineUser(item));
                    }
                    users = array;
                    continue;
                }
            }
            return new PipelineUsersProperties(Optional.ToList(users));
        }
    }
}
