// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Microsoft.PowerBI.Api.Models
{
    public partial class GenerateTokenRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(AccessLevel))
            {
                writer.WritePropertyName("accessLevel"u8);
                writer.WriteStringValue(AccessLevel.Value.ToSerialString());
            }
            if (Optional.IsDefined(DatasetId))
            {
                writer.WritePropertyName("datasetId"u8);
                writer.WriteStringValue(DatasetId);
            }
            if (Optional.IsDefined(AllowSaveAs))
            {
                writer.WritePropertyName("allowSaveAs"u8);
                writer.WriteBooleanValue(AllowSaveAs.Value);
            }
            if (Optional.IsCollectionDefined(Identities))
            {
                writer.WritePropertyName("identities"u8);
                writer.WriteStartArray();
                foreach (var item in Identities)
                {
                    writer.WriteObjectValue<EffectiveIdentity>(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(LifetimeInMinutes))
            {
                writer.WritePropertyName("lifetimeInMinutes"u8);
                writer.WriteNumberValue(LifetimeInMinutes.Value);
            }
            writer.WriteEndObject();
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue<GenerateTokenRequest>(this);
            return content;
        }
    }
}