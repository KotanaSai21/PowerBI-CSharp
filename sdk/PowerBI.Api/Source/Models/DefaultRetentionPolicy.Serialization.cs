// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Microsoft.PowerBI.Api.Models
{
    internal static partial class DefaultRetentionPolicyExtensions
    {
        public static string ToSerialString(this DefaultRetentionPolicy value) => value switch
        {
            DefaultRetentionPolicy.None => "None",
            DefaultRetentionPolicy.BasicFifo => "basicFIFO",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown DefaultRetentionPolicy value.")
        };

        public static DefaultRetentionPolicy ToDefaultRetentionPolicy(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "None")) return DefaultRetentionPolicy.None;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "basicFIFO")) return DefaultRetentionPolicy.BasicFifo;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown DefaultRetentionPolicy value.");
        }
    }
}