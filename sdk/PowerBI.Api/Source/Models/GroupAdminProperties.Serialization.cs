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
    public partial class GroupAdminProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(Type))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(Type.Value.ToSerialString());
            }
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State);
            }
            if (Optional.IsCollectionDefined(Users))
            {
                writer.WritePropertyName("users"u8);
                writer.WriteStartArray();
                foreach (var item in Users)
                {
                    writer.WriteObjectValue<GroupUser>(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Reports))
            {
                writer.WritePropertyName("reports"u8);
                writer.WriteStartArray();
                foreach (var item in Reports)
                {
                    writer.WriteObjectValue<AdminReport>(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Dashboards))
            {
                writer.WritePropertyName("dashboards"u8);
                writer.WriteStartArray();
                foreach (var item in Dashboards)
                {
                    writer.WriteObjectValue<AdminDashboard>(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Datasets))
            {
                writer.WritePropertyName("datasets"u8);
                writer.WriteStartArray();
                foreach (var item in Datasets)
                {
                    writer.WriteObjectValue<AdminDataset>(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Dataflows))
            {
                writer.WritePropertyName("dataflows"u8);
                writer.WriteStartArray();
                foreach (var item in Dataflows)
                {
                    writer.WriteObjectValue<AdminDataflow>(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Workbooks))
            {
                writer.WritePropertyName("workbooks"u8);
                writer.WriteStartArray();
                foreach (var item in Workbooks)
                {
                    writer.WriteObjectValue<Workbook>(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(PipelineId))
            {
                writer.WritePropertyName("pipelineId"u8);
                writer.WriteStringValue(PipelineId.Value);
            }
            if (Optional.IsDefined(HasWorkspaceLevelSettings))
            {
                writer.WritePropertyName("hasWorkspaceLevelSettings"u8);
                writer.WriteBooleanValue(HasWorkspaceLevelSettings.Value);
            }
            writer.WriteEndObject();
        }

        internal static GroupAdminProperties DeserializeGroupAdminProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string description = default;
            GroupType? type = default;
            string state = default;
            IList<GroupUser> users = default;
            IList<AdminReport> reports = default;
            IList<AdminDashboard> dashboards = default;
            IList<AdminDataset> datasets = default;
            IList<AdminDataflow> dataflows = default;
            IList<Workbook> workbooks = default;
            Guid? pipelineId = default;
            bool? hasWorkspaceLevelSettings = default;
            foreach (var property in element.EnumerateObject())
            {
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
                    type = property.Value.GetString().ToGroupType();
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    state = property.Value.GetString();
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
                if (property.NameEquals("reports"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AdminReport> array = new List<AdminReport>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AdminReport.DeserializeAdminReport(item));
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
                    List<AdminDashboard> array = new List<AdminDashboard>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AdminDashboard.DeserializeAdminDashboard(item));
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
                    List<AdminDataset> array = new List<AdminDataset>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AdminDataset.DeserializeAdminDataset(item));
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
                    List<AdminDataflow> array = new List<AdminDataflow>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AdminDataflow.DeserializeAdminDataflow(item));
                    }
                    dataflows = array;
                    continue;
                }
                if (property.NameEquals("workbooks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<Workbook> array = new List<Workbook>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Workbook.DeserializeWorkbook(item));
                    }
                    workbooks = array;
                    continue;
                }
                if (property.NameEquals("pipelineId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    pipelineId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("hasWorkspaceLevelSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hasWorkspaceLevelSettings = property.Value.GetBoolean();
                    continue;
                }
            }
            return new GroupAdminProperties(
                description,
                type,
                state,
                users ?? new ChangeTrackingList<GroupUser>(),
                reports ?? new ChangeTrackingList<AdminReport>(),
                dashboards ?? new ChangeTrackingList<AdminDashboard>(),
                datasets ?? new ChangeTrackingList<AdminDataset>(),
                dataflows ?? new ChangeTrackingList<AdminDataflow>(),
                workbooks ?? new ChangeTrackingList<Workbook>(),
                pipelineId,
                hasWorkspaceLevelSettings);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static GroupAdminProperties FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeGroupAdminProperties(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue<GroupAdminProperties>(this);
            return content;
        }
    }
}