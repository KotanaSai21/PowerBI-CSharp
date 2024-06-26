// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Microsoft.PowerBI.Api.Models
{
    /// <summary> A request to create a scorecard. </summary>
    public partial class ScorecardCreateRequest
    {
        /// <summary> Initializes a new instance of <see cref="ScorecardCreateRequest"/>. </summary>
        /// <param name="name"> The scorecard name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public ScorecardCreateRequest(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
        }

        /// <summary> Initializes a new instance of <see cref="ScorecardCreateRequest"/>. </summary>
        /// <param name="name"> The scorecard name. </param>
        /// <param name="description"> Optional. The scorecard description. </param>
        /// <param name="sensitivityLabelId"> Optional. The GUID of a sensitivity label. If you don't want to select a sensitivity label, use a null or empty GUID (`00000000-0000-0000-0000-000000000000`). If default labels are enabled and/or enforced, they will be applied on the scorecard and dataset. </param>
        internal ScorecardCreateRequest(string name, string description, Guid? sensitivityLabelId)
        {
            Name = name;
            Description = description;
            SensitivityLabelId = sensitivityLabelId;
        }

        /// <summary> The scorecard name. </summary>
        public string Name { get; }
        /// <summary> Optional. The scorecard description. </summary>
        public string Description { get; set; }
        /// <summary> Optional. The GUID of a sensitivity label. If you don't want to select a sensitivity label, use a null or empty GUID (`00000000-0000-0000-0000-000000000000`). If default labels are enabled and/or enforced, they will be applied on the scorecard and dataset. </summary>
        public Guid? SensitivityLabelId { get; set; }
    }
}
