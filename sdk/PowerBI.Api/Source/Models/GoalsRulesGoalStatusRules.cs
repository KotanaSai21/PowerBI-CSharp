// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Microsoft.PowerBI.Api.Models
{
    /// <summary> The request data to be used when defining or reporting rules for the status of a Power BI goal. </summary>
    public partial class GoalsRulesGoalStatusRules
    {
        /// <summary> Initializes a new instance of <see cref="GoalsRulesGoalStatusRules"/>. </summary>
        internal GoalsRulesGoalStatusRules()
        {
            Rules = new ChangeTrackingList<GoalsRulesRule1OfInt32>();
        }

        /// <summary> Initializes a new instance of <see cref="GoalsRulesGoalStatusRules"/>. </summary>
        /// <param name="rules"> The list of rules. </param>
        /// <param name="defaultOutput">
        /// The status ID when no rule matches
        ///
        /// | ID | Description |
        /// |-|-|
        /// | 0 | Not started |
        /// | 1 | On track |
        /// | 2 | At risk |
        /// | 3 | Behind |
        /// | 4 | Overdue |
        /// | 5 | Completed |
        /// </param>
        /// <param name="scorecardObjectId"> The scorecard ID. </param>
        /// <param name="goalObjectId"> The goal ID. </param>
        /// <param name="lastModifiedTime"> The UTC time at last modification. </param>
        internal GoalsRulesGoalStatusRules(IReadOnlyList<GoalsRulesRule1OfInt32> rules, int? defaultOutput, string scorecardObjectId, string goalObjectId, DateTimeOffset? lastModifiedTime)
        {
            Rules = rules;
            DefaultOutput = defaultOutput;
            ScorecardObjectId = scorecardObjectId;
            GoalObjectId = goalObjectId;
            LastModifiedTime = lastModifiedTime;
        }

        /// <summary> The list of rules. </summary>
        public IReadOnlyList<GoalsRulesRule1OfInt32> Rules { get; }
        /// <summary>
        /// The status ID when no rule matches
        ///
        /// | ID | Description |
        /// |-|-|
        /// | 0 | Not started |
        /// | 1 | On track |
        /// | 2 | At risk |
        /// | 3 | Behind |
        /// | 4 | Overdue |
        /// | 5 | Completed |
        /// </summary>
        public int? DefaultOutput { get; }
        /// <summary> The scorecard ID. </summary>
        public string ScorecardObjectId { get; }
        /// <summary> The goal ID. </summary>
        public string GoalObjectId { get; }
        /// <summary> The UTC time at last modification. </summary>
        public DateTimeOffset? LastModifiedTime { get; }
    }
}
