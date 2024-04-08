// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Microsoft.PowerBI.Api.Models
{
    /// <summary> The install details for a Power BI template app. </summary>
    public partial class TemplateAppInstallDetails
    {
        /// <summary> Initializes a new instance of <see cref="TemplateAppInstallDetails"/>. </summary>
        /// <param name="appId"> The unique ID of the Power BI template app. </param>
        /// <param name="packageKey"> The secure key for the Power BI template app version. </param>
        /// <param name="ownerTenantId"> The tenant ID of the Power BI template app owner. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="packageKey"/> is null. </exception>
        public TemplateAppInstallDetails(Guid appId, string packageKey, Guid ownerTenantId)
        {
            Argument.AssertNotNull(packageKey, nameof(packageKey));

            AppId = appId;
            PackageKey = packageKey;
            OwnerTenantId = ownerTenantId;
        }

        /// <summary> Initializes a new instance of <see cref="TemplateAppInstallDetails"/>. </summary>
        /// <param name="appId"> The unique ID of the Power BI template app. </param>
        /// <param name="packageKey"> The secure key for the Power BI template app version. </param>
        /// <param name="ownerTenantId"> The tenant ID of the Power BI template app owner. </param>
        /// <param name="config"> The automated install configuration. </param>
        internal TemplateAppInstallDetails(Guid appId, string packageKey, Guid ownerTenantId, TemplateAppConfigurationRequest config)
        {
            AppId = appId;
            PackageKey = packageKey;
            OwnerTenantId = ownerTenantId;
            Config = config;
        }

        /// <summary> The unique ID of the Power BI template app. </summary>
        public Guid AppId { get; }
        /// <summary> The secure key for the Power BI template app version. </summary>
        public string PackageKey { get; }
        /// <summary> The tenant ID of the Power BI template app owner. </summary>
        public Guid OwnerTenantId { get; }
        /// <summary> The automated install configuration. </summary>
        public TemplateAppConfigurationRequest Config { get; set; }
    }
}
