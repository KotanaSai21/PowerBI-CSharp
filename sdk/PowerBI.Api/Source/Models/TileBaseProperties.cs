// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Microsoft.PowerBI.Api.Models
{
    /// <summary> The TileBaseProperties. </summary>
    public partial class TileBaseProperties
    {
        /// <summary> Initializes a new instance of <see cref="TileBaseProperties"/>. </summary>
        /// <param name="id"> The tile ID. </param>
        public TileBaseProperties(Guid id)
        {
            Id = id;
        }

        /// <summary> Initializes a new instance of <see cref="TileBaseProperties"/>. </summary>
        /// <param name="id"> The tile ID. </param>
        /// <param name="title"> The display name of the tile. </param>
        /// <param name="reportId"> The report ID. Available only for tiles created from a report. </param>
        /// <param name="datasetId"> The dataset ID. Available only for tiles created from a report or by using a dataset, such as Q&amp;A tiles. </param>
        internal TileBaseProperties(Guid id, string title, Guid? reportId, string datasetId)
        {
            Id = id;
            Title = title;
            ReportId = reportId;
            DatasetId = datasetId;
        }

        /// <summary> The tile ID. </summary>
        public Guid Id { get; set; }
        /// <summary> The display name of the tile. </summary>
        public string Title { get; set; }
        /// <summary> The report ID. Available only for tiles created from a report. </summary>
        public Guid? ReportId { get; set; }
        /// <summary> The dataset ID. Available only for tiles created from a report or by using a dataset, such as Q&amp;A tiles. </summary>
        public string DatasetId { get; set; }
    }
}
