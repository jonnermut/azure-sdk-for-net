// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ProviderHub.Models
{
    /// <summary> The CustomRolloutProperties. </summary>
    public partial class CustomRolloutProperties
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="CustomRolloutProperties"/>. </summary>
        /// <param name="specification"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="specification"/> is null. </exception>
        public CustomRolloutProperties(CustomRolloutSpecification specification)
        {
            Argument.AssertNotNull(specification, nameof(specification));

            Specification = specification;
        }

        /// <summary> Initializes a new instance of <see cref="CustomRolloutProperties"/>. </summary>
        /// <param name="provisioningState"></param>
        /// <param name="specification"></param>
        /// <param name="status"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CustomRolloutProperties(ProviderHubProvisioningState? provisioningState, CustomRolloutSpecification specification, CustomRolloutStatus status, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ProvisioningState = provisioningState;
            Specification = specification;
            Status = status;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="CustomRolloutProperties"/> for deserialization. </summary>
        internal CustomRolloutProperties()
        {
        }

        /// <summary> Gets or sets the provisioning state. </summary>
        public ProviderHubProvisioningState? ProvisioningState { get; set; }
        /// <summary> Gets or sets the specification. </summary>
        public CustomRolloutSpecification Specification { get; set; }
        /// <summary> Gets or sets the status. </summary>
        public CustomRolloutStatus Status { get; set; }
    }
}
