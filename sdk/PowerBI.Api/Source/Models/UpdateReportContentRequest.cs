// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Microsoft.PowerBI.Api.Models
{
    /// <summary> A Power BI request to update the content of a report. </summary>
    public partial class UpdateReportContentRequest
    {
        /// <summary> Initializes a new instance of <see cref="UpdateReportContentRequest"/>. </summary>
        /// <param name="sourceReport"> An existing source report. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceReport"/> is null. </exception>
        public UpdateReportContentRequest(SourceReport sourceReport)
        {
            Argument.AssertNotNull(sourceReport, nameof(sourceReport));

            SourceType = SourceType.ExistingReport;
            SourceReport = sourceReport;
        }

        /// <summary> Initializes a new instance of <see cref="UpdateReportContentRequest"/>. </summary>
        /// <param name="sourceType"> The source type of the content update. </param>
        /// <param name="sourceReport"> An existing source report. </param>
        internal UpdateReportContentRequest(SourceType sourceType, SourceReport sourceReport)
        {
            SourceType = sourceType;
            SourceReport = sourceReport;
        }

        /// <summary> The source type of the content update. </summary>
        public SourceType SourceType { get; }
        /// <summary> An existing source report. </summary>
        public SourceReport SourceReport { get; }
    }
}
