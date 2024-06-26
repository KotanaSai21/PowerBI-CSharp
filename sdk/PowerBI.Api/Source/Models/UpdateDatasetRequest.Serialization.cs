// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Microsoft.PowerBI.Api.Models
{
    public partial class UpdateDatasetRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(TargetStorageMode))
            {
                writer.WritePropertyName("targetStorageMode"u8);
                writer.WriteStringValue(TargetStorageMode);
            }
            if (Optional.IsDefined(QueryScaleOutSettings))
            {
                writer.WritePropertyName("queryScaleOutSettings"u8);
                writer.WriteObjectValue<DatasetQueryScaleOutSettings>(QueryScaleOutSettings);
            }
            writer.WriteEndObject();
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue<UpdateDatasetRequest>(this);
            return content;
        }
    }
}
