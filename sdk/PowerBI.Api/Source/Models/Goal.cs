// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Microsoft.PowerBI.Api.Models
{
    /// <summary> A Power BI goal. </summary>
    public partial class Goal
    {
        /// <summary> Initializes a new instance of <see cref="Goal"/>. </summary>
        public Goal()
        {
            GoalValues = new ChangeTrackingList<GoalValue>();
            Aggregations = new ChangeTrackingList<GoalAggregation>();
        }

        /// <summary> Initializes a new instance of <see cref="Goal"/>. </summary>
        /// <param name="id"> The goal ID. </param>
        /// <param name="name"> The goal name. </param>
        /// <param name="scorecardId"> The scorecard ID. </param>
        /// <param name="createdTime"> The UTC time at creation. </param>
        /// <param name="lastModifiedTime"> The UTC time at last modification. </param>
        /// <param name="startDate"> The UTC timestamp for the start date of the goal. The time portion of the timestamp is zero. </param>
        /// <param name="completionDate"> The UTC timestamp for the completion date of the goal. The time portion of the timestamp is zero. </param>
        /// <param name="parentId"> The ID of the parent goal, if defined. </param>
        /// <param name="notesCount"> notesCount. </param>
        /// <param name="valuesFormatString"> valuesFormatString. </param>
        /// <param name="datesFormatString"> datesFormatString. </param>
        /// <param name="description"> The goal description. </param>
        /// <param name="hasStatusRules"> Whether the goal has status rules defined. </param>
        /// <param name="statusRules"> The goal status rules. </param>
        /// <param name="permissions"> The goal permissions. </param>
        /// <param name="level"> The nested level of the goal in the parent-child hierarchy of scorecard goals. </param>
        /// <param name="rank"> The rank of the goal within the ordered set of sibling goals. </param>
        /// <param name="goalValues"> The list of goal value check-ins. </param>
        /// <param name="aggregations"> The list of aggregated properties of the goal. </param>
        internal Goal(Guid? id, string name, Guid? scorecardId, DateTimeOffset? createdTime, DateTimeOffset? lastModifiedTime, DateTimeOffset? startDate, DateTimeOffset? completionDate, Guid? parentId, int? notesCount, string valuesFormatString, string datesFormatString, string description, bool? hasStatusRules, GoalsRulesGoalRulesContainer statusRules, GoalPermissions? permissions, int? level, long? rank, IList<GoalValue> goalValues, IList<GoalAggregation> aggregations)
        {
            Id = id;
            Name = name;
            ScorecardId = scorecardId;
            CreatedTime = createdTime;
            LastModifiedTime = lastModifiedTime;
            StartDate = startDate;
            CompletionDate = completionDate;
            ParentId = parentId;
            NotesCount = notesCount;
            ValuesFormatString = valuesFormatString;
            DatesFormatString = datesFormatString;
            Description = description;
            HasStatusRules = hasStatusRules;
            StatusRules = statusRules;
            Permissions = permissions;
            Level = level;
            Rank = rank;
            GoalValues = goalValues;
            Aggregations = aggregations;
        }

        /// <summary> The goal ID. </summary>
        public Guid? Id { get; set; }
        /// <summary> The goal name. </summary>
        public string Name { get; set; }
        /// <summary> The scorecard ID. </summary>
        public Guid? ScorecardId { get; set; }
        /// <summary> The UTC time at creation. </summary>
        public DateTimeOffset? CreatedTime { get; set; }
        /// <summary> The UTC time at last modification. </summary>
        public DateTimeOffset? LastModifiedTime { get; set; }
        /// <summary> The UTC timestamp for the start date of the goal. The time portion of the timestamp is zero. </summary>
        public DateTimeOffset? StartDate { get; set; }
        /// <summary> The UTC timestamp for the completion date of the goal. The time portion of the timestamp is zero. </summary>
        public DateTimeOffset? CompletionDate { get; set; }
        /// <summary> The ID of the parent goal, if defined. </summary>
        public Guid? ParentId { get; set; }
        /// <summary> notesCount. </summary>
        public int? NotesCount { get; set; }
        /// <summary> valuesFormatString. </summary>
        public string ValuesFormatString { get; set; }
        /// <summary> datesFormatString. </summary>
        public string DatesFormatString { get; set; }
        /// <summary> The goal description. </summary>
        public string Description { get; set; }
        /// <summary> Whether the goal has status rules defined. </summary>
        public bool? HasStatusRules { get; set; }
        /// <summary> The goal status rules. </summary>
        public GoalsRulesGoalRulesContainer StatusRules { get; set; }
        /// <summary> The goal permissions. </summary>
        public GoalPermissions? Permissions { get; set; }
        /// <summary> The nested level of the goal in the parent-child hierarchy of scorecard goals. </summary>
        public int? Level { get; set; }
        /// <summary> The rank of the goal within the ordered set of sibling goals. </summary>
        public long? Rank { get; set; }
        /// <summary> The list of goal value check-ins. </summary>
        public IList<GoalValue> GoalValues { get; }
        /// <summary> The list of aggregated properties of the goal. </summary>
        public IList<GoalAggregation> Aggregations { get; }
    }
}
