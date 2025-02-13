// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Legacy
{
    /// <summary> The HealthcareTaskResult. </summary>
    internal partial class HealthcareTaskResult
    {
        /// <summary> Initializes a new instance of <see cref="HealthcareTaskResult"/>. </summary>
        internal HealthcareTaskResult()
        {
            Errors = new ChangeTrackingList<TextAnalyticsError>();
        }

        /// <summary> Initializes a new instance of <see cref="HealthcareTaskResult"/>. </summary>
        /// <param name="results"></param>
        /// <param name="errors"></param>
        internal HealthcareTaskResult(HealthcareResult results, IReadOnlyList<TextAnalyticsError> errors)
        {
            Results = results;
            Errors = errors;
        }

        /// <summary> Gets the results. </summary>
        public HealthcareResult Results { get; }
        /// <summary> Gets the errors. </summary>
        public IReadOnlyList<TextAnalyticsError> Errors { get; }
    }
}
