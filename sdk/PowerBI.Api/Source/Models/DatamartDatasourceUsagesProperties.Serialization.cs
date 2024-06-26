// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure;

namespace Microsoft.PowerBI.Api.Models
{
    public partial class DatamartDatasourceUsagesProperties
    {
        internal static DatamartDatasourceUsagesProperties DeserializeDatamartDatasourceUsagesProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<DatasourceUsage> datasourceUsages = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("datasourceUsages"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DatasourceUsage> array = new List<DatasourceUsage>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DatasourceUsage.DeserializeDatasourceUsage(item));
                    }
                    datasourceUsages = array;
                    continue;
                }
            }
            return new DatamartDatasourceUsagesProperties(datasourceUsages ?? new ChangeTrackingList<DatasourceUsage>());
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static DatamartDatasourceUsagesProperties FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeDatamartDatasourceUsagesProperties(document.RootElement);
        }
    }
}
