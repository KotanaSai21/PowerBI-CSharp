// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class TileLayoutProperties
    {
        /// <summary>
        /// Initializes a new instance of the TileLayoutProperties class.
        /// </summary>
        public TileLayoutProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TileLayoutProperties class.
        /// </summary>
        /// <param name="rowSpan">The number of tile span rows</param>
        /// <param name="colSpan">The number of tile span columns</param>
        public TileLayoutProperties(int? rowSpan = default(int?), int? colSpan = default(int?))
        {
            RowSpan = rowSpan;
            ColSpan = colSpan;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the number of tile span rows
        /// </summary>
        [JsonProperty(PropertyName = "rowSpan")]
        public int? RowSpan { get; set; }

        /// <summary>
        /// Gets or sets the number of tile span columns
        /// </summary>
        [JsonProperty(PropertyName = "colSpan")]
        public int? ColSpan { get; set; }

    }
}