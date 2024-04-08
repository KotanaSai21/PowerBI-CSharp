// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Microsoft.PowerBI.Api.Models
{
    /// <summary> An update request for a Power BI dataset parameter. </summary>
    public partial class UpdateMashupParametersRequest
    {
        /// <summary> Initializes a new instance of <see cref="UpdateMashupParametersRequest"/>. </summary>
        /// <param name="updateDetails"> A list of dataset parameters to update. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="updateDetails"/> is null. </exception>
        public UpdateMashupParametersRequest(IEnumerable<UpdateMashupParameterDetails> updateDetails)
        {
            Argument.AssertNotNull(updateDetails, nameof(updateDetails));

            UpdateDetails = updateDetails.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="UpdateMashupParametersRequest"/>. </summary>
        /// <param name="updateDetails"> A list of dataset parameters to update. </param>
        internal UpdateMashupParametersRequest(IList<UpdateMashupParameterDetails> updateDetails)
        {
            UpdateDetails = updateDetails;
        }

        /// <summary> A list of dataset parameters to update. </summary>
        public IList<UpdateMashupParameterDetails> UpdateDetails { get; }
    }
}
