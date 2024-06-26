// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Microsoft.PowerBI.Api.Models
{
    /// <summary> A list of security related properties of a Power BI dataset. </summary>
    public partial class DatasetSecurityProperties
    {
        /// <summary> Initializes a new instance of <see cref="DatasetSecurityProperties"/>. </summary>
        public DatasetSecurityProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DatasetSecurityProperties"/>. </summary>
        /// <param name="isEffectiveIdentityRequired"> Whether the dataset requires an effective identity, which you must send in a [GenerateToken](/rest/api/power-bi/embed-token/generate-token) API call. </param>
        /// <param name="isEffectiveIdentityRolesRequired"> Whether row-level security is defined inside the Power BI .pbix file. If so, you must specify a role. </param>
        /// <param name="isOnPremGatewayRequired"> Whether the dataset requires an on-premises data gateway. </param>
        /// <param name="encryption"> Dataset encryption information. Only applicable when `$expand` is specified. </param>
        internal DatasetSecurityProperties(bool? isEffectiveIdentityRequired, bool? isEffectiveIdentityRolesRequired, bool? isOnPremGatewayRequired, Encryption encryption)
        {
            IsEffectiveIdentityRequired = isEffectiveIdentityRequired;
            IsEffectiveIdentityRolesRequired = isEffectiveIdentityRolesRequired;
            IsOnPremGatewayRequired = isOnPremGatewayRequired;
            Encryption = encryption;
        }

        /// <summary> Whether the dataset requires an effective identity, which you must send in a [GenerateToken](/rest/api/power-bi/embed-token/generate-token) API call. </summary>
        public bool? IsEffectiveIdentityRequired { get; set; }
        /// <summary> Whether row-level security is defined inside the Power BI .pbix file. If so, you must specify a role. </summary>
        public bool? IsEffectiveIdentityRolesRequired { get; set; }
        /// <summary> Whether the dataset requires an on-premises data gateway. </summary>
        public bool? IsOnPremGatewayRequired { get; set; }
        /// <summary> Dataset encryption information. Only applicable when `$expand` is specified. </summary>
        public Encryption Encryption { get; set; }
    }
}
