// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;
using Azure.Core;

namespace Microsoft.PowerBI.Api.Models
{
    public partial class DatasetNavigationProperties : IUtf8JsonSerializable
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
            writer.WriteEndObject();
        }

        internal static DatasetNavigationProperties DeserializeDatasetNavigationProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string createReportEmbedURL = default;
            string qnaEmbedURL = default;
            string webUrl = default;
            foreach (var property in element.EnumerateObject())
            {
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
            }
            return new DatasetNavigationProperties(createReportEmbedURL, qnaEmbedURL, webUrl);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static DatasetNavigationProperties FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeDatasetNavigationProperties(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue<DatasetNavigationProperties>(this);
            return content;
        }
    }
}