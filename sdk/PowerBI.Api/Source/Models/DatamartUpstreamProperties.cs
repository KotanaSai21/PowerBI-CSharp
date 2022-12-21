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

    public partial class DatamartUpstreamProperties
    {
        /// <summary>
        /// Initializes a new instance of the DatamartUpstreamProperties class.
        /// </summary>
        public DatamartUpstreamProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DatamartUpstreamProperties class.
        /// </summary>
        /// <param name="upstreamDataflows">The list of all the dataflows this
        /// item depends on</param>
        /// <param name="upstreamDatamarts">The list of all the datamarts this
        /// item depends on</param>
        public DatamartUpstreamProperties(IList<DependentDataflow> upstreamDataflows = default(IList<DependentDataflow>), IList<DependentDatamart> upstreamDatamarts = default(IList<DependentDatamart>))
        {
            UpstreamDataflows = upstreamDataflows;
            UpstreamDatamarts = upstreamDatamarts;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the list of all the dataflows this item depends on
        /// </summary>
        [JsonProperty(PropertyName = "upstreamDataflows")]
        public IList<DependentDataflow> UpstreamDataflows { get; set; }

        /// <summary>
        /// Gets or sets the list of all the datamarts this item depends on
        /// </summary>
        [JsonProperty(PropertyName = "upstreamDatamarts")]
        public IList<DependentDatamart> UpstreamDatamarts { get; set; }

    }
}
