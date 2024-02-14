// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Microsoft.PowerBI.Api.Models
{
    /// <summary> The export to file configuration for a Power BI report. </summary>
    public partial class PowerBIReportExportConfiguration
    {
        /// <summary> Initializes a new instance of <see cref="PowerBIReportExportConfiguration"/>. </summary>
        public PowerBIReportExportConfiguration()
        {
            ReportLevelFilters = new ChangeTrackingList<ExportFilter>();
            Pages = new ChangeTrackingList<ExportReportPage>();
            Identities = new ChangeTrackingList<EffectiveIdentity>();
        }

        /// <summary> Initializes a new instance of <see cref="PowerBIReportExportConfiguration"/>. </summary>
        /// <param name="settings"> The settings to be applied for the export to file job. </param>
        /// <param name="datasetToBind"> The dataset ID to export the report with. Only needed if exporting with a dataset other than the report's default dataset. </param>
        /// <param name="defaultBookmark"> A default bookmark to apply on all pages that don't have a specific bookmark. </param>
        /// <param name="reportLevelFilters"> A list of report level filters to apply. Currently, only one filter is supported. </param>
        /// <param name="pages"> A list of pages to export and their properties. The same page may appear more than once with different visuals. </param>
        /// <param name="identities"> A list of identities to use for row-level security rules. </param>
        internal PowerBIReportExportConfiguration(ExportReportSettings settings, string datasetToBind, PageBookmark defaultBookmark, IList<ExportFilter> reportLevelFilters, IList<ExportReportPage> pages, IList<EffectiveIdentity> identities)
        {
            Settings = settings;
            DatasetToBind = datasetToBind;
            DefaultBookmark = defaultBookmark;
            ReportLevelFilters = reportLevelFilters;
            Pages = pages;
            Identities = identities;
        }

        /// <summary> The settings to be applied for the export to file job. </summary>
        public ExportReportSettings Settings { get; set; }
        /// <summary> The dataset ID to export the report with. Only needed if exporting with a dataset other than the report's default dataset. </summary>
        public string DatasetToBind { get; set; }
        /// <summary> A default bookmark to apply on all pages that don't have a specific bookmark. </summary>
        public PageBookmark DefaultBookmark { get; set; }
        /// <summary> A list of report level filters to apply. Currently, only one filter is supported. </summary>
        public IList<ExportFilter> ReportLevelFilters { get; }
        /// <summary> A list of pages to export and their properties. The same page may appear more than once with different visuals. </summary>
        public IList<ExportReportPage> Pages { get; }
        /// <summary> A list of identities to use for row-level security rules. </summary>
        public IList<EffectiveIdentity> Identities { get; }
    }
}
