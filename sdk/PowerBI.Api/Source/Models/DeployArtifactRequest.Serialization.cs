// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Microsoft.PowerBI.Api.Models
{
    public partial class DeployArtifactRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("sourceId"u8);
            writer.WriteStringValue(SourceId);
            if (Optional.IsDefined(Options))
            {
                writer.WritePropertyName("options"u8);
                writer.WriteObjectValue(Options);
            }
            writer.WriteEndObject();
        }
    }
}
