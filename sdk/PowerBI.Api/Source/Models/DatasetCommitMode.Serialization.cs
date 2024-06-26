// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Microsoft.PowerBI.Api.Models
{
    internal static partial class DatasetCommitModeExtensions
    {
        public static string ToSerialString(this DatasetCommitMode value) => value switch
        {
            DatasetCommitMode.Transactional => "Transactional",
            DatasetCommitMode.PartialBatch => "PartialBatch",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown DatasetCommitMode value.")
        };

        public static DatasetCommitMode ToDatasetCommitMode(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Transactional")) return DatasetCommitMode.Transactional;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "PartialBatch")) return DatasetCommitMode.PartialBatch;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown DatasetCommitMode value.");
        }
    }
}
