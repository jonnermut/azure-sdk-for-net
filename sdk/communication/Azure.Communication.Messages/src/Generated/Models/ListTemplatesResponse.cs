// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.Communication.Messages
{
    /// <summary> The ListTemplatesResponse. </summary>
    internal partial class ListTemplatesResponse
    {
        /// <summary> Initializes a new instance of <see cref="ListTemplatesResponse"/>. </summary>
        /// <param name="value"> The collection of elements. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal ListTemplatesResponse(IEnumerable<TemplateResponseInternal> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="ListTemplatesResponse"/>. </summary>
        /// <param name="value"> The collection of elements. </param>
        /// <param name="nextLink"></param>
        internal ListTemplatesResponse(IReadOnlyList<TemplateResponseInternal> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The collection of elements. </summary>
        public IReadOnlyList<TemplateResponseInternal> Value { get; }
        /// <summary> Gets the next link. </summary>
        public string NextLink { get; }
    }
}
