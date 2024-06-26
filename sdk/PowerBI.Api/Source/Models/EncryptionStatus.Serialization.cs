// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Microsoft.PowerBI.Api.Models
{
    internal static partial class EncryptionStatusExtensions
    {
        public static string ToSerialString(this EncryptionStatus value) => value switch
        {
            EncryptionStatus.Unknown => "Unknown",
            EncryptionStatus.NotSupported => "NotSupported",
            EncryptionStatus.InSyncWithWorkspace => "InSyncWithWorkspace",
            EncryptionStatus.NotInSyncWithWorkspace => "NotInSyncWithWorkspace",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown EncryptionStatus value.")
        };

        public static EncryptionStatus ToEncryptionStatus(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Unknown")) return EncryptionStatus.Unknown;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "NotSupported")) return EncryptionStatus.NotSupported;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "InSyncWithWorkspace")) return EncryptionStatus.InSyncWithWorkspace;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "NotInSyncWithWorkspace")) return EncryptionStatus.NotInSyncWithWorkspace;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown EncryptionStatus value.");
        }
    }
}
