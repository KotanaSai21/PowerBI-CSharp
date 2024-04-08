// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;
using Azure.Core;

namespace Microsoft.PowerBI.Api.Models
{
    public partial class DatasourceConnectionDetails : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Server))
            {
                writer.WritePropertyName("server"u8);
                writer.WriteStringValue(Server);
            }
            if (Optional.IsDefined(Database))
            {
                writer.WritePropertyName("database"u8);
                writer.WriteStringValue(Database);
            }
            if (Optional.IsDefined(Url))
            {
                writer.WritePropertyName("url"u8);
                writer.WriteStringValue(Url);
            }
            if (Optional.IsDefined(Path))
            {
                writer.WritePropertyName("path"u8);
                writer.WriteStringValue(Path);
            }
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            if (Optional.IsDefined(Account))
            {
                writer.WritePropertyName("account"u8);
                writer.WriteStringValue(Account);
            }
            if (Optional.IsDefined(Domain))
            {
                writer.WritePropertyName("domain"u8);
                writer.WriteStringValue(Domain);
            }
            if (Optional.IsDefined(EmailAddress))
            {
                writer.WritePropertyName("emailAddress"u8);
                writer.WriteStringValue(EmailAddress);
            }
            if (Optional.IsDefined(LoginServer))
            {
                writer.WritePropertyName("loginServer"u8);
                writer.WriteStringValue(LoginServer);
            }
            if (Optional.IsDefined(ClassInfo))
            {
                writer.WritePropertyName("classInfo"u8);
                writer.WriteStringValue(ClassInfo);
            }
            writer.WriteEndObject();
        }

        internal static DatasourceConnectionDetails DeserializeDatasourceConnectionDetails(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string server = default;
            string database = default;
            string url = default;
            string path = default;
            string kind = default;
            string account = default;
            string domain = default;
            string emailAddress = default;
            string loginServer = default;
            string classInfo = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("server"u8))
                {
                    server = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("database"u8))
                {
                    database = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("url"u8))
                {
                    url = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("path"u8))
                {
                    path = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("account"u8))
                {
                    account = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("domain"u8))
                {
                    domain = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("emailAddress"u8))
                {
                    emailAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("loginServer"u8))
                {
                    loginServer = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("classInfo"u8))
                {
                    classInfo = property.Value.GetString();
                    continue;
                }
            }
            return new DatasourceConnectionDetails(
                server,
                database,
                url,
                path,
                kind,
                account,
                domain,
                emailAddress,
                loginServer,
                classInfo);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static DatasourceConnectionDetails FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeDatasourceConnectionDetails(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue<DatasourceConnectionDetails>(this);
            return content;
        }
    }
}
