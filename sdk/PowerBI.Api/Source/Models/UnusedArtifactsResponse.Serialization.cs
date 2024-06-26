// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure;

namespace Microsoft.PowerBI.Api.Models
{
    public partial class UnusedArtifactsResponse
    {
        internal static UnusedArtifactsResponse DeserializeUnusedArtifactsResponse(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<UnusedArtifactEntity> unusedArtifactEntities = default;
            string continuationUri = default;
            string continuationToken = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("unusedArtifactEntities"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<UnusedArtifactEntity> array = new List<UnusedArtifactEntity>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(UnusedArtifactEntity.DeserializeUnusedArtifactEntity(item));
                    }
                    unusedArtifactEntities = array;
                    continue;
                }
                if (property.NameEquals("continuationUri"u8))
                {
                    continuationUri = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("continuationToken"u8))
                {
                    continuationToken = property.Value.GetString();
                    continue;
                }
            }
            return new UnusedArtifactsResponse(unusedArtifactEntities ?? new ChangeTrackingList<UnusedArtifactEntity>(), continuationUri, continuationToken);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static UnusedArtifactsResponse FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeUnusedArtifactsResponse(document.RootElement);
        }
    }
}
