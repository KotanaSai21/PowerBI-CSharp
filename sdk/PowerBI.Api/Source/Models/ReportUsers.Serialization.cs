// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure;

namespace Microsoft.PowerBI.Api.Models
{
    public partial class ReportUsers
    {
        internal static ReportUsers DeserializeReportUsers(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string odataContext = default;
            IReadOnlyList<ReportUser> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("odata.context"u8))
                {
                    odataContext = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ReportUser> array = new List<ReportUser>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ReportUser.DeserializeReportUser(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new ReportUsers(odataContext, value ?? new ChangeTrackingList<ReportUser>());
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static ReportUsers FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeReportUsers(document.RootElement);
        }
    }
}
