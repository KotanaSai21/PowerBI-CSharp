// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Microsoft.PowerBI.Api.Models
{
    public partial class AdminDataset : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(CreateReportEmbedURL))
            {
                writer.WritePropertyName("CreateReportEmbedURL"u8);
                writer.WriteStringValue(CreateReportEmbedURL);
            }
            if (Optional.IsDefined(QnaEmbedURL))
            {
                writer.WritePropertyName("QnaEmbedURL"u8);
                writer.WriteStringValue(QnaEmbedURL);
            }
            if (Optional.IsDefined(WebUrl))
            {
                writer.WritePropertyName("webUrl"u8);
                writer.WriteStringValue(WebUrl);
            }
            if (Optional.IsDefined(IsEffectiveIdentityRequired))
            {
                writer.WritePropertyName("IsEffectiveIdentityRequired"u8);
                writer.WriteBooleanValue(IsEffectiveIdentityRequired.Value);
            }
            if (Optional.IsDefined(IsEffectiveIdentityRolesRequired))
            {
                writer.WritePropertyName("IsEffectiveIdentityRolesRequired"u8);
                writer.WriteBooleanValue(IsEffectiveIdentityRolesRequired.Value);
            }
            if (Optional.IsDefined(IsOnPremGatewayRequired))
            {
                writer.WritePropertyName("IsOnPremGatewayRequired"u8);
                writer.WriteBooleanValue(IsOnPremGatewayRequired.Value);
            }
            if (Optional.IsDefined(Encryption))
            {
                writer.WritePropertyName("Encryption"u8);
                writer.WriteObjectValue(Encryption);
            }
            if (Optional.IsCollectionDefined(Users))
            {
                writer.WritePropertyName("users"u8);
                writer.WriteStartArray();
                foreach (var item in Users)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(AddRowsAPIEnabled))
            {
                writer.WritePropertyName("addRowsAPIEnabled"u8);
                writer.WriteBooleanValue(AddRowsAPIEnabled.Value);
            }
            if (Optional.IsDefined(IsRefreshable))
            {
                writer.WritePropertyName("IsRefreshable"u8);
                writer.WriteBooleanValue(IsRefreshable.Value);
            }
            if (Optional.IsDefined(IsInPlaceSharingEnabled))
            {
                writer.WritePropertyName("IsInPlaceSharingEnabled"u8);
                writer.WriteBooleanValue(IsInPlaceSharingEnabled.Value);
            }
            if (Optional.IsDefined(TargetStorageMode))
            {
                writer.WritePropertyName("targetStorageMode"u8);
                writer.WriteStringValue(TargetStorageMode);
            }
            if (Optional.IsDefined(WorkspaceId))
            {
                writer.WritePropertyName("workspaceId"u8);
                writer.WriteStringValue(WorkspaceId.Value);
            }
            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(Id);
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(ConfiguredBy))
            {
                writer.WritePropertyName("configuredBy"u8);
                writer.WriteStringValue(ConfiguredBy);
            }
            if (Optional.IsDefined(CreatedDate))
            {
                writer.WritePropertyName("CreatedDate"u8);
                writer.WriteStringValue(CreatedDate.Value, "O");
            }
            if (Optional.IsDefined(ContentProviderType))
            {
                writer.WritePropertyName("ContentProviderType"u8);
                writer.WriteStringValue(ContentProviderType);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsCollectionDefined(UpstreamDataflows))
            {
                writer.WritePropertyName("upstreamDataflows"u8);
                writer.WriteStartArray();
                foreach (var item in UpstreamDataflows)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static AdminDataset DeserializeAdminDataset(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DatasetQueryScaleOutSettings> queryScaleOutSettings = default;
            Optional<string> createReportEmbedURL = default;
            Optional<string> qnaEmbedURL = default;
            Optional<string> webUrl = default;
            Optional<bool> isEffectiveIdentityRequired = default;
            Optional<bool> isEffectiveIdentityRolesRequired = default;
            Optional<bool> isOnPremGatewayRequired = default;
            Optional<Encryption> encryption = default;
            Optional<IList<DatasetUser>> users = default;
            Optional<bool> addRowsAPIEnabled = default;
            Optional<bool> isRefreshable = default;
            Optional<bool> isInPlaceSharingEnabled = default;
            Optional<string> targetStorageMode = default;
            Optional<Guid> workspaceId = default;
            string id = default;
            Optional<string> name = default;
            Optional<string> configuredBy = default;
            Optional<DateTimeOffset> createdDate = default;
            Optional<string> contentProviderType = default;
            Optional<string> description = default;
            Optional<IList<DependentDataflow>> upstreamDataflows = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("queryScaleOutSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    queryScaleOutSettings = DatasetQueryScaleOutSettings.DeserializeDatasetQueryScaleOutSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("CreateReportEmbedURL"u8))
                {
                    createReportEmbedURL = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("QnaEmbedURL"u8))
                {
                    qnaEmbedURL = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("webUrl"u8))
                {
                    webUrl = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("IsEffectiveIdentityRequired"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isEffectiveIdentityRequired = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("IsEffectiveIdentityRolesRequired"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isEffectiveIdentityRolesRequired = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("IsOnPremGatewayRequired"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isOnPremGatewayRequired = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("Encryption"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    encryption = Encryption.DeserializeEncryption(property.Value);
                    continue;
                }
                if (property.NameEquals("users"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DatasetUser> array = new List<DatasetUser>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DatasetUser.DeserializeDatasetUser(item));
                    }
                    users = array;
                    continue;
                }
                if (property.NameEquals("addRowsAPIEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    addRowsAPIEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("IsRefreshable"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isRefreshable = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("IsInPlaceSharingEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isInPlaceSharingEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("targetStorageMode"u8))
                {
                    targetStorageMode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("workspaceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    workspaceId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("configuredBy"u8))
                {
                    configuredBy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("CreatedDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createdDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("ContentProviderType"u8))
                {
                    contentProviderType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
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
            }
            return new AdminDataset(id, name.Value, configuredBy.Value, Optional.ToNullable(createdDate), contentProviderType.Value, description.Value, Optional.ToList(upstreamDataflows), queryScaleOutSettings.Value, createReportEmbedURL.Value, qnaEmbedURL.Value, webUrl.Value, Optional.ToNullable(isEffectiveIdentityRequired), Optional.ToNullable(isEffectiveIdentityRolesRequired), Optional.ToNullable(isOnPremGatewayRequired), encryption.Value, Optional.ToList(users), Optional.ToNullable(addRowsAPIEnabled), Optional.ToNullable(isRefreshable), Optional.ToNullable(isInPlaceSharingEnabled), targetStorageMode.Value, Optional.ToNullable(workspaceId));
        }
    }
}
