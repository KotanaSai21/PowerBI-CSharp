// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure;

namespace Microsoft.PowerBI.Api.Models
{
    public partial class ArtifactAccessResponse
    {
        internal static ArtifactAccessResponse DeserializeArtifactAccessResponse(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string odataContext = default;
            IReadOnlyList<ArtifactAccessEntry> artifactAccessEntities = default;
            string continuationUri = default;
            string continuationToken = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("odata.context"u8))
                {
                    odataContext = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("artifactAccessEntities"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ArtifactAccessEntry> array = new List<ArtifactAccessEntry>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ArtifactAccessEntry.DeserializeArtifactAccessEntry(item));
                    }
                    artifactAccessEntities = array;
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
            return new ArtifactAccessResponse(odataContext, artifactAccessEntities ?? new ChangeTrackingList<ArtifactAccessEntry>(), continuationUri, continuationToken);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static ArtifactAccessResponse FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeArtifactAccessResponse(document.RootElement);
        }
    }
}
