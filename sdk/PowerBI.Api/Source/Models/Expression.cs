// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Microsoft.PowerBI.Api.Models
{
    /// <summary> A dataset expression. </summary>
    public partial class Expression
    {
        /// <summary> Initializes a new instance of <see cref="Expression"/>. </summary>
        /// <param name="expressionProperty"> A dataset table source. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="expressionProperty"/> is null. </exception>
        public Expression(ASMashupExpression expressionProperty)
        {
            Argument.AssertNotNull(expressionProperty, nameof(expressionProperty));

            ExpressionProperty = expressionProperty;
        }

        /// <summary> Initializes a new instance of <see cref="Expression"/>. </summary>
        /// <param name="expressionProperty"> A dataset table source. </param>
        /// <param name="name"> The expression name. </param>
        /// <param name="description"> The expression description. </param>
        internal Expression(ASMashupExpression expressionProperty, string name, string description)
        {
            ExpressionProperty = expressionProperty;
            Name = name;
            Description = description;
        }

        /// <summary> A dataset table source. </summary>
        public ASMashupExpression ExpressionProperty { get; set; }
        /// <summary> The expression name. </summary>
        public string Name { get; set; }
        /// <summary> The expression description. </summary>
        public string Description { get; set; }
    }
}
