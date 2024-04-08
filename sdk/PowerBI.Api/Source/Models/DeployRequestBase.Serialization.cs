// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Microsoft.PowerBI.Api.Models
{
    public partial class DeployRequestBase : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("sourceStageOrder"u8);
            writer.WriteNumberValue(SourceStageOrder);
            if (Optional.IsDefined(IsBackwardDeployment))
            {
                writer.WritePropertyName("isBackwardDeployment"u8);
                writer.WriteBooleanValue(IsBackwardDeployment.Value);
            }
            if (Optional.IsDefined(NewWorkspace))
            {
                writer.WritePropertyName("newWorkspace"u8);
                writer.WriteObjectValue<PipelineNewWorkspaceRequest>(NewWorkspace);
            }
            if (Optional.IsDefined(UpdateAppSettings))
            {
                writer.WritePropertyName("updateAppSettings"u8);
                writer.WriteObjectValue<PipelineUpdateAppSettings>(UpdateAppSettings);
            }
            if (Optional.IsDefined(Options))
            {
                writer.WritePropertyName("options"u8);
                writer.WriteObjectValue<DeploymentOptions>(Options);
            }
            if (Optional.IsDefined(Note))
            {
                writer.WritePropertyName("note"u8);
                writer.WriteStringValue(Note);
            }
            writer.WriteEndObject();
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue<DeployRequestBase>(this);
            return content;
        }
    }
}
