// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Microsoft.PowerBI.Api.Models
{
    public partial class GenerateTokenRequestV2Dataset : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(Id);
            if (Optional.IsDefined(XmlaPermissions))
            {
                writer.WritePropertyName("xmlaPermissions"u8);
                writer.WriteStringValue(XmlaPermissions.Value.ToSerialString());
            }
            writer.WriteEndObject();
        }
    }
}
