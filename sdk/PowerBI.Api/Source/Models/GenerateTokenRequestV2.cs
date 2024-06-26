// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Microsoft.PowerBI.Api.Models
{
    /// <summary> Power BI Generate Token Request V2. </summary>
    public partial class GenerateTokenRequestV2
    {
        /// <summary> Initializes a new instance of <see cref="GenerateTokenRequestV2"/>. </summary>
        public GenerateTokenRequestV2()
        {
            Datasets = new ChangeTrackingList<GenerateTokenRequestV2Dataset>();
            Reports = new ChangeTrackingList<GenerateTokenRequestV2Report>();
            TargetWorkspaces = new ChangeTrackingList<GenerateTokenRequestV2TargetWorkspace>();
            Identities = new ChangeTrackingList<EffectiveIdentity>();
            DatasourceIdentities = new ChangeTrackingList<DatasourceIdentity>();
        }

        /// <summary> Initializes a new instance of <see cref="GenerateTokenRequestV2"/>. </summary>
        /// <param name="datasets"> A list of datasets. </param>
        /// <param name="reports"> A list of reports. </param>
        /// <param name="targetWorkspaces"> The list of workspaces that the embed token will allow saving to. </param>
        /// <param name="identities"> The list of identities to use for row-level security rules. </param>
        /// <param name="lifetimeInMinutes"> The maximum lifetime of the token in minutes, starting from the time it was generated. Can be used to shorten the token's expiration time, but not to extend it. The value must be a positive integer. Zero (`0`) is equivalent to `null`, and will set the default expiration time. </param>
        /// <param name="datasourceIdentities"> List of identities to use when connecting to data sources with Single Sign-On (SSO) enabled. </param>
        internal GenerateTokenRequestV2(IList<GenerateTokenRequestV2Dataset> datasets, IList<GenerateTokenRequestV2Report> reports, IList<GenerateTokenRequestV2TargetWorkspace> targetWorkspaces, IList<EffectiveIdentity> identities, int? lifetimeInMinutes, IList<DatasourceIdentity> datasourceIdentities)
        {
            Datasets = datasets;
            Reports = reports;
            TargetWorkspaces = targetWorkspaces;
            Identities = identities;
            LifetimeInMinutes = lifetimeInMinutes;
            DatasourceIdentities = datasourceIdentities;
        }

        /// <summary> A list of datasets. </summary>
        public IList<GenerateTokenRequestV2Dataset> Datasets { get; }
        /// <summary> A list of reports. </summary>
        public IList<GenerateTokenRequestV2Report> Reports { get; }
        /// <summary> The list of workspaces that the embed token will allow saving to. </summary>
        public IList<GenerateTokenRequestV2TargetWorkspace> TargetWorkspaces { get; }
        /// <summary> The list of identities to use for row-level security rules. </summary>
        public IList<EffectiveIdentity> Identities { get; }
        /// <summary> The maximum lifetime of the token in minutes, starting from the time it was generated. Can be used to shorten the token's expiration time, but not to extend it. The value must be a positive integer. Zero (`0`) is equivalent to `null`, and will set the default expiration time. </summary>
        public int? LifetimeInMinutes { get; set; }
        /// <summary> List of identities to use when connecting to data sources with Single Sign-On (SSO) enabled. </summary>
        public IList<DatasourceIdentity> DatasourceIdentities { get; }
    }
}
