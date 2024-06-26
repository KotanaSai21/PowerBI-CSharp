// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure;

namespace Microsoft.PowerBI.Api.Models
{
    public partial class PipelineStageArtifactBase
    {
        internal static PipelineStageArtifactBase DeserializePipelineStageArtifactBase(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Guid artifactId = default;
            string artifactDisplayName = default;
            Guid? sourceArtifactId = default;
            Guid? targetArtifactId = default;
            DateTimeOffset? lastDeploymentTime = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("artifactId"u8))
                {
                    artifactId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("artifactDisplayName"u8))
                {
                    artifactDisplayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceArtifactId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceArtifactId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("targetArtifactId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetArtifactId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("lastDeploymentTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastDeploymentTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new PipelineStageArtifactBase(artifactId, artifactDisplayName, sourceArtifactId, targetArtifactId, lastDeploymentTime);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static PipelineStageArtifactBase FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializePipelineStageArtifactBase(document.RootElement);
        }
    }
}
