// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Microsoft.PowerBI.Api.Models
{
    /// <summary> The GroupBaseProperties. </summary>
    public partial class GroupBaseProperties
    {
        /// <summary> Initializes a new instance of <see cref="GroupBaseProperties"/>. </summary>
        /// <param name="id"> The workspace ID. </param>
        public GroupBaseProperties(Guid id)
        {
            Id = id;
        }

        /// <summary> Initializes a new instance of <see cref="GroupBaseProperties"/>. </summary>
        /// <param name="id"> The workspace ID. </param>
        /// <param name="name"> The group name. </param>
        internal GroupBaseProperties(Guid id, string name)
        {
            Id = id;
            Name = name;
        }

        /// <summary> The workspace ID. </summary>
        public Guid Id { get; set; }
        /// <summary> The group name. </summary>
        public string Name { get; set; }
    }
}
