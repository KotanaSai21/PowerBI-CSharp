// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Microsoft.PowerBI.Api.Models
{
    /// <summary> A Power BI user with access to the data source. </summary>
    public partial class DatasourceUser
    {
        /// <summary> Initializes a new instance of <see cref="DatasourceUser"/>. </summary>
        /// <param name="datasourceAccessRight"> The access right (permission level) that a user has on the data source. </param>
        public DatasourceUser(DatasourceUserAccessRight datasourceAccessRight)
        {
            DatasourceAccessRight = datasourceAccessRight;
        }

        /// <summary> Initializes a new instance of <see cref="DatasourceUser"/>. </summary>
        /// <param name="datasourceAccessRight"> The access right (permission level) that a user has on the data source. </param>
        /// <param name="emailAddress"> The email address of the user. </param>
        /// <param name="displayName"> The display name of the principal. </param>
        /// <param name="identifier"> The [object ID](/power-bi/developer/embedded/embedded-troubleshoot#what-is-the-difference-between-application-object-id-and-principal-object-id) of the principal. </param>
        /// <param name="principalType"> The principal type. </param>
        /// <param name="profile"> A Power BI service principal profile. Only relevant for [Power BI Embedded multi-tenancy solution](/power-bi/developer/embedded/embed-multi-tenancy). </param>
        internal DatasourceUser(DatasourceUserAccessRight datasourceAccessRight, string emailAddress, string displayName, string identifier, PrincipalType? principalType, ServicePrincipalProfile profile)
        {
            DatasourceAccessRight = datasourceAccessRight;
            EmailAddress = emailAddress;
            DisplayName = displayName;
            Identifier = identifier;
            PrincipalType = principalType;
            Profile = profile;
        }

        /// <summary> The access right (permission level) that a user has on the data source. </summary>
        public DatasourceUserAccessRight DatasourceAccessRight { get; set; }
        /// <summary> The email address of the user. </summary>
        public string EmailAddress { get; set; }
        /// <summary> The display name of the principal. </summary>
        public string DisplayName { get; set; }
        /// <summary> The [object ID](/power-bi/developer/embedded/embedded-troubleshoot#what-is-the-difference-between-application-object-id-and-principal-object-id) of the principal. </summary>
        public string Identifier { get; set; }
        /// <summary> The principal type. </summary>
        public PrincipalType? PrincipalType { get; set; }
        /// <summary> A Power BI service principal profile. Only relevant for [Power BI Embedded multi-tenancy solution](/power-bi/developer/embedded/embed-multi-tenancy). </summary>
        public ServicePrincipalProfile Profile { get; set; }
    }
}
