// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Microsoft.PowerBI.Api.Models
{
    public partial class DatasetRefreshRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("notifyOption"u8);
            writer.WriteStringValue(NotifyOption.ToSerialString());
            if (Optional.IsDefined(Type))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(Type.Value.ToSerialString());
            }
            if (Optional.IsDefined(CommitMode))
            {
                writer.WritePropertyName("commitMode"u8);
                writer.WriteStringValue(CommitMode.Value.ToSerialString());
            }
            if (Optional.IsDefined(MaxParallelism))
            {
                writer.WritePropertyName("maxParallelism"u8);
                writer.WriteNumberValue(MaxParallelism.Value);
            }
            if (Optional.IsDefined(RetryCount))
            {
                writer.WritePropertyName("retryCount"u8);
                writer.WriteNumberValue(RetryCount.Value);
            }
            if (Optional.IsCollectionDefined(Objects))
            {
                writer.WritePropertyName("objects"u8);
                writer.WriteStartArray();
                foreach (var item in Objects)
                {
                    writer.WriteObjectValue<DatasetRefreshObjects>(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ApplyRefreshPolicy))
            {
                writer.WritePropertyName("applyRefreshPolicy"u8);
                writer.WriteBooleanValue(ApplyRefreshPolicy.Value);
            }
            if (Optional.IsDefined(EffectiveDate))
            {
                writer.WritePropertyName("effectiveDate"u8);
                writer.WriteStringValue(EffectiveDate.Value, "O");
            }
            writer.WriteEndObject();
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue<DatasetRefreshRequest>(this);
            return content;
        }
    }
}
