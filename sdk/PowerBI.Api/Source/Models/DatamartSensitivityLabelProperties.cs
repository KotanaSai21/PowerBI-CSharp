// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Microsoft.PowerBI.Api.Models
{
    /// <summary> The DatamartSensitivityLabelProperties. </summary>
    public partial class DatamartSensitivityLabelProperties
    {
        /// <summary> Initializes a new instance of <see cref="DatamartSensitivityLabelProperties"/>. </summary>
        internal DatamartSensitivityLabelProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DatamartSensitivityLabelProperties"/>. </summary>
        /// <param name="sensitivityLabel"> The datamart sensitivity label. </param>
        internal DatamartSensitivityLabelProperties(SensitivityLabel sensitivityLabel)
        {
            SensitivityLabel = sensitivityLabel;
        }

        /// <summary> The datamart sensitivity label. </summary>
        public SensitivityLabel SensitivityLabel { get; }
    }
}
