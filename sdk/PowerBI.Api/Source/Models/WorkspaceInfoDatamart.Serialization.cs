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
    public partial class WorkspaceInfoDatamart
    {
        internal static WorkspaceInfoDatamart DeserializeWorkspaceInfoDatamart(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            EndorsementDetails endorsementDetails = default;
            SensitivityLabel sensitivityLabel = default;
            string modifiedBy = default;
            DateTimeOffset? modifiedDateTime = default;
            string configuredBy = default;
            string modifiedById = default;
            string configuredById = default;
            IReadOnlyList<DependentDataflow> upstreamDataflows = default;
            IReadOnlyList<DependentDatamart> upstreamDatamarts = default;
            IReadOnlyList<DatasourceUsage> datasourceUsages = default;
            IReadOnlyList<DatamartUser> users = default;
            Guid id = default;
            string name = default;
            string description = default;
            DatamartType? type = default;
            DatamartStatus? status = default;
            DatamartState? state = default;
            string suspendedBatchId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("endorsementDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endorsementDetails = EndorsementDetails.DeserializeEndorsementDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("sensitivityLabel"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sensitivityLabel = SensitivityLabel.DeserializeSensitivityLabel(property.Value);
                    continue;
                }
                if (property.NameEquals("modifiedBy"u8))
                {
                    modifiedBy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("modifiedDateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    modifiedDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("configuredBy"u8))
                {
                    configuredBy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("modifiedById"u8))
                {
                    modifiedById = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("configuredById"u8))
                {
                    configuredById = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("upstreamDataflows"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DependentDataflow> array = new List<DependentDataflow>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DependentDataflow.DeserializeDependentDataflow(item));
                    }
                    upstreamDataflows = array;
                    continue;
                }
                if (property.NameEquals("upstreamDatamarts"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DependentDatamart> array = new List<DependentDatamart>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DependentDatamart.DeserializeDependentDatamart(item));
                    }
                    upstreamDatamarts = array;
                    continue;
                }
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
                if (property.NameEquals("users"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DatamartUser> array = new List<DatamartUser>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DatamartUser.DeserializeDatamartUser(item));
                    }
                    users = array;
                    continue;
                }
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
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = property.Value.GetString().ToDatamartType();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = property.Value.GetString().ToDatamartStatus();
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = property.Value.GetString().ToDatamartState();
                    continue;
                }
                if (property.NameEquals("suspendedBatchId"u8))
                {
                    suspendedBatchId = property.Value.GetString();
                    continue;
                }
            }
            return new WorkspaceInfoDatamart(
                id,
                name,
                description,
                type,
                status,
                state,
                suspendedBatchId,
                endorsementDetails,
                sensitivityLabel,
                modifiedBy,
                modifiedDateTime,
                configuredBy,
                modifiedById,
                configuredById,
                upstreamDataflows ?? new ChangeTrackingList<DependentDataflow>(),
                upstreamDatamarts ?? new ChangeTrackingList<DependentDatamart>(),
                datasourceUsages ?? new ChangeTrackingList<DatasourceUsage>(),
                users ?? new ChangeTrackingList<DatamartUser>());
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new WorkspaceInfoDatamart FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeWorkspaceInfoDatamart(document.RootElement);
        }
    }
}
