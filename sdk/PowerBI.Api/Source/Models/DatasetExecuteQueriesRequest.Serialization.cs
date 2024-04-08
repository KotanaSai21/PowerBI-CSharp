// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Microsoft.PowerBI.Api.Models
{
    public partial class DatasetExecuteQueriesRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("queries"u8);
            writer.WriteStartArray();
            foreach (var item in Queries)
            {
                writer.WriteObjectValue<DatasetExecuteQueriesQuery>(item);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(SerializerSettings))
            {
                writer.WritePropertyName("serializerSettings"u8);
                writer.WriteObjectValue<DatasetExecuteQueriesSerializationSettings>(SerializerSettings);
            }
            if (Optional.IsDefined(ImpersonatedUserName))
            {
                writer.WritePropertyName("impersonatedUserName"u8);
                writer.WriteStringValue(ImpersonatedUserName);
            }
            writer.WriteEndObject();
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue<DatasetExecuteQueriesRequest>(this);
            return content;
        }
    }
}
