// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Microsoft.PowerBI.Api.Models
{
    /// <summary> A Power BI email subscription user. </summary>
    public partial class SubscriptionUser : User
    {
        /// <summary> Initializes a new instance of <see cref="SubscriptionUser"/>. </summary>
        /// <param name="identifier"> Identifier of the principal. </param>
        /// <param name="principalType"> The principal type. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="identifier"/> is null. </exception>
        public SubscriptionUser(string identifier, PrincipalType principalType) : base(identifier, principalType)
        {
            Argument.AssertNotNull(identifier, nameof(identifier));
        }

        /// <summary> Initializes a new instance of <see cref="SubscriptionUser"/>. </summary>
        /// <param name="emailAddress"> Email address of the user. </param>
        /// <param name="displayName"> Display name of the principal. </param>
        /// <param name="identifier"> Identifier of the principal. </param>
        /// <param name="graphId"> Identifier of the principal in Microsoft Graph. Only available for admin APIs. </param>
        /// <param name="userType"> Type of the user. </param>
        /// <param name="principalType"> The principal type. </param>
        /// <param name="profile"> A Power BI service principal profile. Only relevant for [Power BI Embedded multi-tenancy solution](/power-bi/developer/embedded/embed-multi-tenancy). </param>
        internal SubscriptionUser(string emailAddress, string displayName, string identifier, string graphId, string userType, PrincipalType principalType, ServicePrincipalProfile profile) : base(emailAddress, displayName, identifier, graphId, userType, principalType, profile)
        {
        }
    }
}
