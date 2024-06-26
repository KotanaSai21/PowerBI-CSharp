// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Microsoft.PowerBI.Api.Models
{
    /// <summary> A Power BI dataset. </summary>
    public partial class CreateDatasetRequest
    {
        /// <summary> Initializes a new instance of <see cref="CreateDatasetRequest"/>. </summary>
        /// <param name="name"> The dataset name. </param>
        /// <param name="tables"> The dataset tables. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="tables"/> is null. </exception>
        public CreateDatasetRequest(string name, IEnumerable<Table> tables)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(tables, nameof(tables));

            Name = name;
            Tables = tables.ToList();
            Relationships = new ChangeTrackingList<Relationship>();
            Datasources = new ChangeTrackingList<Datasource>();
        }

        /// <summary> Initializes a new instance of <see cref="CreateDatasetRequest"/>. </summary>
        /// <param name="name"> The dataset name. </param>
        /// <param name="tables"> The dataset tables. </param>
        /// <param name="relationships"> The dataset relationships. </param>
        /// <param name="datasources"> The data sources associated with this dataset. </param>
        /// <param name="defaultMode"> The dataset mode or type. </param>
        internal CreateDatasetRequest(string name, IList<Table> tables, IList<Relationship> relationships, IList<Datasource> datasources, DatasetMode? defaultMode)
        {
            Name = name;
            Tables = tables;
            Relationships = relationships;
            Datasources = datasources;
            DefaultMode = defaultMode;
        }

        /// <summary> The dataset name. </summary>
        public string Name { get; }
        /// <summary> The dataset tables. </summary>
        public IList<Table> Tables { get; }
        /// <summary> The dataset relationships. </summary>
        public IList<Relationship> Relationships { get; }
        /// <summary> The data sources associated with this dataset. </summary>
        public IList<Datasource> Datasources { get; }
        /// <summary> The dataset mode or type. </summary>
        public DatasetMode? DefaultMode { get; set; }
    }
}
