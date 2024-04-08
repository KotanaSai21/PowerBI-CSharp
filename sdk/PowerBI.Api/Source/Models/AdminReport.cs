// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Microsoft.PowerBI.Api.Models
{
    /// <summary> A Power BI report returned by Admin APIs. The API returns a subset of the following list of report properties. The subset depends on the API called, caller permissions, and the availability of data in the Power BI database. </summary>
    public partial class AdminReport : ReportBaseProperties
    {
        /// <summary> Initializes a new instance of <see cref="AdminReport"/>. </summary>
        /// <param name="id"> The report ID. </param>
        public AdminReport(Guid id) : base(id)
        {
            Users = new ChangeTrackingList<ReportUser>();
            Subscriptions = new ChangeTrackingList<Subscription>();
        }

        /// <summary> Initializes a new instance of <see cref="AdminReport"/>. </summary>
        /// <param name="id"> The report ID. </param>
        /// <param name="name"> The name of the report. </param>
        /// <param name="datasetId"> The dataset ID of the report. </param>
        /// <param name="appId"> The app ID, returned only if the report belongs to an app. </param>
        /// <param name="description"> The report description. </param>
        /// <param name="reportType"> The report type. </param>
        /// <param name="originalReportId"> The actual report ID when the workspace is published as an app. </param>
        /// <param name="webUrl"> The web URL of the report. </param>
        /// <param name="embedUrl"> The embed URL of the report. </param>
        /// <param name="createdBy"> The report owner. Available only for reports created after June 2019. </param>
        /// <param name="modifiedBy"> The last user that modified the report. </param>
        /// <param name="createdDateTime"> The report creation date and time. </param>
        /// <param name="modifiedDateTime"> The date and time that the report was last modified. </param>
        /// <param name="users"> (Empty value) The user access details for a Power BI report. This property will be removed from the payload response in an upcoming release. You can retrieve user information on a Power BI report by using the [Get Report Users as Admin](/rest/api/power-bi/admin/reports-get-report-users-as-admin) API call, or the [PostWorkspaceInfo](/rest/api/power-bi/admin/workspace-info-post-workspace-info) API call with the `getArtifactUsers` parameter. </param>
        /// <param name="subscriptions"> (Empty Value) The subscription details for a Power BI item (such as a report or a dashboard). This property will be removed from the payload response in an upcoming release. You can retrieve subscription information for a Power BI report by using the [Get Report Subscriptions as Admin](/rest/api/power-bi/admin/reports-get-report-subscriptions-as-admin) API call. </param>
        /// <param name="workspaceId"> The workspace ID (GUID) of the report. This property will be returned only in GetReportsAsAdmin. </param>
        internal AdminReport(Guid id, string name, string datasetId, string appId, string description, ReportBasePropertiesReportType? reportType, Guid? originalReportId, string webUrl, string embedUrl, string createdBy, string modifiedBy, DateTimeOffset? createdDateTime, DateTimeOffset? modifiedDateTime, IList<ReportUser> users, IList<Subscription> subscriptions, Guid? workspaceId) : base(id, name, datasetId, appId, description, reportType, originalReportId)
        {
            WebUrl = webUrl;
            EmbedUrl = embedUrl;
            CreatedBy = createdBy;
            ModifiedBy = modifiedBy;
            CreatedDateTime = createdDateTime;
            ModifiedDateTime = modifiedDateTime;
            Users = users;
            Subscriptions = subscriptions;
            WorkspaceId = workspaceId;
        }

        /// <summary> The web URL of the report. </summary>
        public string WebUrl { get; set; }
        /// <summary> The embed URL of the report. </summary>
        public string EmbedUrl { get; set; }
        /// <summary> The report owner. Available only for reports created after June 2019. </summary>
        public string CreatedBy { get; set; }
        /// <summary> The last user that modified the report. </summary>
        public string ModifiedBy { get; set; }
        /// <summary> The report creation date and time. </summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary> The date and time that the report was last modified. </summary>
        public DateTimeOffset? ModifiedDateTime { get; set; }
        /// <summary> (Empty value) The user access details for a Power BI report. This property will be removed from the payload response in an upcoming release. You can retrieve user information on a Power BI report by using the [Get Report Users as Admin](/rest/api/power-bi/admin/reports-get-report-users-as-admin) API call, or the [PostWorkspaceInfo](/rest/api/power-bi/admin/workspace-info-post-workspace-info) API call with the `getArtifactUsers` parameter. </summary>
        public IList<ReportUser> Users { get; }
        /// <summary> (Empty Value) The subscription details for a Power BI item (such as a report or a dashboard). This property will be removed from the payload response in an upcoming release. You can retrieve subscription information for a Power BI report by using the [Get Report Subscriptions as Admin](/rest/api/power-bi/admin/reports-get-report-subscriptions-as-admin) API call. </summary>
        public IList<Subscription> Subscriptions { get; }
        /// <summary> The workspace ID (GUID) of the report. This property will be returned only in GetReportsAsAdmin. </summary>
        public Guid? WorkspaceId { get; set; }
    }
}
