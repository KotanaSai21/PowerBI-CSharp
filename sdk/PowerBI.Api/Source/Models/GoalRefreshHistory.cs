// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A refresh history entry for a Power BI goal
    /// </summary>
    public partial class GoalRefreshHistory
    {
        /// <summary>
        /// Initializes a new instance of the GoalRefreshHistory class.
        /// </summary>
        public GoalRefreshHistory()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GoalRefreshHistory class.
        /// </summary>
        /// <param name="goalId">The goal ID</param>
        /// <param name="connectionType">The refresh connection type. Possible
        /// values include: 'Current', 'Target', 'Status'</param>
        /// <param name="status">The status of the refresh processing. Possible
        /// values include: 'NotProcessed', 'Succeeded', 'Failed',
        /// 'UserNotFound', 'QueryExecutionError', 'QueryResultError',
        /// 'BadQueryResultMetadata', 'EmptyGoalValues',
        /// 'ConnectedDatasetDeleted', 'UserNotAuthorized', 'ModelNotFound',
        /// 'ScorecardNotFound'</param>
        /// <param name="timestamp">The UTC timestamp of the refresh
        /// operation</param>
        /// <param name="rootActivityId">The root activity ID</param>
        /// <param name="message">The verbal description of the status of the
        /// refresh operation</param>
        public GoalRefreshHistory(System.Guid? goalId = default(System.Guid?), GoalValueType? connectionType = default(GoalValueType?), GoalProcessingStatus? status = default(GoalProcessingStatus?), System.DateTime? timestamp = default(System.DateTime?), System.Guid? rootActivityId = default(System.Guid?), string message = default(string))
        {
            GoalId = goalId;
            ConnectionType = connectionType;
            Status = status;
            Timestamp = timestamp;
            RootActivityId = rootActivityId;
            Message = message;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the goal ID
        /// </summary>
        [JsonProperty(PropertyName = "goalId")]
        public System.Guid? GoalId { get; set; }

        /// <summary>
        /// Gets or sets the refresh connection type. Possible values include:
        /// 'Current', 'Target', 'Status'
        /// </summary>
        [JsonProperty(PropertyName = "connectionType")]
        public GoalValueType? ConnectionType { get; set; }

        /// <summary>
        /// Gets or sets the status of the refresh processing. Possible values
        /// include: 'NotProcessed', 'Succeeded', 'Failed', 'UserNotFound',
        /// 'QueryExecutionError', 'QueryResultError',
        /// 'BadQueryResultMetadata', 'EmptyGoalValues',
        /// 'ConnectedDatasetDeleted', 'UserNotAuthorized', 'ModelNotFound',
        /// 'ScorecardNotFound'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public GoalProcessingStatus? Status { get; set; }

        /// <summary>
        /// Gets or sets the UTC timestamp of the refresh operation
        /// </summary>
        [JsonProperty(PropertyName = "timestamp")]
        public System.DateTime? Timestamp { get; set; }

        /// <summary>
        /// Gets or sets the root activity ID
        /// </summary>
        [JsonProperty(PropertyName = "rootActivityId")]
        public System.Guid? RootActivityId { get; set; }

        /// <summary>
        /// Gets or sets the verbal description of the status of the refresh
        /// operation
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

    }
}