// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Microsoft.PowerBI.Api.Models
{
    /// <summary> A Power BI capacity. </summary>
    public partial class Capacity
    {
        /// <summary> Initializes a new instance of <see cref="Capacity"/>. </summary>
        /// <param name="id"> The capacity ID. </param>
        /// <param name="state"> The capacity state. </param>
        /// <param name="capacityUserAccessRight"> The access right a user has on the capacity. </param>
        internal Capacity(Guid id, CapacityState state, CapacityUserAccessRight capacityUserAccessRight)
        {
            Id = id;
            Admins = new ChangeTrackingList<string>();
            State = state;
            CapacityUserAccessRight = capacityUserAccessRight;
        }

        /// <summary> Initializes a new instance of <see cref="Capacity"/>. </summary>
        /// <param name="id"> The capacity ID. </param>
        /// <param name="displayName"> The display name of the capacity. </param>
        /// <param name="admins"> An array of capacity admins. </param>
        /// <param name="sku"> The capacity SKU. </param>
        /// <param name="state"> The capacity state. </param>
        /// <param name="capacityUserAccessRight"> The access right a user has on the capacity. </param>
        /// <param name="region"> The Azure region where the capacity was provisioned. </param>
        /// <param name="tenantKeyId"> The ID of an encryption key (only applicable to the admin route). </param>
        /// <param name="tenantKey"> Encryption key information (only applies to admin routes). </param>
        internal Capacity(Guid id, string displayName, IReadOnlyList<string> admins, string sku, CapacityState state, CapacityUserAccessRight capacityUserAccessRight, string region, Guid? tenantKeyId, TenantKey tenantKey)
        {
            Id = id;
            DisplayName = displayName;
            Admins = admins;
            Sku = sku;
            State = state;
            CapacityUserAccessRight = capacityUserAccessRight;
            Region = region;
            TenantKeyId = tenantKeyId;
            TenantKey = tenantKey;
        }

        /// <summary> The capacity ID. </summary>
        public Guid Id { get; }
        /// <summary> The display name of the capacity. </summary>
        public string DisplayName { get; }
        /// <summary> An array of capacity admins. </summary>
        public IReadOnlyList<string> Admins { get; }
        /// <summary> The capacity SKU. </summary>
        public string Sku { get; }
        /// <summary> The capacity state. </summary>
        public CapacityState State { get; }
        /// <summary> The access right a user has on the capacity. </summary>
        public CapacityUserAccessRight CapacityUserAccessRight { get; }
        /// <summary> The Azure region where the capacity was provisioned. </summary>
        public string Region { get; }
        /// <summary> The ID of an encryption key (only applicable to the admin route). </summary>
        public Guid? TenantKeyId { get; }
        /// <summary> Encryption key information (only applies to admin routes). </summary>
        public TenantKey TenantKey { get; }
    }
}
