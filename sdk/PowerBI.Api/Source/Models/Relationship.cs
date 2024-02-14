// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Microsoft.PowerBI.Api.Models
{
    /// <summary> A relationship between tables in a dataset. </summary>
    public partial class Relationship
    {
        /// <summary> Initializes a new instance of <see cref="Relationship"/>. </summary>
        /// <param name="name"> The relationship name and identifier. </param>
        /// <param name="fromTable"> The name of the foreign key table. </param>
        /// <param name="fromColumn"> The name of the foreign key column. </param>
        /// <param name="toTable"> The name of the primary key table. </param>
        /// <param name="toColumn"> The name of the primary key column. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="fromTable"/>, <paramref name="fromColumn"/>, <paramref name="toTable"/> or <paramref name="toColumn"/> is null. </exception>
        public Relationship(string name, string fromTable, string fromColumn, string toTable, string toColumn)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(fromTable, nameof(fromTable));
            Argument.AssertNotNull(fromColumn, nameof(fromColumn));
            Argument.AssertNotNull(toTable, nameof(toTable));
            Argument.AssertNotNull(toColumn, nameof(toColumn));

            Name = name;
            FromTable = fromTable;
            FromColumn = fromColumn;
            ToTable = toTable;
            ToColumn = toColumn;
        }

        /// <summary> Initializes a new instance of <see cref="Relationship"/>. </summary>
        /// <param name="name"> The relationship name and identifier. </param>
        /// <param name="crossFilteringBehavior"> The filter direction of the relationship. </param>
        /// <param name="fromTable"> The name of the foreign key table. </param>
        /// <param name="fromColumn"> The name of the foreign key column. </param>
        /// <param name="toTable"> The name of the primary key table. </param>
        /// <param name="toColumn"> The name of the primary key column. </param>
        internal Relationship(string name, CrossFilteringBehavior? crossFilteringBehavior, string fromTable, string fromColumn, string toTable, string toColumn)
        {
            Name = name;
            CrossFilteringBehavior = crossFilteringBehavior;
            FromTable = fromTable;
            FromColumn = fromColumn;
            ToTable = toTable;
            ToColumn = toColumn;
        }

        /// <summary> The relationship name and identifier. </summary>
        public string Name { get; }
        /// <summary> The filter direction of the relationship. </summary>
        public CrossFilteringBehavior? CrossFilteringBehavior { get; set; }
        /// <summary> The name of the foreign key table. </summary>
        public string FromTable { get; }
        /// <summary> The name of the foreign key column. </summary>
        public string FromColumn { get; }
        /// <summary> The name of the primary key table. </summary>
        public string ToTable { get; }
        /// <summary> The name of the primary key column. </summary>
        public string ToColumn { get; }
    }
}
