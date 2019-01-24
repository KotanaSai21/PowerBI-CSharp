// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.V2.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Power BI  refresh schedule request for DirectQuery or LiveConnection
    /// </summary>
    public partial class DirectQueryRefreshScheduleRequest
    {
        /// <summary>
        /// Initializes a new instance of the DirectQueryRefreshScheduleRequest
        /// class.
        /// </summary>
        public DirectQueryRefreshScheduleRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DirectQueryRefreshScheduleRequest
        /// class.
        /// </summary>
        /// <param name="value">An object containg the refresh schedule details
        /// for DirectQuery or LiveConnection</param>
        public DirectQueryRefreshScheduleRequest(DirectQueryRefreshSchedule value = default(DirectQueryRefreshSchedule))
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets an object containg the refresh schedule details for
        /// DirectQuery or LiveConnection
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public DirectQueryRefreshSchedule Value { get; set; }

    }
}
