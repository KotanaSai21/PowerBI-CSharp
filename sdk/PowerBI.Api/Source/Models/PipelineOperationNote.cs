// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Microsoft.PowerBI.Api.Models
{
    /// <summary> A note describing the deployment. </summary>
    public partial class PipelineOperationNote
    {
        /// <summary> Initializes a new instance of <see cref="PipelineOperationNote"/>. </summary>
        /// <param name="content"> Text describing the deployment. </param>
        /// <param name="isTruncated"> Indicates if the note is incomplete. True, only part of the note is returned. False, the note is complete. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        internal PipelineOperationNote(string content, bool isTruncated)
        {
            Argument.AssertNotNull(content, nameof(content));

            Content = content;
            IsTruncated = isTruncated;
        }

        /// <summary> Text describing the deployment. </summary>
        public string Content { get; }
        /// <summary> Indicates if the note is incomplete. True, only part of the note is returned. False, the note is complete. </summary>
        public bool IsTruncated { get; }
    }
}
