// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Microsoft.PowerBI.Api.Models
{
    internal static partial class AppUserAccessRightExtensions
    {
        public static string ToSerialString(this AppUserAccessRight value) => value switch
        {
            AppUserAccessRight.None => "None",
            AppUserAccessRight.Read => "Read",
            AppUserAccessRight.ReadWrite => "ReadWrite",
            AppUserAccessRight.ReadReshare => "ReadReshare",
            AppUserAccessRight.ReadWriteReshare => "ReadWriteReshare",
            AppUserAccessRight.ReadExplore => "ReadExplore",
            AppUserAccessRight.ReadCopy => "ReadCopy",
            AppUserAccessRight.ReadExploreCopy => "ReadExploreCopy",
            AppUserAccessRight.ReadReshareExploreCopy => "ReadReshareExploreCopy",
            AppUserAccessRight.ReadReshareExplore => "ReadReshareExplore",
            AppUserAccessRight.ReadWriteExplore => "ReadWriteExplore",
            AppUserAccessRight.ReadWriteReshareExplore => "ReadWriteReshareExplore",
            AppUserAccessRight.ReadWriteExploreCopy => "ReadWriteExploreCopy",
            AppUserAccessRight.ReadReshareCopy => "ReadReshareCopy",
            AppUserAccessRight.All => "All",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown AppUserAccessRight value.")
        };

        public static AppUserAccessRight ToAppUserAccessRight(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "None")) return AppUserAccessRight.None;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Read")) return AppUserAccessRight.Read;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "ReadWrite")) return AppUserAccessRight.ReadWrite;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "ReadReshare")) return AppUserAccessRight.ReadReshare;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "ReadWriteReshare")) return AppUserAccessRight.ReadWriteReshare;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "ReadExplore")) return AppUserAccessRight.ReadExplore;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "ReadCopy")) return AppUserAccessRight.ReadCopy;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "ReadExploreCopy")) return AppUserAccessRight.ReadExploreCopy;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "ReadReshareExploreCopy")) return AppUserAccessRight.ReadReshareExploreCopy;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "ReadReshareExplore")) return AppUserAccessRight.ReadReshareExplore;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "ReadWriteExplore")) return AppUserAccessRight.ReadWriteExplore;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "ReadWriteReshareExplore")) return AppUserAccessRight.ReadWriteReshareExplore;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "ReadWriteExploreCopy")) return AppUserAccessRight.ReadWriteExploreCopy;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "ReadReshareCopy")) return AppUserAccessRight.ReadReshareCopy;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "All")) return AppUserAccessRight.All;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown AppUserAccessRight value.");
        }
    }
}
