// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Microsoft.PowerBI.Api.Models
{
    /// <summary> A Power BI report returned by Workspace Info APIs. The API returns a subset of the following list of report properties. The subset depends on the API called, caller permissions, and the availability of data in the Power BI database. </summary>
    public partial class WorkspaceInfoReport : ReportBaseProperties
    {
        /// <summary> Initializes a new instance of <see cref="WorkspaceInfoReport"/>. </summary>
        /// <param name="id"> The report ID. </param>
        public WorkspaceInfoReport(Guid id) : base(id)
        {
            Users = new ChangeTrackingList<ReportUser>();
        }

        /// <summary> Initializes a new instance of <see cref="WorkspaceInfoReport"/>. </summary>
        /// <param name="id"> The report ID. </param>
        /// <param name="name"> The name of the report. </param>
        /// <param name="datasetId"> The dataset ID of the report. </param>
        /// <param name="appId"> The app ID, returned only if the report belongs to an app. </param>
        /// <param name="description"> The report description. </param>
        /// <param name="reportType"> The report type. </param>
        /// <param name="originalReportId"> The actual report ID when the workspace is published as an app. </param>
        /// <param name="createdBy"> The report owner. Available only for reports created after June 2019. </param>
        /// <param name="modifiedBy"> The last user that modified the report. </param>
        /// <param name="createdDateTime"> The report creation date and time. </param>
        /// <param name="modifiedDateTime"> The date and time that the report was last modified. </param>
        /// <param name="createdById"> The ID of the report owner. Available only for reports created after June 2019. </param>
        /// <param name="modifiedById"> The ID of the last user that modified the report. </param>
        /// <param name="endorsementDetails"> The endorsement details. </param>
        /// <param name="sensitivityLabel"> The sensitivity label. </param>
        /// <param name="users"> (Empty value) The user access details for a Power BI report. This property will be removed from the payload response in an upcoming release. You can retrieve user information on a Power BI report by using the [Get Report Users as Admin](/rest/api/power-bi/admin/reports-get-report-users-as-admin) API call, or the [PostWorkspaceInfo](/rest/api/power-bi/admin/workspace-info-post-workspace-info) API call with the `getArtifactUsers` parameter. </param>
        /// <param name="datasetWorkspaceId"> The workspace ID of the related dataset, returned only if the related dataset belongs to a different workspace. </param>
        internal WorkspaceInfoReport(Guid id, string name, string datasetId, string appId, string description, ReportBasePropertiesReportType? reportType, Guid? originalReportId, string createdBy, string modifiedBy, DateTimeOffset? createdDateTime, DateTimeOffset? modifiedDateTime, string createdById, string modifiedById, EndorsementDetails endorsementDetails, SensitivityLabel sensitivityLabel, IList<ReportUser> users, Guid? datasetWorkspaceId) : base(id, name, datasetId, appId, description, reportType, originalReportId)
        {
            CreatedBy = createdBy;
            ModifiedBy = modifiedBy;
            CreatedDateTime = createdDateTime;
            ModifiedDateTime = modifiedDateTime;
            CreatedById = createdById;
            ModifiedById = modifiedById;
            EndorsementDetails = endorsementDetails;
            SensitivityLabel = sensitivityLabel;
            Users = users;
            DatasetWorkspaceId = datasetWorkspaceId;
        }

        /// <summary> The report owner. Available only for reports created after June 2019. </summary>
        public string CreatedBy { get; set; }
        /// <summary> The last user that modified the report. </summary>
        public string ModifiedBy { get; set; }
        /// <summary> The report creation date and time. </summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary> The date and time that the report was last modified. </summary>
        public DateTimeOffset? ModifiedDateTime { get; set; }
        /// <summary> The ID of the report owner. Available only for reports created after June 2019. </summary>
        public string CreatedById { get; set; }
        /// <summary> The ID of the last user that modified the report. </summary>
        public string ModifiedById { get; set; }
        /// <summary> The endorsement details. </summary>
        public EndorsementDetails EndorsementDetails { get; set; }
        /// <summary> The sensitivity label. </summary>
        public SensitivityLabel SensitivityLabel { get; set; }
        /// <summary> (Empty value) The user access details for a Power BI report. This property will be removed from the payload response in an upcoming release. You can retrieve user information on a Power BI report by using the [Get Report Users as Admin](/rest/api/power-bi/admin/reports-get-report-users-as-admin) API call, or the [PostWorkspaceInfo](/rest/api/power-bi/admin/workspace-info-post-workspace-info) API call with the `getArtifactUsers` parameter. </summary>
        public IList<ReportUser> Users { get; }
        /// <summary> The workspace ID of the related dataset, returned only if the related dataset belongs to a different workspace. </summary>
        public Guid? DatasetWorkspaceId { get; set; }
    }
}
