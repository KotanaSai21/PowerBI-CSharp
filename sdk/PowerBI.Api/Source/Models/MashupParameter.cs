// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Microsoft.PowerBI.Api.Models
{
    /// <summary> A Power BI dataset parameter. </summary>
    public partial class MashupParameter
    {
        /// <summary> Initializes a new instance of <see cref="MashupParameter"/>. </summary>
        /// <param name="name"> The parameter name. </param>
        /// <param name="type"> The parameter type. </param>
        /// <param name="isRequired"> Whether the dataset parameter is required. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="type"/> is null. </exception>
        internal MashupParameter(string name, string type, bool isRequired)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(type, nameof(type));

            Name = name;
            Type = type;
            IsRequired = isRequired;
            SuggestedValues = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="MashupParameter"/>. </summary>
        /// <param name="name"> The parameter name. </param>
        /// <param name="type"> The parameter type. </param>
        /// <param name="currentValue"> The current value of the parameter. </param>
        /// <param name="isRequired"> Whether the dataset parameter is required. </param>
        /// <param name="suggestedValues"> A list of suggested parameter values. </param>
        internal MashupParameter(string name, string type, string currentValue, bool isRequired, IReadOnlyList<string> suggestedValues)
        {
            Name = name;
            Type = type;
            CurrentValue = currentValue;
            IsRequired = isRequired;
            SuggestedValues = suggestedValues;
        }

        /// <summary> The parameter name. </summary>
        public string Name { get; }
        /// <summary> The parameter type. </summary>
        public string Type { get; }
        /// <summary> The current value of the parameter. </summary>
        public string CurrentValue { get; }
        /// <summary> Whether the dataset parameter is required. </summary>
        public bool IsRequired { get; }
        /// <summary> A list of suggested parameter values. </summary>
        public IReadOnlyList<string> SuggestedValues { get; }
    }
}
