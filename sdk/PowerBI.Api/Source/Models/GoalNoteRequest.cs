// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Microsoft.PowerBI.Api.Models
{
    /// <summary> A Power BI goal value check-in note request. </summary>
    public partial class GoalNoteRequest
    {
        /// <summary> Initializes a new instance of <see cref="GoalNoteRequest"/>. </summary>
        /// <param name="body"> The note text. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="body"/> is null. </exception>
        public GoalNoteRequest(string body)
        {
            Argument.AssertNotNull(body, nameof(body));

            Body = body;
        }

        /// <summary> The note text. </summary>
        public string Body { get; }
    }
}
