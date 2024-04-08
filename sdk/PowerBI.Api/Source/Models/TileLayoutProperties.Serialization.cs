// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;
using Azure.Core;

namespace Microsoft.PowerBI.Api.Models
{
    public partial class TileLayoutProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(RowSpan))
            {
                writer.WritePropertyName("rowSpan"u8);
                writer.WriteNumberValue(RowSpan.Value);
            }
            if (Optional.IsDefined(ColSpan))
            {
                writer.WritePropertyName("colSpan"u8);
                writer.WriteNumberValue(ColSpan.Value);
            }
            writer.WriteEndObject();
        }

        internal static TileLayoutProperties DeserializeTileLayoutProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? rowSpan = default;
            int? colSpan = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("rowSpan"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rowSpan = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("colSpan"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    colSpan = property.Value.GetInt32();
                    continue;
                }
            }
            return new TileLayoutProperties(rowSpan, colSpan);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static TileLayoutProperties FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeTileLayoutProperties(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue<TileLayoutProperties>(this);
            return content;
        }
    }
}
