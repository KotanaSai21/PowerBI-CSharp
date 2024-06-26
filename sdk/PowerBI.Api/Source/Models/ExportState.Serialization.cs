// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Microsoft.PowerBI.Api.Models
{
    internal static partial class ExportStateExtensions
    {
        public static string ToSerialString(this ExportState value) => value switch
        {
            ExportState.Undefined => "Undefined",
            ExportState.NotStarted => "NotStarted",
            ExportState.Running => "Running",
            ExportState.Succeeded => "Succeeded",
            ExportState.Failed => "Failed",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ExportState value.")
        };

        public static ExportState ToExportState(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Undefined")) return ExportState.Undefined;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "NotStarted")) return ExportState.NotStarted;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Running")) return ExportState.Running;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Succeeded")) return ExportState.Succeeded;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Failed")) return ExportState.Failed;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ExportState value.");
        }
    }
}
