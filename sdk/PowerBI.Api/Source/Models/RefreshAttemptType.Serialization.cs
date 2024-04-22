// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Microsoft.PowerBI.Api.Models
{
    internal static partial class RefreshAttemptTypeExtensions
    {
        public static string ToSerialString(this RefreshAttemptType value) => value switch
        {
            RefreshAttemptType.Data => "Data",
            RefreshAttemptType.Query => "Query",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown RefreshAttemptType value.")
        };

        public static RefreshAttemptType ToRefreshAttemptType(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Data")) return RefreshAttemptType.Data;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Query")) return RefreshAttemptType.Query;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown RefreshAttemptType value.");
        }
    }
}