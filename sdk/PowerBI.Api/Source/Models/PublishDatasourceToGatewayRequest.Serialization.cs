// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Microsoft.PowerBI.Api.Models
{
    public partial class PublishDatasourceToGatewayRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("dataSourceType"u8);
            writer.WriteStringValue(DataSourceType);
            writer.WritePropertyName("connectionDetails"u8);
            writer.WriteStringValue(ConnectionDetails);
            writer.WritePropertyName("credentialDetails"u8);
            writer.WriteObjectValue<CredentialDetails>(CredentialDetails);
            writer.WritePropertyName("dataSourceName"u8);
            writer.WriteStringValue(DataSourceName);
            writer.WriteEndObject();
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue<PublishDatasourceToGatewayRequest>(this);
            return content;
        }
    }
}
