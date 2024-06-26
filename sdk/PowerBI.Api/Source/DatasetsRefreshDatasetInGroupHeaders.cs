// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure;
using Azure.Core;

namespace Microsoft.PowerBI.Api
{
    internal partial class DatasetsRefreshDatasetInGroupHeaders
    {
        private readonly Response _response;
        public DatasetsRefreshDatasetInGroupHeaders(Response response)
        {
            _response = response;
        }
        /// <summary> The full URI for [getting refresh execution details in group](#/operationId/Datasets_GetRefreshExecutionDetailsInGroup) or [cancelling refresh in group](/rest/api/power-bi/datasets/cancel-refresh-in-group). This would be returned only if any request payload except `notifyOption` is set. </summary>
        public Uri Location => _response.Headers.TryGetValue("Location", out Uri value) ? value : null;
    }
}
