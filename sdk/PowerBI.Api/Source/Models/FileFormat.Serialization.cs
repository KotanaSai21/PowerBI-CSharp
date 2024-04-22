// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Microsoft.PowerBI.Api.Models
{
    internal static partial class FileFormatExtensions
    {
        public static string ToSerialString(this FileFormat value) => value switch
        {
            FileFormat.Pptx => "PPTX",
            FileFormat.PDF => "PDF",
            FileFormat.PNG => "PNG",
            FileFormat.Image => "IMAGE",
            FileFormat.Xlsx => "XLSX",
            FileFormat.Docx => "DOCX",
            FileFormat.CSV => "CSV",
            FileFormat.XML => "XML",
            FileFormat.Mhtml => "MHTML",
            FileFormat.Accessiblepdf => "ACCESSIBLEPDF",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown FileFormat value.")
        };

        public static FileFormat ToFileFormat(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "PPTX")) return FileFormat.Pptx;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "PDF")) return FileFormat.PDF;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "PNG")) return FileFormat.PNG;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "IMAGE")) return FileFormat.Image;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "XLSX")) return FileFormat.Xlsx;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "DOCX")) return FileFormat.Docx;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "CSV")) return FileFormat.CSV;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "XML")) return FileFormat.XML;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "MHTML")) return FileFormat.Mhtml;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "ACCESSIBLEPDF")) return FileFormat.Accessiblepdf;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown FileFormat value.");
        }
    }
}