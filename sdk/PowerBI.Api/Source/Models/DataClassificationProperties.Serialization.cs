// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;
using Azure.Core;

namespace Microsoft.PowerBI.Api.Models
{
    public partial class DataClassificationProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(DataClassification))
            {
                writer.WritePropertyName("dataClassification"u8);
                writer.WriteStringValue(DataClassification);
            }
            writer.WriteEndObject();
        }

        internal static DataClassificationProperties DeserializeDataClassificationProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string dataClassification = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dataClassification"u8))
                {
                    dataClassification = property.Value.GetString();
                    continue;
                }
            }
            return new DataClassificationProperties(dataClassification);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static DataClassificationProperties FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeDataClassificationProperties(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue<DataClassificationProperties>(this);
            return content;
        }
    }
}