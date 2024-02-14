// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Microsoft.PowerBI.Api.Models
{
    public partial class SourceReport : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("sourceReportId"u8);
            writer.WriteStringValue(SourceReportId);
            if (Optional.IsDefined(SourceWorkspaceId))
            {
                writer.WritePropertyName("sourceWorkspaceId"u8);
                writer.WriteStringValue(SourceWorkspaceId.Value);
            }
            writer.WriteEndObject();
        }
    }
}
