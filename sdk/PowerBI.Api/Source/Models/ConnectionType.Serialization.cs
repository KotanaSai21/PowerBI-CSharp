// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Microsoft.PowerBI.Api.Models
{
    internal static partial class ConnectionTypeExtensions
    {
        public static string ToSerialString(this ConnectionType value) => value switch
        {
            ConnectionType.Import => "import",
            ConnectionType.Connect => "connect",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ConnectionType value.")
        };

        public static ConnectionType ToConnectionType(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "import")) return ConnectionType.Import;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "connect")) return ConnectionType.Connect;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ConnectionType value.");
        }
    }
}
