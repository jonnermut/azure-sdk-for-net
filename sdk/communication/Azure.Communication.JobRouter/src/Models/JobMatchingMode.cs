// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.JobRouter
{
    public abstract partial class JobMatchingMode
    {
        /// <summary> The type discriminator describing a sub-type of JobMatchingMode. </summary>
        public JobMatchingModeKind Kind { get; protected set; }
    }
}
