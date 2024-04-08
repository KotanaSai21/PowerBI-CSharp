// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Microsoft.PowerBI.Api.Models
{
    public partial class GoalsMoveRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("goalToMove"u8);
            writer.WriteObjectValue<GoalRankValidationInfo>(GoalToMove);
            if (Optional.IsDefined(NewParent))
            {
                writer.WritePropertyName("newParent"u8);
                writer.WriteObjectValue<GoalRankValidationInfo>(NewParent);
            }
            if (Optional.IsDefined(NewPrevious))
            {
                writer.WritePropertyName("newPrevious"u8);
                writer.WriteObjectValue<GoalRankValidationInfo>(NewPrevious);
            }
            if (Optional.IsDefined(NewNext))
            {
                writer.WritePropertyName("newNext"u8);
                writer.WriteObjectValue<GoalRankValidationInfo>(NewNext);
            }
            writer.WriteEndObject();
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue<GoalsMoveRequest>(this);
            return content;
        }
    }
}
