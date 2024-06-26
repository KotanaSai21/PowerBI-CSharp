// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure;

namespace Microsoft.PowerBI.Api.Models
{
    public partial class DeploymentExecutionPlan
    {
        internal static DeploymentExecutionPlan DeserializeDeploymentExecutionPlan(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<DeploymentExecutionStep> steps = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("steps"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DeploymentExecutionStep> array = new List<DeploymentExecutionStep>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeploymentExecutionStep.DeserializeDeploymentExecutionStep(item));
                    }
                    steps = array;
                    continue;
                }
            }
            return new DeploymentExecutionPlan(steps ?? new ChangeTrackingList<DeploymentExecutionStep>());
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static DeploymentExecutionPlan FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeDeploymentExecutionPlan(document.RootElement);
        }
    }
}
