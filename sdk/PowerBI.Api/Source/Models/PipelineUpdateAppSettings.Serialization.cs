// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Microsoft.PowerBI.Api.Models
{
    public partial class PipelineUpdateAppSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(UpdateAppInTargetWorkspace))
            {
                writer.WritePropertyName("updateAppInTargetWorkspace"u8);
                writer.WriteBooleanValue(UpdateAppInTargetWorkspace.Value);
            }
            writer.WriteEndObject();
        }
    }
}
