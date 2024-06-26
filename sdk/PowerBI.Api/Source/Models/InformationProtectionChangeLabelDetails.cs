// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Microsoft.PowerBI.Api.Models
{
    /// <summary> A composite of label information required to update an information protection label. </summary>
    public partial class InformationProtectionChangeLabelDetails
    {
        /// <summary> Initializes a new instance of <see cref="InformationProtectionChangeLabelDetails"/>. </summary>
        /// <param name="artifacts"> A composite of Power BI item IDs for each item type. </param>
        /// <param name="labelId"> The label ID, which must be in the user's label policy. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="artifacts"/> is null. </exception>
        public InformationProtectionChangeLabelDetails(InformationProtectionArtifactsChangeLabel artifacts, Guid labelId)
        {
            Argument.AssertNotNull(artifacts, nameof(artifacts));

            Artifacts = artifacts;
            LabelId = labelId;
        }

        /// <summary> Initializes a new instance of <see cref="InformationProtectionChangeLabelDetails"/>. </summary>
        /// <param name="artifacts"> A composite of Power BI item IDs for each item type. </param>
        /// <param name="labelId"> The label ID, which must be in the user's label policy. </param>
        /// <param name="delegatedUser"> Delegated user details. A delegated user is a user within an organization whose admin sets a label on behalf of the user. Although the admin sets the label, the delegated user is marked as the label issuer. </param>
        /// <param name="assignmentMethod"> Specifies whether the assigned label was set by an automated process or manually. </param>
        internal InformationProtectionChangeLabelDetails(InformationProtectionArtifactsChangeLabel artifacts, Guid labelId, DelegatedUser delegatedUser, AssignmentMethod? assignmentMethod)
        {
            Artifacts = artifacts;
            LabelId = labelId;
            DelegatedUser = delegatedUser;
            AssignmentMethod = assignmentMethod;
        }

        /// <summary> A composite of Power BI item IDs for each item type. </summary>
        public InformationProtectionArtifactsChangeLabel Artifacts { get; }
        /// <summary> The label ID, which must be in the user's label policy. </summary>
        public Guid LabelId { get; }
        /// <summary> Delegated user details. A delegated user is a user within an organization whose admin sets a label on behalf of the user. Although the admin sets the label, the delegated user is marked as the label issuer. </summary>
        public DelegatedUser DelegatedUser { get; set; }
        /// <summary> Specifies whether the assigned label was set by an automated process or manually. </summary>
        public AssignmentMethod? AssignmentMethod { get; set; }
    }
}
