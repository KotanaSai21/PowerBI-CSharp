// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Microsoft.PowerBI.Api.Models
{
    /// <summary> The OData response wrapper for a list of Power BI items (such as reports or dashboards) that a user can access. </summary>
    public partial class ArtifactAccessResponse
    {
        /// <summary> Initializes a new instance of <see cref="ArtifactAccessResponse"/>. </summary>
        internal ArtifactAccessResponse()
        {
            ArtifactAccessEntities = new ChangeTrackingList<ArtifactAccessEntry>();
        }

        /// <summary> Initializes a new instance of <see cref="ArtifactAccessResponse"/>. </summary>
        /// <param name="odataContext"></param>
        /// <param name="artifactAccessEntities"> The list of Power BI items that a user can access. </param>
        /// <param name="continuationUri"> The URI of the next chunk in the result set. </param>
        /// <param name="continuationToken"> The token for the next chunk in the result set. </param>
        internal ArtifactAccessResponse(string odataContext, IReadOnlyList<ArtifactAccessEntry> artifactAccessEntities, string continuationUri, string continuationToken)
        {
            OdataContext = odataContext;
            ArtifactAccessEntities = artifactAccessEntities;
            ContinuationUri = continuationUri;
            ContinuationToken = continuationToken;
        }

        /// <summary> Gets the odata context. </summary>
        public string OdataContext { get; }
        /// <summary> The list of Power BI items that a user can access. </summary>
        public IReadOnlyList<ArtifactAccessEntry> ArtifactAccessEntities { get; }
        /// <summary> The URI of the next chunk in the result set. </summary>
        public string ContinuationUri { get; }
        /// <summary> The token for the next chunk in the result set. </summary>
        public string ContinuationToken { get; }
    }
}
