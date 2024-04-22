// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;

namespace Microsoft.PowerBI.Api.Models
{
    public partial class ArtifactAccessEntry
    {
        internal static ArtifactAccessEntry DeserializeArtifactAccessEntry(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string artifactId = default;
            string displayName = default;
            ArtifactType artifactType = default;
            string accessRight = default;
            string shareType = default;
            User sharer = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("artifactId"u8))
                {
                    artifactId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("artifactType"u8))
                {
                    artifactType = property.Value.GetString().ToArtifactType();
                    continue;
                }
                if (property.NameEquals("accessRight"u8))
                {
                    accessRight = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("shareType"u8))
                {
                    shareType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sharer"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sharer = User.DeserializeUser(property.Value);
                    continue;
                }
            }
            return new ArtifactAccessEntry(
                artifactId,
                displayName,
                artifactType,
                accessRight,
                shareType,
                sharer);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static ArtifactAccessEntry FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeArtifactAccessEntry(document.RootElement);
        }
    }
}