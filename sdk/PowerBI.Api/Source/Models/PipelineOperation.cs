// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Microsoft.PowerBI.Api.Models
{
    /// <summary> A Power BI deployment pipeline operation. </summary>
    public partial class PipelineOperation
    {
        /// <summary> Initializes a new instance of <see cref="PipelineOperation"/>. </summary>
        /// <param name="id"> The operation ID. </param>
        /// <param name="status"> The pipeline operation status. </param>
        /// <param name="lastUpdatedTime"> The date and time that the operation was last updated. </param>
        internal PipelineOperation(Guid id, PipelineOperationStatus status, DateTimeOffset lastUpdatedTime)
        {
            Id = id;
            Status = status;
            LastUpdatedTime = lastUpdatedTime;
        }

        /// <summary> Initializes a new instance of <see cref="PipelineOperation"/>. </summary>
        /// <param name="id"> The operation ID. </param>
        /// <param name="type"> The operation type. </param>
        /// <param name="status"> The pipeline operation status. </param>
        /// <param name="lastUpdatedTime"> The date and time that the operation was last updated. </param>
        /// <param name="executionStartTime"> The date and time that the operation started. </param>
        /// <param name="executionEndTime"> The date and time that the operation ended. </param>
        /// <param name="sourceStageOrder"> The numeric identifier of a source pipeline deployment stage. Development (0), Test (1), Production (2). </param>
        /// <param name="targetStageOrder"> The numeric identifier of a target pipeline deployment stage. Development (0), Test (1), Production (2). </param>
        /// <param name="performedBy"> User or service principal that performed the pipeline operation. </param>
        /// <param name="note"> A note representing a description of the operation. </param>
        /// <param name="executionPlan"> The deployment execution plan. Only applicable to a single pipeline operation. </param>
        /// <param name="preDeploymentDiffInformation"> The amount of deployed items in the source stage, that are new, identical or different to items in the target stage, before deployment. </param>
        internal PipelineOperation(Guid id, PipelineOperationType? type, PipelineOperationStatus status, DateTimeOffset lastUpdatedTime, DateTimeOffset? executionStartTime, DateTimeOffset? executionEndTime, int? sourceStageOrder, int? targetStageOrder, PipelineOperationUser performedBy, PipelineOperationNote note, DeploymentExecutionPlan executionPlan, PreDeploymentDiffInformation preDeploymentDiffInformation)
        {
            Id = id;
            Type = type;
            Status = status;
            LastUpdatedTime = lastUpdatedTime;
            ExecutionStartTime = executionStartTime;
            ExecutionEndTime = executionEndTime;
            SourceStageOrder = sourceStageOrder;
            TargetStageOrder = targetStageOrder;
            PerformedBy = performedBy;
            Note = note;
            ExecutionPlan = executionPlan;
            PreDeploymentDiffInformation = preDeploymentDiffInformation;
        }

        /// <summary> The operation ID. </summary>
        public Guid Id { get; }
        /// <summary> The operation type. </summary>
        public PipelineOperationType? Type { get; }
        /// <summary> The pipeline operation status. </summary>
        public PipelineOperationStatus Status { get; }
        /// <summary> The date and time that the operation was last updated. </summary>
        public DateTimeOffset LastUpdatedTime { get; }
        /// <summary> The date and time that the operation started. </summary>
        public DateTimeOffset? ExecutionStartTime { get; }
        /// <summary> The date and time that the operation ended. </summary>
        public DateTimeOffset? ExecutionEndTime { get; }
        /// <summary> The numeric identifier of a source pipeline deployment stage. Development (0), Test (1), Production (2). </summary>
        public int? SourceStageOrder { get; }
        /// <summary> The numeric identifier of a target pipeline deployment stage. Development (0), Test (1), Production (2). </summary>
        public int? TargetStageOrder { get; }
        /// <summary> User or service principal that performed the pipeline operation. </summary>
        public PipelineOperationUser PerformedBy { get; }
        /// <summary> A note representing a description of the operation. </summary>
        public PipelineOperationNote Note { get; }
        /// <summary> The deployment execution plan. Only applicable to a single pipeline operation. </summary>
        public DeploymentExecutionPlan ExecutionPlan { get; }
        /// <summary> The amount of deployed items in the source stage, that are new, identical or different to items in the target stage, before deployment. </summary>
        public PreDeploymentDiffInformation PreDeploymentDiffInformation { get; }
    }
}
