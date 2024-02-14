// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;

namespace Microsoft.PowerBI.Api.Models
{
    public partial class PreDeploymentDiffInformation
    {
        internal static PreDeploymentDiffInformation DeserializePreDeploymentDiffInformation(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int newArtifactsCount = default;
            int differentArtifactsCount = default;
            int noDifferenceArtifactsCount = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("newArtifactsCount"u8))
                {
                    newArtifactsCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("differentArtifactsCount"u8))
                {
                    differentArtifactsCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("noDifferenceArtifactsCount"u8))
                {
                    noDifferenceArtifactsCount = property.Value.GetInt32();
                    continue;
                }
            }
            return new PreDeploymentDiffInformation(newArtifactsCount, differentArtifactsCount, noDifferenceArtifactsCount);
        }
    }
}
