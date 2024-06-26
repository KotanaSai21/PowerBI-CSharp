// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure;

namespace Microsoft.PowerBI.Api.Models
{
    public partial class WorkspaceInfoResponse
    {
        internal static WorkspaceInfoResponse DeserializeWorkspaceInfoResponse(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<WorkspaceInfo> workspaces = default;
            IReadOnlyList<Datasource> datasourceInstances = default;
            IReadOnlyList<Datasource> misconfiguredDatasourceInstances = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("workspaces"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<WorkspaceInfo> array = new List<WorkspaceInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(WorkspaceInfo.DeserializeWorkspaceInfo(item));
                    }
                    workspaces = array;
                    continue;
                }
                if (property.NameEquals("datasourceInstances"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<Datasource> array = new List<Datasource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Datasource.DeserializeDatasource(item));
                    }
                    datasourceInstances = array;
                    continue;
                }
                if (property.NameEquals("misconfiguredDatasourceInstances"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<Datasource> array = new List<Datasource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Datasource.DeserializeDatasource(item));
                    }
                    misconfiguredDatasourceInstances = array;
                    continue;
                }
            }
            return new WorkspaceInfoResponse(workspaces ?? new ChangeTrackingList<WorkspaceInfo>(), datasourceInstances ?? new ChangeTrackingList<Datasource>(), misconfiguredDatasourceInstances ?? new ChangeTrackingList<Datasource>());
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static WorkspaceInfoResponse FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeWorkspaceInfoResponse(document.RootElement);
        }
    }
}
