// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Microsoft.PowerBI.Api.Models
{
    /// <summary> The response to a dataset execute queries request. </summary>
    public partial class DatasetExecuteQueriesResponse
    {
        /// <summary> Initializes a new instance of <see cref="DatasetExecuteQueriesResponse"/>. </summary>
        internal DatasetExecuteQueriesResponse()
        {
            Results = new ChangeTrackingList<DatasetExecuteQueriesQueryResult>();
        }

        /// <summary> Initializes a new instance of <see cref="DatasetExecuteQueriesResponse"/>. </summary>
        /// <param name="informationProtectionLabel"> The details of the information protection label, if any, associated with the dataset. </param>
        /// <param name="results"> The list of results, one per input query. </param>
        /// <param name="error"> The details of an error, if present. </param>
        internal DatasetExecuteQueriesResponse(DatasetExecuteQueriesInformationProtectionLabel informationProtectionLabel, IReadOnlyList<DatasetExecuteQueriesQueryResult> results, DatasetExecuteQueriesError error)
        {
            InformationProtectionLabel = informationProtectionLabel;
            Results = results;
            Error = error;
        }

        /// <summary> The details of the information protection label, if any, associated with the dataset. </summary>
        public DatasetExecuteQueriesInformationProtectionLabel InformationProtectionLabel { get; }
        /// <summary> The list of results, one per input query. </summary>
        public IReadOnlyList<DatasetExecuteQueriesQueryResult> Results { get; }
        /// <summary> The details of an error, if present. </summary>
        public DatasetExecuteQueriesError Error { get; }
    }
}
