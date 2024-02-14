// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Microsoft.PowerBI.Api.Models
{
    /// <summary> The amount of new, different and identical deployed items before deployment. </summary>
    public partial class PreDeploymentDiffInformation
    {
        /// <summary> Initializes a new instance of <see cref="PreDeploymentDiffInformation"/>. </summary>
        /// <param name="newArtifactsCount"> The number of new items deployed to the target stage. </param>
        /// <param name="differentArtifactsCount"> The number of deployed items with differences between source and target stages, before deployment. </param>
        /// <param name="noDifferenceArtifactsCount"> The number of identical deployed items in the source and target stages, before deployment. </param>
        internal PreDeploymentDiffInformation(int newArtifactsCount, int differentArtifactsCount, int noDifferenceArtifactsCount)
        {
            NewArtifactsCount = newArtifactsCount;
            DifferentArtifactsCount = differentArtifactsCount;
            NoDifferenceArtifactsCount = noDifferenceArtifactsCount;
        }

        /// <summary> The number of new items deployed to the target stage. </summary>
        public int NewArtifactsCount { get; }
        /// <summary> The number of deployed items with differences between source and target stages, before deployment. </summary>
        public int DifferentArtifactsCount { get; }
        /// <summary> The number of identical deployed items in the source and target stages, before deployment. </summary>
        public int NoDifferenceArtifactsCount { get; }
    }
}
