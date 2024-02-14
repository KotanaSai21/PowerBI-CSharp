// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Microsoft.PowerBI.Api.Models
{
    internal static partial class DatasetRefreshTypeExtensions
    {
        public static string ToSerialString(this DatasetRefreshType value) => value switch
        {
            DatasetRefreshType.Full => "Full",
            DatasetRefreshType.ClearValues => "ClearValues",
            DatasetRefreshType.Calculate => "Calculate",
            DatasetRefreshType.DataOnly => "DataOnly",
            DatasetRefreshType.Automatic => "Automatic",
            DatasetRefreshType.Defragment => "Defragment",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown DatasetRefreshType value.")
        };

        public static DatasetRefreshType ToDatasetRefreshType(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Full")) return DatasetRefreshType.Full;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "ClearValues")) return DatasetRefreshType.ClearValues;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Calculate")) return DatasetRefreshType.Calculate;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "DataOnly")) return DatasetRefreshType.DataOnly;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Automatic")) return DatasetRefreshType.Automatic;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Defragment")) return DatasetRefreshType.Defragment;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown DatasetRefreshType value.");
        }
    }
}
