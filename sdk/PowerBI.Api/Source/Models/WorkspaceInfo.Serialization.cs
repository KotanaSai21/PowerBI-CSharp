// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;

namespace Microsoft.PowerBI.Api.Models
{
    public partial class WorkspaceInfo
    {
        internal static WorkspaceInfo DeserializeWorkspaceInfo(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Guid id = default;
            string name = default;
            string description = default;
            string type = default;
            string state = default;
            string dataRetrievalState = default;
            bool? isOnDedicatedCapacity = default;
            string capacityId = default;
            DefaultDatasetStorageFormat? defaultDatasetStorageFormat = default;
            IReadOnlyList<WorkspaceInfoReport> reports = default;
            IReadOnlyList<WorkspaceInfoDashboard> dashboards = default;
            IReadOnlyList<WorkspaceInfoDataset> datasets = default;
            IReadOnlyList<WorkspaceInfoDataflow> dataflows = default;
            IReadOnlyList<WorkspaceInfoDatamart> datamarts = default;
            IReadOnlyList<GroupUser> users = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    state = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataRetrievalState"u8))
                {
                    dataRetrievalState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isOnDedicatedCapacity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isOnDedicatedCapacity = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("capacityId"u8))
                {
                    capacityId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("defaultDatasetStorageFormat"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    defaultDatasetStorageFormat = new DefaultDatasetStorageFormat(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("reports"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<WorkspaceInfoReport> array = new List<WorkspaceInfoReport>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(WorkspaceInfoReport.DeserializeWorkspaceInfoReport(item));
                    }
                    reports = array;
                    continue;
                }
                if (property.NameEquals("dashboards"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<WorkspaceInfoDashboard> array = new List<WorkspaceInfoDashboard>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(WorkspaceInfoDashboard.DeserializeWorkspaceInfoDashboard(item));
                    }
                    dashboards = array;
                    continue;
                }
                if (property.NameEquals("datasets"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<WorkspaceInfoDataset> array = new List<WorkspaceInfoDataset>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(WorkspaceInfoDataset.DeserializeWorkspaceInfoDataset(item));
                    }
                    datasets = array;
                    continue;
                }
                if (property.NameEquals("dataflows"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<WorkspaceInfoDataflow> array = new List<WorkspaceInfoDataflow>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(WorkspaceInfoDataflow.DeserializeWorkspaceInfoDataflow(item));
                    }
                    dataflows = array;
                    continue;
                }
                if (property.NameEquals("datamarts"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<WorkspaceInfoDatamart> array = new List<WorkspaceInfoDatamart>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(WorkspaceInfoDatamart.DeserializeWorkspaceInfoDatamart(item));
                    }
                    datamarts = array;
                    continue;
                }
                if (property.NameEquals("users"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<GroupUser> array = new List<GroupUser>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(GroupUser.DeserializeGroupUser(item));
                    }
                    users = array;
                    continue;
                }
            }
            return new WorkspaceInfo(
                id,
                name,
                description,
                type,
                state,
                dataRetrievalState,
                isOnDedicatedCapacity,
                capacityId,
                defaultDatasetStorageFormat,
                reports ?? new ChangeTrackingList<WorkspaceInfoReport>(),
                dashboards ?? new ChangeTrackingList<WorkspaceInfoDashboard>(),
                datasets ?? new ChangeTrackingList<WorkspaceInfoDataset>(),
                dataflows ?? new ChangeTrackingList<WorkspaceInfoDataflow>(),
                datamarts ?? new ChangeTrackingList<WorkspaceInfoDatamart>(),
                users ?? new ChangeTrackingList<GroupUser>());
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static WorkspaceInfo FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeWorkspaceInfo(document.RootElement);
        }
    }
}