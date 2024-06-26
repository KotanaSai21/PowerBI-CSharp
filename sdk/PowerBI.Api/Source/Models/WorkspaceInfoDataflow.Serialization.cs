// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Microsoft.PowerBI.Api.Models
{
    public partial class WorkspaceInfoDataflow : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(DatasourceUsages))
            {
                writer.WritePropertyName("datasourceUsages"u8);
                writer.WriteStartArray();
                foreach (var item in DatasourceUsages)
                {
                    writer.WriteObjectValue<DatasourceUsage>(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(MisconfiguredDatasourceUsages))
            {
                writer.WritePropertyName("misconfiguredDatasourceUsages"u8);
                writer.WriteStartArray();
                foreach (var item in MisconfiguredDatasourceUsages)
                {
                    writer.WriteObjectValue<DatasourceUsage>(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(UpstreamDataflows))
            {
                writer.WritePropertyName("upstreamDataflows"u8);
                writer.WriteStartArray();
                foreach (var item in UpstreamDataflows)
                {
                    writer.WriteObjectValue<DependentDataflow>(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(UpstreamDatamart))
            {
                writer.WritePropertyName("upstreamDatamart"u8);
                writer.WriteStartArray();
                foreach (var item in UpstreamDatamart)
                {
                    writer.WriteObjectValue<DependentDatamarts>(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(EndorsementDetails))
            {
                writer.WritePropertyName("endorsementDetails"u8);
                writer.WriteObjectValue<EndorsementDetails>(EndorsementDetails);
            }
            if (Optional.IsDefined(SensitivityLabel))
            {
                writer.WritePropertyName("sensitivityLabel"u8);
                writer.WriteObjectValue<SensitivityLabel>(SensitivityLabel);
            }
            writer.WritePropertyName("objectId"u8);
            writer.WriteStringValue(ObjectId);
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(ModelUrl))
            {
                writer.WritePropertyName("modelUrl"u8);
                writer.WriteStringValue(ModelUrl);
            }
            if (Optional.IsDefined(ConfiguredBy))
            {
                writer.WritePropertyName("configuredBy"u8);
                writer.WriteStringValue(ConfiguredBy);
            }
            if (Optional.IsDefined(ModifiedBy))
            {
                writer.WritePropertyName("modifiedBy"u8);
                writer.WriteStringValue(ModifiedBy);
            }
            if (Optional.IsDefined(ModifiedDateTime))
            {
                writer.WritePropertyName("modifiedDateTime"u8);
                writer.WriteStringValue(ModifiedDateTime.Value, "O");
            }
            if (Optional.IsCollectionDefined(Users))
            {
                writer.WritePropertyName("users"u8);
                writer.WriteStartArray();
                foreach (var item in Users)
                {
                    writer.WriteObjectValue<DataflowUser>(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static WorkspaceInfoDataflow DeserializeWorkspaceInfoDataflow(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<DatasourceUsage> datasourceUsages = default;
            IList<DatasourceUsage> misconfiguredDatasourceUsages = default;
            IList<DependentDataflow> upstreamDataflows = default;
            IList<DependentDatamarts> upstreamDatamart = default;
            EndorsementDetails endorsementDetails = default;
            SensitivityLabel sensitivityLabel = default;
            Guid objectId = default;
            string name = default;
            string description = default;
            string modelUrl = default;
            string configuredBy = default;
            string modifiedBy = default;
            DateTimeOffset? modifiedDateTime = default;
            IList<DataflowUser> users = default;
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
                if (property.NameEquals("misconfiguredDatasourceUsages"u8))
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
                    misconfiguredDatasourceUsages = array;
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
                if (property.NameEquals("upstreamDatamart"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DependentDatamarts> array = new List<DependentDatamarts>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DependentDatamarts.DeserializeDependentDatamarts(item));
                    }
                    upstreamDatamart = array;
                    continue;
                }
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
                if (property.NameEquals("objectId"u8))
                {
                    objectId = property.Value.GetGuid();
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
                if (property.NameEquals("modelUrl"u8))
                {
                    modelUrl = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("configuredBy"u8))
                {
                    configuredBy = property.Value.GetString();
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
                if (property.NameEquals("users"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataflowUser> array = new List<DataflowUser>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataflowUser.DeserializeDataflowUser(item));
                    }
                    users = array;
                    continue;
                }
            }
            return new WorkspaceInfoDataflow(
                objectId,
                name,
                description,
                modelUrl,
                configuredBy,
                modifiedBy,
                modifiedDateTime,
                users ?? new ChangeTrackingList<DataflowUser>(),
                datasourceUsages ?? new ChangeTrackingList<DatasourceUsage>(),
                misconfiguredDatasourceUsages ?? new ChangeTrackingList<DatasourceUsage>(),
                upstreamDataflows ?? new ChangeTrackingList<DependentDataflow>(),
                upstreamDatamart ?? new ChangeTrackingList<DependentDatamarts>(),
                endorsementDetails,
                sensitivityLabel);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new WorkspaceInfoDataflow FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeWorkspaceInfoDataflow(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue<WorkspaceInfoDataflow>(this);
            return content;
        }
    }
}
