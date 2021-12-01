// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// OData response wrapper for unused artifact entities
    /// </summary>
    public partial class UnusedArtifactsResponse
    {
        /// <summary>
        /// Initializes a new instance of the UnusedArtifactsResponse class.
        /// </summary>
        public UnusedArtifactsResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UnusedArtifactsResponse class.
        /// </summary>
        /// <param name="unusedArtifactEntities">The unused artifact
        /// entities</param>
        public UnusedArtifactsResponse(IList<UnusedArtifactEntity> unusedArtifactEntities = default(IList<UnusedArtifactEntity>))
        {
            UnusedArtifactEntities = unusedArtifactEntities;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the unused artifact entities
        /// </summary>
        [JsonProperty(PropertyName = "unusedArtifactEntities")]
        public IList<UnusedArtifactEntity> UnusedArtifactEntities { get; set; }

    }
}