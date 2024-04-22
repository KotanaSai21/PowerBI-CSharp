// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Microsoft.PowerBI.Api.Models
{
    internal static partial class AssignmentMethodExtensions
    {
        public static string ToSerialString(this AssignmentMethod value) => value switch
        {
            AssignmentMethod.Standard => "Standard",
            AssignmentMethod.Priviledged => "Priviledged",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown AssignmentMethod value.")
        };

        public static AssignmentMethod ToAssignmentMethod(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Standard")) return AssignmentMethod.Standard;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Priviledged")) return AssignmentMethod.Priviledged;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown AssignmentMethod value.");
        }
    }
}