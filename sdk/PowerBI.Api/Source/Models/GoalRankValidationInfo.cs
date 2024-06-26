// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Microsoft.PowerBI.Api.Models
{
    /// <summary> The rank validation information for a Power BI goal, to be used with the [Move Goals](/rest/api/power-bi/scorecards_(preview)/move-goals) API request. The caller provides validation information to confirm that they know the existing position of the goal within the hierarchy of goals. </summary>
    public partial class GoalRankValidationInfo
    {
        /// <summary> Initializes a new instance of <see cref="GoalRankValidationInfo"/>. </summary>
        public GoalRankValidationInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="GoalRankValidationInfo"/>. </summary>
        /// <param name="goalId"> The goal ID. </param>
        /// <param name="currentParentId"> The ID of the current parent goal. </param>
        internal GoalRankValidationInfo(Guid? goalId, Guid? currentParentId)
        {
            GoalId = goalId;
            CurrentParentId = currentParentId;
        }

        /// <summary> The goal ID. </summary>
        public Guid? GoalId { get; set; }
        /// <summary> The ID of the current parent goal. </summary>
        public Guid? CurrentParentId { get; set; }
    }
}
